using System;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class NameOfNode : Form
    {
        public NameOfNode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подтверждение параметров </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ApplyNameNode_Click(object sender, EventArgs e)
        {
            // Проверка на ввод.
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(
                    "Вы ничего не ввели!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            this.Close();
        }

    }
}
