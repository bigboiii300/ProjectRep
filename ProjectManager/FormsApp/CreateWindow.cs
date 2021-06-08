using System;
using System.Linq;
using System.Windows.Forms;

namespace FormsApp
{
    /// <summary>
    /// Window to create and edit entities.
    /// </summary>
    public partial class CreateWindow : Form
    {
        // Window headings.
        private readonly string[] headings = new string[] { "Создать пользователя",
            "Создать проект", "Изменить имя пользователя", "Изменить название проекта" };

        /// <summary>
        /// Apply changes after closing creating window.
        /// </summary>
        private readonly SynchronizeData doBeforeClosing;

        /// <summary>
        /// 0 - create user, 1 - create project.
        /// </summary>
        private readonly byte windowType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowType"> Entity type. </param>
        /// <param name="doBeforeClosing"> Apply changes after closing creating window. </param>
        /// <param name="startName"> Entity name if exists. </param>
        public CreateWindow(byte windowType, SynchronizeData doBeforeClosing, string startName = "")
        {
            InitializeComponent();
            nameTextBox.Focus();
            this.Text = headings[windowType];
            if (startName != "")
            {
                applyButton.Text = headings[2 | windowType];
            }
            nameTextBox.Text = startName;
            this.windowType = windowType;
            this.doBeforeClosing = doBeforeClosing;
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Tries to create/edit entity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                doBeforeClosing(windowType, nameTextBox.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Enables main form after closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            int count = doBeforeClosing.GetInvocationList().Count();
            doBeforeClosing.GetInvocationList()[count - 1].DynamicInvoke(windowType, nameTextBox.Text);
        }
    }
}
