using System;
using System.Collections.Generic;

namespace MyLibrary
{
    /// <summary>
    /// Stores all project data.
    /// </summary>
    [Serializable]
    public class Data : AppData<Data>
    {
        /// <summary>
        /// List of users.
        /// </summary>
        public List<User> users = new List<User>();

        /// <summary>
        /// List of projects.
        /// </summary>
        public List<Project> projects = new List<Project>();

        /// <summary>
        /// Selected project.
        /// </summary>
        public Project currentProject;

    }
}
