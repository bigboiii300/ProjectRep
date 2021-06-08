// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using QnABot.Images;
using QnABot.Users;

namespace Microsoft.BotBuilderSamples.Bots
{
    public class QnABot<T> : ActivityHandler where T : Microsoft.Bot.Builder.Dialogs.Dialog
    {
        protected readonly BotState ConversationState;  // Defines a state management object
        protected readonly Microsoft.Bot.Builder.Dialogs.Dialog Dialog;  // Object of Base class for all Dialogs
        protected readonly BotState UserState;  // Defines a state management object
        protected SendImages sendImage = new SendImages();  // Object creation 
        protected UserInfo CurrentUser;  // Object that gives us info about current user

        public static bool WasTest { get; set; }

        public QnABot(ConversationState conversationState, UserState userState, T dialog)
        {
            ConversationState = conversationState;
            UserState = userState;
            Dialog = dialog;
        }

        public override async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            await base.OnTurnAsync(turnContext, cancellationToken);

            // Save any state changes that might have occured during the turn.
            await ConversationState.SaveChangesAsync(turnContext, false, cancellationToken);
            await UserState.SaveChangesAsync(turnContext, false, cancellationToken);
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            if (turnContext.Activity.Text != null)
            {

                //user definitions
                foreach (var item in Users.UsersList)
                    if (item.Id == turnContext.Activity.Recipient.Id) CurrentUser = item;
                //checking the executable command
                CheckCommands(turnContext, CurrentUser);
                //testing process implementation
                if (WasTest)
                {
                    //sending the correct answer
                    if (turnContext.Activity.Text.ToLower() == "/prompt")
                    {
                        await sendImage.SendRightReply(turnContext, cancellationToken, CurrentUser);
                        await sendImage.SendImageAsync(turnContext, cancellationToken, CurrentUser);
                        //check if the user has passed all the questions
                        if (!SendImages.WasEnded)
                            await sendImage.SendButtonAsync(turnContext, cancellationToken, CurrentUser);
                        SendImages.WasEnded = false;
                    }
                    else
                    {
                        //validation of the answer
                        if (!SendImages.WasAnswer)
                            await sendImage.CheckReplyAsync(turnContext, cancellationToken, CurrentUser);
                        //sending the next question if the previous one was correct
                        if (SendImages.RightAnswer)
                        {
                            await sendImage.SendImageAsync(turnContext, cancellationToken, CurrentUser);
                            if (!SendImages.WasEnded)
                                await sendImage.SendButtonAsync(turnContext, cancellationToken, CurrentUser);
                            SendImages.WasAnswer = false;
                            SendImages.WasEnded = false;
                        }
                    }
                }
                else
                {
                    if (turnContext.Activity.Text.ToLower() == "/answer")
                    {
                        await turnContext.SendActivityAsync(MessageFactory.Text("ѕросто введи название нужной темы!"), cancellationToken);
                        return;
                    }
                    if (turnContext.Activity.Text.ToLower() == "/help")
                    {
                        await turnContext.SendActivityAsync(MessageFactory.Text("/test чтобы начать тестирование" +
                            $"{Environment.NewLine}/answer чтобы из режима теста выйти в режим ответа на вопросы" +
                            $"{Environment.NewLine}/prompt чтобы получить подсказку во врем€ теста"), cancellationToken);
                        return;
                    }

                    if (turnContext.Activity.Text.ToLower() == "/prompt")
                        await turnContext.SendActivityAsync(MessageFactory.Text("ѕодсказки доступны только во врем€ тестировани€!"), cancellationToken);
                    else
                        await Dialog.RunAsync(turnContext,
                            ConversationState.CreateProperty<DialogState>(nameof(DialogState)), cancellationToken);
                }
            }
            else
                await turnContext.SendActivityAsync(MessageFactory.Text("  сожалению, € пока могу распознавать только текст."), cancellationToken);

        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    Users.AddUser(new UserInfo(turnContext.Activity.Recipient.Id));
                    await turnContext.SendActivityAsync(MessageFactory.Text($" ѕривет,{turnContext.Activity.Recipient.Name}! я - бот, который поможет тебе с изучением C#!" +
                                                                            $"{Environment.NewLine}ѕросто введи название темы,которую хочешь узнать." +
                                                                            $"{Environment.NewLine}≈сли хочешь пройти тестирование,то введи /test"), cancellationToken);
                }
            }
        }

        /// <summary>
        /// check if a command was entered
        /// </summary>
        /// <param name="turnContext">activity received</param>
        /// <param name="user">current user</param>
        private void CheckCommands(ITurnContext turnContext, UserInfo user)
        {
            if (turnContext.Activity.Text.ToLower() == "/test")
            {
                WasTest = true;
                sendImage = new SendImages();
            }
            if (turnContext.Activity.Text.ToLower() == "/answer")
            {
                WasTest = false;
                SendImages.WasAnswer = true;
                SendImages.RightAnswer = true;
                if (user.Current != 0)
                    user.Current--;
            }
        }
    }
}
