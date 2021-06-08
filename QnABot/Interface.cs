using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QnABot.Tools
{
    interface ITool
    {
        string Description { get; set; }
        string CommandsName { get; set; }
    }
}