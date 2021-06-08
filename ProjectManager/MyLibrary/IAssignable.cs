using System.Collections.Generic;

namespace MyLibrary
{
    interface IAssignable
    {
        /// <summary>
        /// Executors list.
        /// </summary>
        List<User> Executors { get; set; }

        /// <summary>
        /// Executors count limit.
        /// </summary>
        int ExecutorsLimit { get; set; }

        /// <summary>
        /// Adds executor.
        /// </summary>
        /// <param name="e"></param>
        void AddExecutor(User e);

        /// <summary>
        /// Removes executor.
        /// </summary>
        /// <param name="e"></param>
        void RemoveExecutor(User e);

    }
}
