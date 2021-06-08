
namespace FormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskTypeTextBox = new System.Windows.Forms.RichTextBox();
            this.taskTypeLabel = new System.Windows.Forms.Label();
            this.openProjectButton = new System.Windows.Forms.Button();
            this.executorsListBox = new System.Windows.Forms.ListBox();
            this.editUserButton = new System.Windows.Forms.Button();
            this.currentProjectLabel = new System.Windows.Forms.Label();
            this.currentProjectTextBox = new System.Windows.Forms.RichTextBox();
            this.taskStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.taskStatusLabel = new System.Windows.Forms.Label();
            this.taskCreationDateTextBox = new System.Windows.Forms.RichTextBox();
            this.taskCreationDateLabel = new System.Windows.Forms.Label();
            this.executorsLabel = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.sortTasksByStatusButton = new System.Windows.Forms.Button();
            this.deleteExecutorButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.assignExecutorButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.tasksTreeView = new System.Windows.Forms.TreeView();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskTypeTextBox);
            this.panel1.Controls.Add(this.taskTypeLabel);
            this.panel1.Controls.Add(this.openProjectButton);
            this.panel1.Controls.Add(this.executorsListBox);
            this.panel1.Controls.Add(this.editUserButton);
            this.panel1.Controls.Add(this.currentProjectLabel);
            this.panel1.Controls.Add(this.currentProjectTextBox);
            this.panel1.Controls.Add(this.taskStatusTextBox);
            this.panel1.Controls.Add(this.taskStatusLabel);
            this.panel1.Controls.Add(this.taskCreationDateTextBox);
            this.panel1.Controls.Add(this.taskCreationDateLabel);
            this.panel1.Controls.Add(this.executorsLabel);
            this.panel1.Controls.Add(this.deleteUserButton);
            this.panel1.Controls.Add(this.addUserButton);
            this.panel1.Controls.Add(this.deleteProjectButton);
            this.panel1.Controls.Add(this.editProjectButton);
            this.panel1.Controls.Add(this.addProjectButton);
            this.panel1.Controls.Add(this.sortTasksByStatusButton);
            this.panel1.Controls.Add(this.deleteExecutorButton);
            this.panel1.Controls.Add(this.deleteTaskButton);
            this.panel1.Controls.Add(this.assignExecutorButton);
            this.panel1.Controls.Add(this.editTaskButton);
            this.panel1.Controls.Add(this.addTaskButton);
            this.panel1.Controls.Add(this.tasksLabel);
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Controls.Add(this.projectsLabel);
            this.panel1.Controls.Add(this.usersListBox);
            this.panel1.Controls.Add(this.tasksTreeView);
            this.panel1.Controls.Add(this.projectsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 619);
            this.panel1.TabIndex = 0;
            // 
            // taskTypeTextBox
            // 
            this.taskTypeTextBox.Location = new System.Drawing.Point(12, 110);
            this.taskTypeTextBox.Name = "taskTypeTextBox";
            this.taskTypeTextBox.ReadOnly = true;
            this.taskTypeTextBox.Size = new System.Drawing.Size(162, 24);
            this.taskTypeTextBox.TabIndex = 30;
            this.taskTypeTextBox.Text = "";
            // 
            // taskTypeLabel
            // 
            this.taskTypeLabel.AutoSize = true;
            this.taskTypeLabel.Location = new System.Drawing.Point(9, 85);
            this.taskTypeLabel.Name = "taskTypeLabel";
            this.taskTypeLabel.Size = new System.Drawing.Size(79, 20);
            this.taskTypeLabel.TabIndex = 29;
            this.taskTypeLabel.Text = "Тип задачи:";
            this.taskTypeLabel.UseCompatibleTextRendering = true;
            // 
            // openProjectButton
            // 
            this.openProjectButton.BackgroundImage = global::FormsApp.Properties.Resources.OpenProjectIcon;
            this.openProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openProjectButton.Location = new System.Drawing.Point(873, 151);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(29, 29);
            this.openProjectButton.TabIndex = 28;
            this.openProjectButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.openProjectButton, "Выбрать текущий проект");
            this.openProjectButton.UseVisualStyleBackColor = true;
            this.openProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // executorsListBox
            // 
            this.executorsListBox.FormattingEnabled = true;
            this.executorsListBox.ItemHeight = 16;
            this.executorsListBox.Location = new System.Drawing.Point(12, 303);
            this.executorsListBox.Name = "executorsListBox";
            this.executorsListBox.Size = new System.Drawing.Size(162, 308);
            this.executorsListBox.TabIndex = 27;
            // 
            // editUserButton
            // 
            this.editUserButton.BackgroundImage = global::FormsApp.Properties.Resources.EditIcon;
            this.editUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editUserButton.Location = new System.Drawing.Point(876, 338);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(29, 29);
            this.editUserButton.TabIndex = 26;
            this.editUserButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.editUserButton, "Редактировать пользователя");
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // currentProjectLabel
            // 
            this.currentProjectLabel.Location = new System.Drawing.Point(9, 18);
            this.currentProjectLabel.Name = "currentProjectLabel";
            this.currentProjectLabel.Size = new System.Drawing.Size(165, 23);
            this.currentProjectLabel.TabIndex = 25;
            this.currentProjectLabel.Text = "Текущий проект:";
            this.currentProjectLabel.UseCompatibleTextRendering = true;
            // 
            // currentProjectTextBox
            // 
            this.currentProjectTextBox.Location = new System.Drawing.Point(12, 51);
            this.currentProjectTextBox.Name = "currentProjectTextBox";
            this.currentProjectTextBox.ReadOnly = true;
            this.currentProjectTextBox.Size = new System.Drawing.Size(162, 24);
            this.currentProjectTextBox.TabIndex = 24;
            this.currentProjectTextBox.Text = "";
            // 
            // taskStatusTextBox
            // 
            this.taskStatusTextBox.Location = new System.Drawing.Point(12, 175);
            this.taskStatusTextBox.Name = "taskStatusTextBox";
            this.taskStatusTextBox.ReadOnly = true;
            this.taskStatusTextBox.Size = new System.Drawing.Size(162, 24);
            this.taskStatusTextBox.TabIndex = 23;
            this.taskStatusTextBox.Text = "";
            // 
            // taskStatusLabel
            // 
            this.taskStatusLabel.Location = new System.Drawing.Point(9, 147);
            this.taskStatusLabel.Name = "taskStatusLabel";
            this.taskStatusLabel.Size = new System.Drawing.Size(162, 23);
            this.taskStatusLabel.TabIndex = 22;
            this.taskStatusLabel.Text = "Статус задачи:";
            this.taskStatusLabel.UseCompatibleTextRendering = true;
            // 
            // taskCreationDateTextBox
            // 
            this.taskCreationDateTextBox.Location = new System.Drawing.Point(12, 238);
            this.taskCreationDateTextBox.Multiline = false;
            this.taskCreationDateTextBox.Name = "taskCreationDateTextBox";
            this.taskCreationDateTextBox.ReadOnly = true;
            this.taskCreationDateTextBox.Size = new System.Drawing.Size(162, 24);
            this.taskCreationDateTextBox.TabIndex = 21;
            this.taskCreationDateTextBox.Text = "";
            // 
            // taskCreationDateLabel
            // 
            this.taskCreationDateLabel.Location = new System.Drawing.Point(9, 210);
            this.taskCreationDateLabel.Name = "taskCreationDateLabel";
            this.taskCreationDateLabel.Size = new System.Drawing.Size(159, 23);
            this.taskCreationDateLabel.TabIndex = 20;
            this.taskCreationDateLabel.Text = "Дата создания:";
            this.taskCreationDateLabel.UseCompatibleTextRendering = true;
            // 
            // executorsLabel
            // 
            this.executorsLabel.Location = new System.Drawing.Point(12, 277);
            this.executorsLabel.Name = "executorsLabel";
            this.executorsLabel.Size = new System.Drawing.Size(100, 23);
            this.executorsLabel.TabIndex = 19;
            this.executorsLabel.Text = "Исполнители:";
            this.executorsLabel.UseCompatibleTextRendering = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackgroundImage = global::FormsApp.Properties.Resources.DeleteIcon;
            this.deleteUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserButton.ForeColor = System.Drawing.Color.Red;
            this.deleteUserButton.Location = new System.Drawing.Point(876, 373);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(29, 29);
            this.deleteUserButton.TabIndex = 17;
            this.deleteUserButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.deleteUserButton, "Удалить пользователя");
            this.deleteUserButton.UseCompatibleTextRendering = true;
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackgroundImage = global::FormsApp.Properties.Resources.AddIcon;
            this.addUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addUserButton.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.ForeColor = System.Drawing.Color.Green;
            this.addUserButton.Location = new System.Drawing.Point(876, 303);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(29, 29);
            this.addUserButton.TabIndex = 16;
            this.addUserButton.TabStop = false;
            this.addUserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonsToolTip.SetToolTip(this.addUserButton, "Добавить пользователя");
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.BackgroundImage = global::FormsApp.Properties.Resources.DeleteIcon;
            this.deleteProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteProjectButton.Location = new System.Drawing.Point(873, 116);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(29, 29);
            this.deleteProjectButton.TabIndex = 15;
            this.deleteProjectButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.deleteProjectButton, "Удалить проект");
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // editProjectButton
            // 
            this.editProjectButton.BackgroundImage = global::FormsApp.Properties.Resources.EditIcon;
            this.editProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editProjectButton.Location = new System.Drawing.Point(873, 81);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(29, 29);
            this.editProjectButton.TabIndex = 14;
            this.editProjectButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.editProjectButton, "Редактировать проект");
            this.editProjectButton.UseVisualStyleBackColor = true;
            this.editProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // addProjectButton
            // 
            this.addProjectButton.BackgroundImage = global::FormsApp.Properties.Resources.AddIcon;
            this.addProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addProjectButton.Location = new System.Drawing.Point(873, 46);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(29, 29);
            this.addProjectButton.TabIndex = 13;
            this.addProjectButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.addProjectButton, "Добавить проект");
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // sortTasksByStatusButton
            // 
            this.sortTasksByStatusButton.BackgroundImage = global::FormsApp.Properties.Resources.SortIcon;
            this.sortTasksByStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sortTasksByStatusButton.Location = new System.Drawing.Point(614, 12);
            this.sortTasksByStatusButton.Name = "sortTasksByStatusButton";
            this.sortTasksByStatusButton.Size = new System.Drawing.Size(29, 29);
            this.sortTasksByStatusButton.TabIndex = 11;
            this.sortTasksByStatusButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.sortTasksByStatusButton, "Группировать задачи по статусу");
            this.sortTasksByStatusButton.UseVisualStyleBackColor = true;
            this.sortTasksByStatusButton.Click += new System.EventHandler(this.SortTasksByStatusButton_Click);
            // 
            // deleteExecutorButton
            // 
            this.deleteExecutorButton.BackgroundImage = global::FormsApp.Properties.Resources.DeleteIcon;
            this.deleteExecutorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteExecutorButton.Location = new System.Drawing.Point(145, 271);
            this.deleteExecutorButton.Name = "deleteExecutorButton";
            this.deleteExecutorButton.Size = new System.Drawing.Size(29, 29);
            this.deleteExecutorButton.TabIndex = 10;
            this.deleteExecutorButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.deleteExecutorButton, "Удалить исполнителя");
            this.deleteExecutorButton.UseVisualStyleBackColor = true;
            this.deleteExecutorButton.Click += new System.EventHandler(this.DeleteExecutorButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackgroundImage = global::FormsApp.Properties.Resources.DeleteIcon;
            this.deleteTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteTaskButton.Location = new System.Drawing.Point(544, 12);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(29, 29);
            this.deleteTaskButton.TabIndex = 9;
            this.deleteTaskButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.deleteTaskButton, "Удалить задачу");
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // assignExecutorButton
            // 
            this.assignExecutorButton.BackgroundImage = global::FormsApp.Properties.Resources.ExecutorIcon;
            this.assignExecutorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.assignExecutorButton.Location = new System.Drawing.Point(579, 12);
            this.assignExecutorButton.Name = "assignExecutorButton";
            this.assignExecutorButton.Size = new System.Drawing.Size(29, 29);
            this.assignExecutorButton.TabIndex = 8;
            this.assignExecutorButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.assignExecutorButton, "Назначить исполнителя");
            this.assignExecutorButton.UseVisualStyleBackColor = true;
            this.assignExecutorButton.Click += new System.EventHandler(this.AssignExecutorButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.BackgroundImage = global::FormsApp.Properties.Resources.EditIcon;
            this.editTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editTaskButton.Location = new System.Drawing.Point(509, 12);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(29, 29);
            this.editTaskButton.TabIndex = 7;
            this.editTaskButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.editTaskButton, "Редактировать задачу");
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackgroundImage = global::FormsApp.Properties.Resources.AddIcon;
            this.addTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addTaskButton.Location = new System.Drawing.Point(474, 12);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(29, 29);
            this.addTaskButton.TabIndex = 6;
            this.addTaskButton.TabStop = false;
            this.ButtonsToolTip.SetToolTip(this.addTaskButton, "Добавить задачу");
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // tasksLabel
            // 
            this.tasksLabel.Location = new System.Drawing.Point(180, 18);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(73, 23);
            this.tasksLabel.TabIndex = 5;
            this.tasksLabel.Text = "Задачи:";
            this.tasksLabel.UseCompatibleTextRendering = true;
            // 
            // usersLabel
            // 
            this.usersLabel.Location = new System.Drawing.Point(655, 277);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(110, 23);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.Text = "Пользователи:";
            this.usersLabel.UseCompatibleTextRendering = true;
            // 
            // projectsLabel
            // 
            this.projectsLabel.Location = new System.Drawing.Point(655, 18);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(100, 23);
            this.projectsLabel.TabIndex = 3;
            this.projectsLabel.Text = "Проекты:";
            this.projectsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsLabel.UseCompatibleTextRendering = true;
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 16;
            this.usersListBox.Location = new System.Drawing.Point(658, 303);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(212, 308);
            this.usersListBox.TabIndex = 2;
            // 
            // tasksTreeView
            // 
            this.tasksTreeView.Location = new System.Drawing.Point(180, 47);
            this.tasksTreeView.Name = "tasksTreeView";
            this.tasksTreeView.Size = new System.Drawing.Size(469, 555);
            this.tasksTreeView.TabIndex = 1;
            this.tasksTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TasksTreeView_AfterSelect);
            this.tasksTreeView.Click += new System.EventHandler(this.TasksTreeView_Click);
            this.tasksTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasksTreeView_MouseDown);
            // 
            // projectsListBox
            // 
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 16;
            this.projectsListBox.Location = new System.Drawing.Point(655, 47);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(212, 212);
            this.projectsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(913, 619);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(931, 666);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(931, 666);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.TreeView tasksTreeView;
        private System.Windows.Forms.ListBox projectsListBox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Button sortTasksByStatusButton;
        private System.Windows.Forms.Button deleteExecutorButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button assignExecutorButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.RichTextBox taskStatusTextBox;
        private System.Windows.Forms.Label taskStatusLabel;
        private System.Windows.Forms.RichTextBox taskCreationDateTextBox;
        private System.Windows.Forms.Label taskCreationDateLabel;
        private System.Windows.Forms.Label executorsLabel;
        private System.Windows.Forms.Label currentProjectLabel;
        private System.Windows.Forms.RichTextBox currentProjectTextBox;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.ListBox executorsListBox;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.RichTextBox taskTypeTextBox;
        private System.Windows.Forms.Label taskTypeLabel;
        private System.Windows.Forms.ToolTip ButtonsToolTip;
    }
}

