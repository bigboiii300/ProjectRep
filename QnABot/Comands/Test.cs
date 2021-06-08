using QnABot.Tools;

namespace QnABot.Comands
{
    public class Test : ITool
    {
        public string Description { get; set; }
        public string CommandsName { get; set; }

        public Test()
        {
            Description = "Начать тестирование по теоретической части";
            CommandsName = "/test";
        }
    }
}
