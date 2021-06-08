
namespace FormsApp
{
    partial class TaskCreationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskTypePanel = new System.Windows.Forms.Panel();
            this.bugTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.taskTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.storyTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.epicTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.taskTypeLabel = new System.Windows.Forms.Label();
            this.taskFinishedRadioButton = new System.Windows.Forms.RadioButton();
            this.workInProgressRadioButton = new System.Windows.Forms.RadioButton();
            this.taskOpenedRadioButton = new System.Windows.Forms.RadioButton();
            this.taskConditionLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.taskTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskTypePanel);
            this.panel1.Controls.Add(this.taskFinishedRadioButton);
            this.panel1.Controls.Add(this.workInProgressRadioButton);
            this.panel1.Controls.Add(this.taskOpenedRadioButton);
            this.panel1.Controls.Add(this.taskConditionLabel);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.taskNameTextBox);
            this.panel1.Controls.Add(this.taskNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 209);
            this.panel1.TabIndex = 0;
            // 
            // taskTypePanel
            // 
            this.taskTypePanel.Controls.Add(this.bugTaskRadioButton);
            this.taskTypePanel.Controls.Add(this.taskTaskRadioButton);
            this.taskTypePanel.Controls.Add(this.storyTaskRadioButton);
            this.taskTypePanel.Controls.Add(this.epicTaskRadioButton);
            this.taskTypePanel.Controls.Add(this.taskTypeLabel);
            this.taskTypePanel.Location = new System.Drawing.Point(371, 45);
            this.taskTypePanel.Name = "taskTypePanel";
            this.taskTypePanel.Size = new System.Drawing.Size(310, 114);
            this.taskTypePanel.TabIndex = 9;
            // 
            // bugTaskRadioButton
            // 
            this.bugTaskRadioButton.AutoSize = true;
            this.bugTaskRadioButton.Location = new System.Drawing.Point(104, 81);
            this.bugTaskRadioButton.Name = "bugTaskRadioButton";
            this.bugTaskRadioButton.Size = new System.Drawing.Size(50, 21);
            this.bugTaskRadioButton.TabIndex = 4;
            this.bugTaskRadioButton.TabStop = true;
            this.bugTaskRadioButton.Text = "Bug";
            this.bugTaskRadioButton.UseCompatibleTextRendering = true;
            this.bugTaskRadioButton.UseVisualStyleBackColor = true;
            this.bugTaskRadioButton.Click += new System.EventHandler(this.BugTaskRadioButton_Click);
            // 
            // taskTaskRadioButton
            // 
            this.taskTaskRadioButton.AutoSize = true;
            this.taskTaskRadioButton.Location = new System.Drawing.Point(104, 54);
            this.taskTaskRadioButton.Name = "taskTaskRadioButton";
            this.taskTaskRadioButton.Size = new System.Drawing.Size(55, 21);
            this.taskTaskRadioButton.TabIndex = 3;
            this.taskTaskRadioButton.TabStop = true;
            this.taskTaskRadioButton.Text = "Task";
            this.taskTaskRadioButton.UseCompatibleTextRendering = true;
            this.taskTaskRadioButton.UseVisualStyleBackColor = true;
            this.taskTaskRadioButton.Click += new System.EventHandler(this.TaskTaskRadioButton_Click);
            // 
            // storyTaskRadioButton
            // 
            this.storyTaskRadioButton.AutoSize = true;
            this.storyTaskRadioButton.Location = new System.Drawing.Point(104, 27);
            this.storyTaskRadioButton.Name = "storyTaskRadioButton";
            this.storyTaskRadioButton.Size = new System.Drawing.Size(57, 21);
            this.storyTaskRadioButton.TabIndex = 2;
            this.storyTaskRadioButton.TabStop = true;
            this.storyTaskRadioButton.Text = "Story";
            this.storyTaskRadioButton.UseCompatibleTextRendering = true;
            this.storyTaskRadioButton.UseVisualStyleBackColor = true;
            this.storyTaskRadioButton.Click += new System.EventHandler(this.StoryTaskRadioButton_Click);
            // 
            // epicTaskRadioButton
            // 
            this.epicTaskRadioButton.AutoSize = true;
            this.epicTaskRadioButton.Location = new System.Drawing.Point(104, 0);
            this.epicTaskRadioButton.Name = "epicTaskRadioButton";
            this.epicTaskRadioButton.Size = new System.Drawing.Size(52, 21);
            this.epicTaskRadioButton.TabIndex = 1;
            this.epicTaskRadioButton.Text = "Epic";
            this.epicTaskRadioButton.UseCompatibleTextRendering = true;
            this.epicTaskRadioButton.UseVisualStyleBackColor = true;
            this.epicTaskRadioButton.Click += new System.EventHandler(this.EpicTaskRadioButton_Click);
            // 
            // taskTypeLabel
            // 
            this.taskTypeLabel.Location = new System.Drawing.Point(13, 0);
            this.taskTypeLabel.Name = "taskTypeLabel";
            this.taskTypeLabel.Size = new System.Drawing.Size(100, 23);
            this.taskTypeLabel.TabIndex = 0;
            this.taskTypeLabel.Text = "Тип задачи:";
            // 
            // taskFinishedRadioButton
            // 
            this.taskFinishedRadioButton.AutoSize = true;
            this.taskFinishedRadioButton.Location = new System.Drawing.Point(153, 99);
            this.taskFinishedRadioButton.Name = "taskFinishedRadioButton";
            this.taskFinishedRadioButton.Size = new System.Drawing.Size(171, 21);
            this.taskFinishedRadioButton.TabIndex = 8;
            this.taskFinishedRadioButton.Text = "Завершенная задача";
            this.taskFinishedRadioButton.UseVisualStyleBackColor = true;
            this.taskFinishedRadioButton.Click += new System.EventHandler(this.TaskFinishedRadioButton_Click);
            // 
            // workInProgressRadioButton
            // 
            this.workInProgressRadioButton.AutoSize = true;
            this.workInProgressRadioButton.Location = new System.Drawing.Point(153, 72);
            this.workInProgressRadioButton.Name = "workInProgressRadioButton";
            this.workInProgressRadioButton.Size = new System.Drawing.Size(140, 21);
            this.workInProgressRadioButton.TabIndex = 7;
            this.workInProgressRadioButton.Text = "Задача в работе";
            this.workInProgressRadioButton.UseVisualStyleBackColor = true;
            this.workInProgressRadioButton.Click += new System.EventHandler(this.WorkInProgressRadioButton_Click);
            // 
            // taskOpenedRadioButton
            // 
            this.taskOpenedRadioButton.AutoSize = true;
            this.taskOpenedRadioButton.Location = new System.Drawing.Point(153, 45);
            this.taskOpenedRadioButton.Name = "taskOpenedRadioButton";
            this.taskOpenedRadioButton.Size = new System.Drawing.Size(146, 21);
            this.taskOpenedRadioButton.TabIndex = 6;
            this.taskOpenedRadioButton.Text = "Открытая задача";
            this.taskOpenedRadioButton.UseVisualStyleBackColor = true;
            this.taskOpenedRadioButton.Click += new System.EventHandler(this.TaskOpenedRadioButton_Click);
            // 
            // taskConditionLabel
            // 
            this.taskConditionLabel.AutoSize = true;
            this.taskConditionLabel.Location = new System.Drawing.Point(13, 43);
            this.taskConditionLabel.Name = "taskConditionLabel";
            this.taskConditionLabel.Size = new System.Drawing.Size(134, 17);
            this.taskConditionLabel.TabIndex = 5;
            this.taskConditionLabel.Text = "Состояние задачи:";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(518, 174);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(82, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.TabStop = false;
            this.applyButton.Text = "Создать";
            this.applyButton.UseCompatibleTextRendering = true;
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(606, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseCompatibleTextRendering = true;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(152, 13);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(529, 22);
            this.taskNameTextBox.TabIndex = 1;
            this.taskNameTextBox.TabStop = false;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(13, 13);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(127, 17);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Название задачи:";
            // 
            // TaskCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(693, 209);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskCreationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.taskTypePanel.ResumeLayout(false);
            this.taskTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label taskConditionLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.RadioButton taskFinishedRadioButton;
        private System.Windows.Forms.RadioButton workInProgressRadioButton;
        private System.Windows.Forms.RadioButton taskOpenedRadioButton;
        private System.Windows.Forms.Panel taskTypePanel;
        private System.Windows.Forms.RadioButton bugTaskRadioButton;
        private System.Windows.Forms.RadioButton taskTaskRadioButton;
        private System.Windows.Forms.RadioButton storyTaskRadioButton;
        private System.Windows.Forms.RadioButton epicTaskRadioButton;
        private System.Windows.Forms.Label taskTypeLabel;
    }
}