using System;

namespace MyLibrary
{
    /// <summary>
    /// Bug type task.
    /// </summary>
    [Serializable]
    public class Bug : Task
    {
        public Bug() { }

        /// <param name="type"> Task type. </param>
        /// <param name="name"> Task name. </param>
        public Bug(byte type, string name) : base(type, name) { }
    }

}
