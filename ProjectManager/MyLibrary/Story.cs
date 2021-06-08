using System;

namespace MyLibrary
{
    /// <summary>
    /// Story type task.
    /// </summary>
    [Serializable]
    public class Story : Task
    {
        public Story()
        {
            this.ExecutorsLimit = 10;
        }

        /// <param name="type"> Task type. </param>
        /// <param name="name"> Task name. </param>
        public Story(byte status, string name) : base(status, name)
        {
            this.ExecutorsLimit = 10;
        }
    }
}
