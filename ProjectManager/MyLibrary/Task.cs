using System;
using System.Collections.Generic;

namespace MyLibrary
{
    /// <summary>
    /// Basic type task.
    /// </summary>
    [Serializable]
    public class Task : IAssignable
    {
        /// <summary>
        /// Executors list.
        /// </summary>
        public List<User> Executors { get; set; } = new List<User>();


        /// <summary>
        /// Task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Task status.
        /// 0 - opened.
        /// 1 - work in progress.
        /// 2 - finished.
        /// </summary>
        public string TaskStatus
        {
            get
            {
                switch (status)
                {
                    case 0:
                        return "Открытая задача";
                    case 1:
                        return "Задача в работе";
                    default:
                        return "Завершённая задача";
                }
            }
        }

        /// <summary>
        /// Executors count limit.
        /// </summary>
        public int ExecutorsLimit { get; set; } = 1;

        /// <summary>
        /// Creation time.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Task status.
        /// </summary>
        public byte status = 0;

        public Task() { }

        /// <param name="type"> Task type. </param>
        /// <param name="name"> Task name. </param>
        public Task(byte status, string name)
        {
            Date = DateTime.Now;
            Name = name;
            this.status = status;
        }

        /// <summary>
        /// Adds executor.
        /// </summary>
        /// <param name="e"></param>
        public void AddExecutor(User e)
        {
            if (Executors.Count < ExecutorsLimit)
            {
                Executors.Add(e);
            }
            else
            {
                throw new Exception($"Нельзя добавить больше {ExecutorsLimit} исполнителей");
            }
        }

        /// <summary>
        /// Removes executor.
        /// </summary>
        /// <param name="e"></param>
        public void RemoveExecutor(User e)
        {
            Executors.Remove(e);
        }

        public override string ToString() => Name;
    }
}
