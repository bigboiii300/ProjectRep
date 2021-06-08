using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using MyLibrary;

namespace FormsApp
{
    /// <summary>
    /// Delegate to create entities(Users/Projects) in other forms.
    /// </summary>
    /// <param name="type"> Type of entity gettings created. </param>
    /// 0 - create user, 1- create project.
    /// <param name="name"> Name of entity getting created. </param>
    public delegate void SynchronizeData(byte type, string name);

    /// <summary>
    /// Delegaet to create tasks in other form.
    /// </summary>
    /// <param name="parent"> Name of parental node. </param>
    /// <param name="node"> Node created. </param>
    public delegate void SynchronizeTaskCreation(string parent, Node node);

    /// <summary>
    /// Main form class.
    /// </summary>
    public partial class MainForm : Form, IComparer
    {
        // Class to store projects data.
        Data data = new Data();

        /// <summary>
        /// Loads entity with saved data.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            data = Data.Load();
            LoadFormData();
        }

        /// <summary>
        /// Displays saved data on form.
        /// </summary>
        private void LoadFormData()
        {
            foreach (var e in data.users)
            {
                usersListBox.Items.Add(e);
            }

            foreach (var e in data.projects)
            {
                projectsListBox.Items.Add(e);
            }

            UpdateTask();
        }

        /// <summary>
        /// Loads saved tasks on form.
        /// </summary>
        private void UpdateTask()
        {
            if (data.currentProject != null)
            {
                foreach (var e in data.currentProject.root.children)
                {
                    var root = tasksTreeView.Nodes.Add(e.task.ToString());
                    AddChildren(root, e);
                }

                currentProjectTextBox.Text = data.currentProject.ToString();
                UpdateTaskBar();
            }
        }

        /// <summary>
        /// Recreates current task in treeView and recursively recreates from all children.
        /// </summary>
        /// <param name="root"> TreeView entity. </param>
        /// <param name="parent"> Current task node. </param>
        private void AddChildren(TreeNode root, Node parent)
        {
            foreach (var e in parent?.children)
            {
                var children = root.Nodes.Add(e.task.ToString());
                AddChildren(children, e);
            }
        }

        /// <summary>
        /// Checks if entered name is correct.
        /// </summary>
        /// <param name="windowType"> Type of entity. </param>
        /// <param name="name"> Name of entity. </param>
        private void IsNameCorrect(byte windowType, string name)
        {
            switch (windowType)
            {
                case 0:
                    if (data.users.Find(x => x.Name == name) != null
                        && (usersListBox?.SelectedItem?.ToString() != name || windowType == 0))
                    {
                        throw new Exception("Пользователь с таким именем уже существует");
                    }

                    if (name == "")
                    {
                        throw new Exception("Имя не должно быть пустым");
                    }

                    return;
                case 1:
                    if (data.projects.Find(x => x.Name == name) != null
                        && (projectsListBox?.SelectedItem?.ToString() != name || windowType == 0))
                    {
                        throw new Exception("Проект с таким названием уже существует");
                    }

                    if (name == "")
                    {
                        throw new Exception("Название не должно быть пустым");
                    }

                    return;
            }
        }

        /// <summary>
        /// Adds created entity.
        /// </summary>
        /// <param name="windowType"> Entity type. </param>
        /// <param name="name"> Entity name. </param>
        private void AddEntity(byte windowType, string name)
        {
            switch (windowType)
            {
                case 0:
                    data.users.Add(new User(name));
                    usersListBox.Items.Add(data.users.Last());
                    break;
                case 1:
                    data.projects.Add(new Project(name));
                    projectsListBox.Items.Add(data.projects.Last());
                    break;
            }
        }

        /// <summary>
        /// Changes entity name.
        /// </summary>
        /// <param name="windowType"> Entity type. </param>
        /// <param name="name"> Entity new name. </param>
        private void EditEntity(byte windowType, string name)
        {
            switch (windowType)
            {
                case 0:
                    data.users[usersListBox.SelectedIndex].Name = name;
                    usersListBox.Items[usersListBox.SelectedIndex] = name;
                    ClearTaskBar();
                    UpdateTaskBar();
                    break;
                case 1:
                    string wasName = data.projects[projectsListBox.SelectedIndex].Name;
                    data.projects[projectsListBox.SelectedIndex].Name = name;
                    projectsListBox.Items[projectsListBox.SelectedIndex] = name;
                    ClearTaskBar();
                    UpdateTaskBar();
                    if (currentProjectTextBox.Text == wasName)
                    {
                        currentProjectTextBox.Text = name;
                    }
                    break;
            }
        }

        /// <summary>
        /// Deletes user.
        /// </summary>
        /// <param name="user"> User to delete. </param>
        private void DeleteUser(User user)
        {
            foreach (var project in data.projects)
            {
                foreach (var task in project.nodes)
                {
                    if (task.Key == "")
                    {
                        continue;
                    }
                    task.Value.task.Executors.Remove(user);
                }
            }
        }

