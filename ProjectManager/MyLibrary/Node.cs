using System;
using System.Collections.Generic;

namespace MyLibrary
{
    /// <summary>
    /// Task node in tasks tree.
    /// </summary>
    [Serializable]
    public class Node
    {
        /// <summary>
        /// Node name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Task in node.
        /// </summary>
        public Task task;

        /// <summary>
        /// Task type.
        /// -1 - root.
        /// 0 - bug.
        /// 1 - epic.
        /// 2 - story.
        /// 3 - task.
        /// </summary>
        public int taskType = -1;

        /// <summary>
        /// Parent node.
        /// </summary>
        public Node parent;

        /// <summary>
        /// Children nodes.
        /// </summary>
        public List<Node> children = new List<Node>();

        public Node() { }

        /// <param name="name"> Task name. </param>
        public Node(string name)
        {
            Name = name;
        }

        /// <param name="name"> Task name. </param>
        /// <param name="taskType"> Task type. </param>
        /// <param name="task"> Task entity. </param>
        public Node(string name, int taskType, Task task)
        {
            Name = name;
            this.taskType = taskType;
            this.task = task;
        }
    }
}
