using System;

namespace MyLibrary
{
    /// <summary>
    /// Epic type task.
    /// </summary>
    [Serializable]
    public class Epic : Story
    {
        public Epic() : base()
        {

        }

        /// <param name="type"> Task type. </param>
        /// <param name="name"> Task name. </param>
        public Epic(byte status, string name) : base(status, name) { }

    }
}
