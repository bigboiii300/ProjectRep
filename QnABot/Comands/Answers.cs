using QnABot.Tools;

namespace QnABot.Comands
{
    public class Answers : ITool
    {
        public string Description { get; set; }
        public string CommandsName { get; set; }

        public Answers()
        {
            Description = "О чем ты хочешь узнать?";
            CommandsName = "/answer";
        }
    }
}