        /// <summary>
        /// Deletes entity.
        /// </summary>
        /// <param name="windowType"> Entity type. </param>
        private void DeleteEntity(byte windowType)
        {
            switch (windowType)
            {
                case 0:
                    User user = data.users[usersListBox.SelectedIndex];
                    DeleteUser(user);
                    data.users.RemoveAt(usersListBox.SelectedIndex);
                    usersListBox.Items.RemoveAt(usersListBox.SelectedIndex);
                    ClearTaskBar();
                    UpdateTaskBar();
                    break;
                case 1:
                    if (data.currentProject == data.projects[projectsListBox.SelectedIndex])
                    {
                        ClearProjectBar();
                        data.currentProject = null;
                    }
                    data.projects.RemoveAt(projectsListBox.SelectedIndex);
                    projectsListBox.Items.RemoveAt(projectsListBox.SelectedIndex);
                    break;
            }
        }

        /// <summary>
        /// Shows creating new user window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            // Before create user check if name is correct.
            SynchronizeData synchronizeData = new SynchronizeData(IsNameCorrect);
            synchronizeData += AddEntity;

            // Enable main form after closing creating window.
            synchronizeData += (byte type, string name) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            CreateWindow form = new CreateWindow(0, synchronizeData);
            form.Show();
        }

        /// <summary>
        /// Shows changing user name window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (usersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }

            // Before change name check if it is correct.
            SynchronizeData synchronizeData = new SynchronizeData(IsNameCorrect);
            synchronizeData += EditEntity;

            // Enable main form after closing creating window.
            synchronizeData += (byte type, string name) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            CreateWindow form = new CreateWindow(0, synchronizeData, data.users[usersListBox.SelectedIndex].Name);
            form.Show();
        }

        /// <summary>
        /// Deletes chosen user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }

            DeleteEntity(0);
        }

        /// <summary>
        /// Shows creating new project window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            if (data.projects.Count == 10)
            {
                MessageBox.Show("Нельзя создать больше 10 проектов");
                return;
            }

            // Before create project check if name is correct.
            SynchronizeData synchronizeData = new SynchronizeData(IsNameCorrect);
            synchronizeData += AddEntity;

            // Enable main form after closing creating window.
            synchronizeData += (byte type, string name) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            CreateWindow form = new CreateWindow(1, synchronizeData);
            form.Show();
        }

        /// <summary>
        /// Shows changing project name window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проект не выбран");
                return;
            }

            // Before change name check if it is correct.
            SynchronizeData synchronizeData = new SynchronizeData(IsNameCorrect);
            synchronizeData += EditEntity;

            // Enable main form after closing creating window.
            synchronizeData += (byte type, string name) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            CreateWindow form =
                new CreateWindow(1, synchronizeData, data.projects[projectsListBox.SelectedIndex].Name);
            form.Show();
        }

        /// <summary>
        /// Deletes chosen project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проект не выбран");
                return;
            }

            DeleteEntity(1);
        }

        /// <summary>
        /// Sets current project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проект не выбран");
                return;
            }
            //Display current project name.
            currentProjectTextBox.Text = projectsListBox.SelectedItem.ToString();
            data.currentProject = data.projects[projectsListBox.SelectedIndex];
            ClearProjectBar();
            UpdateTaskBar();
            UpdateTask();
        }

        // Unselecting treeview node while hitting space.
        private void TasksTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = tasksTreeView.HitTest(e.X, e.Y);
            if (hit.Node == null)
            {
                tasksTreeView.SelectedNode = null;
                ClearTaskBar();
            }
        }

        /// <summary>
        /// Clears all task bars.
        /// </summary>
        private void ClearTaskBar()
        {
            executorsListBox.Items.Clear();
            taskCreationDateTextBox.Clear();
            taskStatusTextBox.Clear();
            taskTypeTextBox.Clear();
        }

        /// <summary>
        /// Clears all project bars.
        /// </summary>
        private void ClearProjectBar()
        {
            ClearTaskBar();
            tasksTreeView.Nodes.Clear();
            currentProjectTextBox.Clear();
        }

        /// <summary>
        /// Checks if entered task name is correct.
        /// </summary>
        /// <param name="name"> Variable to fit into delegate. </param>
        /// <param name="node"> Created task. </param>
        private void CheckTask(string name, Node node)
        {
            if (data.currentProject.nodes.ContainsKey(node.Name))
            {
                throw new Exception("Задача с таким названием уже есть");
            }
        }

        /// <summary>
        /// Changes task name.
        /// </summary>
        /// <param name="name"> New name. </param>
        /// <param name="node"> Changing task. </param>
        private void EditNode(string name, Node node)
        {
            Node oldNode;
            data.currentProject.nodes.TryGetValue(node.Name, out oldNode);
            if (data.currentProject.nodes.ContainsKey(name) && name != node.Name)
            {
                throw new Exception("Задача с таким названием уже есть");
            }
            else
            {
                oldNode.Name = node.Name;
                oldNode.task.status = node.task.status;
                node.Name = name;
                tasksTreeView.SelectedNode.Text = name;
            }

        }

        /// <summary>
        /// Adds task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (data.currentProject == null)
            {
                MessageBox.Show("Проект не выбран");
                return;
            }

            // Tasks limit.
            if (data.currentProject.nodes.Count == 21)
            {
                MessageBox.Show("Нельзя добавить больше 20 задач");
                return;
            }

            // Before create task check if name is correct.
            SynchronizeTaskCreation synchronizeData = new SynchronizeTaskCreation(CheckTask);
            synchronizeData += data.currentProject.AddNode;

            // Enable main form after closing creating window.
            synchronizeData += (string a, Node node) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            TaskCreationForm taskCreationForm = new TaskCreationForm(0, synchronizeData, tasksTreeView);
            taskCreationForm.Show();
        }

        /// <summary>
        /// Updates task bars.
        /// </summary>
        private void UpdateTaskBar()
        {
            if (tasksTreeView.SelectedNode == null)
            {
                return;
            }
            string name = tasksTreeView.SelectedNode.Text;
            data.currentProject.nodes.TryGetValue(name, out Node node);
            taskStatusTextBox.Text = node.task.TaskStatus;
            taskCreationDateTextBox.Text = node.task.Date.ToString();
            foreach (var i in node.task.Executors)
            {
                executorsListBox.Items.Add(i.ToString());
            }
            switch (node.taskType)
            {
                case 0:
                    taskTypeTextBox.Text = "Bug";
                    break;
                case 1:
                    taskTypeTextBox.Text = "Epic";
                    break;
                case 2:
                    taskTypeTextBox.Text = "Story";
                    break;
                case 3:
                    taskTypeTextBox.Text = "Task";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates task bars.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearTaskBar();
            UpdateTaskBar();
        }

        /// <summary>
        /// Updates task bars.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksTreeView_Click(object sender, EventArgs e)
        {
            ClearTaskBar();
            UpdateTaskBar();
        }

        /// <summary>
        /// Shows changing task name window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksTreeView.SelectedNode == null)
            {
                MessageBox.Show("Задача не выбрана");
                return;
            }

            //  Before edit task check if name is correct.
            SynchronizeTaskCreation synchronizeData = new SynchronizeTaskCreation(EditNode);

            // Enable main form after closing creating window.
            synchronizeData += (string a, Node node1) => this.Enabled = true;

            // Disable main form while creating window opened.
            this.Enabled = false;

            data.currentProject.nodes.TryGetValue(tasksTreeView.SelectedNode.Text, out Node node);
            TaskCreationForm taskCreationForm =
                new TaskCreationForm(1, synchronizeData, tasksTreeView, node.Name, node.task.status, node.taskType);
            taskCreationForm.Show();
            ClearTaskBar();
        }

        /// <summary>
        /// Deletes chosen task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksTreeView.SelectedNode == null)
            {
                MessageBox.Show("Задача не выбрана");
                return;
            }

            string name = tasksTreeView.SelectedNode.Text;
            data.currentProject.nodes.TryGetValue(name, out Node node);
            data.currentProject.RemoveNode(node);
            tasksTreeView.SelectedNode.Remove();
            ClearTaskBar();
        }

        /// <summary>
        /// Assigns executor to chosen task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignExecutorButton_Click(object sender, EventArgs e)
        {
            if (tasksTreeView.SelectedNode == null)
            {
                MessageBox.Show("Задача не выбрана");
                return;
            }

            if (usersListBox.SelectedItem == null)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }
            var user = data.users.Find(x => x.Name == usersListBox.SelectedItem.ToString());
            data.currentProject.nodes.TryGetValue(tasksTreeView.SelectedNode.Text, out Node node);
            if (node.taskType == 1)
            {
                MessageBox.Show("Задачам типа epic нельзя назначать исполнителей");
                return;
            }
            try
            {
                if (node.task.Executors.Find(x => x.Name == user.Name) != null)
                {
                    throw new ArgumentException("Исполнитель с таким именем уже есть");
                }
                node.task.AddExecutor(user);
                executorsListBox.Items.Add(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Deletes chosen executor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteExecutorButton_Click(object sender, EventArgs e)
        {
            if (executorsListBox.SelectedItem == null)
            {
                MessageBox.Show("Исполнитель не выбран");
                return;
            }
            data.currentProject.nodes.TryGetValue(tasksTreeView.SelectedNode.Text, out Node node);
            node.task.Executors.Remove(data.users.Find(x => x.Name == executorsListBox.SelectedItem.ToString()));
            executorsListBox.Items.Remove(executorsListBox.SelectedItem);

        }

        /// <summary>
        /// Sorts tasks by status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortTasksByStatusButton_Click(object sender, EventArgs e)
        {
            tasksTreeView.TreeViewNodeSorter = this;
            tasksTreeView.Sort();
        }

        /// <summary>
        /// Compares two tasks.
        /// </summary>
        /// <param name="x"> First task. </param>
        /// <param name="y"> Second task. </param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            data.currentProject.nodes.TryGetValue(tx.Text, out Node nodeX);
            data.currentProject.nodes.TryGetValue(ty.Text, out Node nodeY);
            return nodeX.task.status.CompareTo(nodeY.task.status);
        }

        /// <summary>
        /// Saves data before closing main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.Save();
        }
    }
}
