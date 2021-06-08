using System;
using System.Collections.Generic;

namespace MyLibrary
{
    [Serializable]
    public class Project
    {
        /// <summary>
        /// Tasks limit.
        /// </summary>
        private const int tasksLimit = 20;

        /// <summary>
        /// Tasks count.
        /// </summary>
        private int tasksCounter = 0;

        /// <summary>
        /// Project name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Root in tasks tree.
        /// </summary>
        public Node root = new Node();

        /// <summary>
        /// Dictionary with all tasks tree nodes.
        /// </summary>
        public Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public Project() { }

        /// <param name="name"> Project name. </param>
        public Project(string name)
        {
            Name = name;
            nodes.Add("", root);
        }

        /// <summary>
        /// Adds task in tasks tree.
        /// </summary>
        /// <param name="name"> Parent node name. </param>
        /// <param name="node"> New node. </param>
        public void AddNode(string name, Node node)
        {
            if (tasksCounter == tasksLimit)
            {
                throw new ArgumentException($"Нельзя добавить больше {tasksLimit} задач");
            }
            ++tasksCounter;
            nodes.TryGetValue(name, out Node parent);
            if (parent != null)
            {
                if (parent.taskType >= node.taskType || parent.taskType == 0)
                {
                    throw new ArgumentException("Некорректное присвоение задачи");
                }

                parent.children.Add(node);
                node.parent = parent;
                nodes.Add(node.Name, node);
            }
        }

        /// <summary>
        /// Deletes task.
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(Node node)
        {
            --tasksCounter;
            int pos = node.parent.children.FindIndex(x => x.Name == node.Name);
            node.parent.children.RemoveAt(pos);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
