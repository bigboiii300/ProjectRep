using System;
using System.Windows.Forms;

namespace TableAnalys
{
    public partial class ChooseFileForm : Form
    {
        /// <summary>
        /// Путь к открываемому файлу.
        /// </summary>
        string path = null;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ChooseFileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выбор файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    path = openFileDialog.FileName;
                else
                    path = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при открытии файла: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            // Разделитель.
            string separator;
            // Является ли первая строка заголовками.
            bool isTitles = false;
            if (checkBoxComma.Checked && !checkBoxSemiColon.Checked && !checkBoxColon.Checked && !checkBoxPoint.Checked)
                separator = ",";
            else if (checkBoxSemiColon.Checked && !checkBoxComma.Checked && !checkBoxColon.Checked && !checkBoxPoint.Checked)
                separator = ";";
            else if (checkBoxColon.Checked && !checkBoxComma.Checked && !checkBoxPoint.Checked && !checkBoxSemiColon.Checked)
                separator = ":";
            else if (checkBoxPoint.Checked && !checkBoxComma.Checked && !checkBoxColon.Checked && !checkBoxPoint.Checked)
                separator = ".";
            else
            {
                MessageBox.Show($"Можно выбрать только один разделитель!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Формат первой строки.
            if (checkBoxYes.Checked && !checkBoxNo.Checked)
                isTitles = true;
            else if (!checkBoxYes.Checked && checkBoxNo.Checked)
                isTitles = false;
            else
            {
                MessageBox.Show($"Укажите информацию о первой строке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Путь к файлу.
            if (path == null || path == "")
            {
                MessageBox.Show($"Выберете файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Создание таблицы.
            MainForm.Link.CreateDataTable(path, separator, isTitles);
            Close();
        }
    }
}
