using System;
using System.Linq;
using System.Windows.Forms;
using MyLibrary;

namespace FormsApp
{
    /// <summary>
    /// Window to create and edit tasks.
    /// </summary>
    public partial class TaskCreationForm : Form
    {
        // Window headings.
        private readonly string[] headings = new string[] { "Создать задачу",
            "Редактировать задачу", "Создать", "Изменить" };

        /// <summary>
        /// Apply changes after closing creating window.
        /// </summary>
        private readonly SynchronizeTaskCreation doBeforeClosing;

        /// <summary>
        /// TreeView with tasks.
        /// </summary>
        private readonly TreeView treeView;

        /// <summary>
        /// Old task name.
        /// </summary>
        private readonly string wasName;

        /// <summary>
        /// 0 - create user, 1 - create project.
        /// </summary>
        private readonly byte windowType;

        /// <summary>
        /// Task status.
        /// </summary>
        byte status = 0;

        /// <summary>
        /// Task type.
        /// </summary>
        int taskType = 1;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowType"> 0 - create task, 1 - edit task. </param>
        /// <param name="synchronizeTask"> Apply changes after closing creating window. </param>
        /// <param name="treeView"> TreeView with tasks. </param>
        /// <param name="name"> Old task name. </param>
        /// <param name="status"> Task status. </param>
        /// <param name="taskType"> Task type. </param>
        public TaskCreationForm(byte windowType, SynchronizeTaskCreation synchronizeTask,
            TreeView treeView, string name = "", byte status = 0, int taskType = 1)
        {
            InitializeComponent();
            if (windowType == 1)
            {
                taskTypePanel.Visible = false;
            }
            this.windowType = windowType;
            doBeforeClosing = synchronizeTask;
            wasName = name;
            taskNameTextBox.Text = name;
            Text = headings[windowType];
            this.treeView = treeView;
            applyButton.Text = headings[2 | windowType];
            this.status = status;
            this.taskType = taskType;
            SetTaskStatusRadioButton();
            SetTaskTypeRadioButton();
        }

        /// <summary>
        /// Sets default task status.
        /// </summary>
        private void SetTaskStatusRadioButton()
        {
            switch (status)
            {
                case 0:
                    taskOpenedRadioButton.Checked = true;
                    break;
                case 1:
                    workInProgressRadioButton.Checked = true;
                    break;
                case 2:
                    taskFinishedRadioButton.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Sets default task type.
        /// </summary>
        private void SetTaskTypeRadioButton()
        {
            switch (taskType)
            {
                case 0:
                    bugTaskRadioButton.Checked = true;
                    break;
                case 1:
                    epicTaskRadioButton.Checked = true;
                    break;
                case 2:
                    storyTaskRadioButton.Checked = true;
                    break;
                case 3:
                    taskTaskRadioButton.Checked = true;
                    break;

            }
        }

        /// <summary>
        /// Closes form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Creates entered task.
        /// </summary>
        /// <returns> Created task. </returns>
        private Task CreateTask()
        {
            switch (taskType)
            {
                case 0:
                    Bug bug = new Bug(status, taskNameTextBox.Text);
                    return bug;
                case 1:
                    Epic epic = new Epic(status, taskNameTextBox.Text);
                    return epic;
                case 2:
                    Story story = new Story(status, taskNameTextBox.Text);
                    return story;
                case 3:
                    Task task = new Task(status, taskNameTextBox.Text);
                    return task;
                default:
                    throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Tries to create/edit task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (windowType == 1)
                {
                    doBeforeClosing(taskNameTextBox.Text, new Node(wasName, 0, new Task(status, wasName)));
                    Close();
                    return;
                }

                Task task = CreateTask();
                Node node = new Node(taskNameTextBox.Text, taskType, task);

                if (treeView.SelectedNode == null)
                {
                    doBeforeClosing("", node);
                    treeView.Nodes.Add(taskNameTextBox.Text);
                }
                else
                {
                    doBeforeClosing(treeView.SelectedNode.Text, node);
                    treeView.SelectedNode.Nodes.Add(taskNameTextBox.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TaskOpenedRadioButton_Click(object sender, EventArgs e)
        {
            status = 0;
        }

        private void WorkInProgressRadioButton_Click(object sender, EventArgs e)
        {
            status = 1;
        }

        private void TaskFinishedRadioButton_Click(object sender, EventArgs e)
        {
            status = 2;
        }

        private void EpicTaskRadioButton_Click(object sender, EventArgs e)
        {
            taskType = 1;
        }

        private void StoryTaskRadioButton_Click(object sender, EventArgs e)
        {
            taskType = 2;
        }

        private void TaskTaskRadioButton_Click(object sender, EventArgs e)
        {
            taskType = 3;
        }

        private void BugTaskRadioButton_Click(object sender, EventArgs e)
        {
            taskType = 0;
        }

        /// <summary>
        /// Enables main form after closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int count = doBeforeClosing.GetInvocationList().Count();
            doBeforeClosing.GetInvocationList()[count - 1].DynamicInvoke(null, null);
        }
    }
}
