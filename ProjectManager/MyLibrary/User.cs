using System;

namespace MyLibrary
{
    [Serializable]
    public class User
    {
        /// <summary>
        /// User name.
        /// </summary>
        public string Name { get; set; }

        public User() { }

        /// <param name="name"> User name. </param>
        public User(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
