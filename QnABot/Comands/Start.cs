using QnABot.Tools;

namespace QnABot.Comands
{
    public class Start : ITool
    {
        protected Test test = new Test();
        protected Answers answers = new Answers();

        public string Description { get; set; }
        public string CommandsName { get; set; }

        public string WelcomeMessage =>
            "Привет!\n\nЯ - бот, который поможет с изучением C#. Пока что я могу:\n\n" +
            $"{answers.CommandsName} - {answers.Description}\n\n{test.CommandsName} - {test.Description}\n\n"+
            $"{CommandsName} - {Description}";

        public Start()
        {
            Description = "Начать работу";
            CommandsName = "/start";
        }
    }
}
