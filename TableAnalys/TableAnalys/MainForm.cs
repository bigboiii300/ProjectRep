using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TableAnalys
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Ссылка на форму.
        /// </summary>
        public static MainForm Link { get; set; }

        /// <summary>
        /// Смена локали.
        /// </summary>
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");

        /// <summary>
        /// Количество строк.
        /// </summary>
        public int CountOfRows
        {
            get { return dataGridView.Rows.Count; }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Link = this;
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка количества открытых форм.
                foreach (Form forms in Application.OpenForms)
                {
                    if (forms.Name == "ChooseFileForm")
                    {
                        MessageBox.Show($"Данное окно уже открыто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (forms.Name == "ChartsForm")
                    {
                        MessageBox.Show($"Для открытия новой таблицы закройте все окна с анализом данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Создание формы для открытия файла.
                Form form = new ChooseFileForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие кнопки для анализа данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void analysDataButton_Click(object sender, EventArgs e)
        {
            // Количество открытых окон.
            int countOfOpenForms = 0;
            try
            {
                // Проверка корректности данных перед открытием.
                if (dataGridView.Columns.Count == 0)
                {
                    MessageBox.Show($"Таблица не загружена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataGridView.Rows.Count <= 2)
                {
                    MessageBox.Show($"Недостаточно строк для выполнения анализа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Подсчет количества открытых окон.
                foreach (Form forms in Application.OpenForms)
                {
                    if (forms.Name == "ChartsForm")
                        countOfOpenForms++;
                }
                if (countOfOpenForms == 5)
                {
                    MessageBox.Show($"Открыто максимальное количество окон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Создание нового окна для анализа данных.
                ChartsForm form = new ChartsForm();
                form.ColumsCount = dataGridView.ColumnCount;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Заполнение таблицы.
        /// </summary>
        /// <param name="fileName"> Имя файла. </param>
        /// <param name="separator"> Разделитель. </param>
        /// <param name="isTitles"> Является ли первая строка заголовками. </param>
        public void CreateDataTable(string fileName, string separator, bool isTitles)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (Microsoft.VisualBasic.FileIO.TextFieldParser tfp = new Microsoft.VisualBasic.FileIO.TextFieldParser(fileName))
                {
                    tfp.SetDelimiters(separator);
                    if (!tfp.EndOfData)
                    {
                        string[] fields = tfp.ReadFields();
                        // Установка названий столбцов.
                        for (int i = 0; i < fields.Count(); i++)
                        {
                            if (isTitles)
                                dataTable.Columns.Add(fields[i]);
                            else
                                dataTable.Columns.Add($"{i + 1}");
                        }
                        if (!isTitles)
                            dataTable.Rows.Add(fields);
                    }
                    // Считывание строк.
                    while (!tfp.EndOfData)
                    {
                        string[] fields = tfp.ReadFields();
                        for (int i = 0; i < fields.Length; i++)
                            if (fields[i] == null || fields[i] == "")
                                fields[i] = "NaN";
                        dataTable.Rows.Add(fields);
                    }
                }
                // Загрузка данных.
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Получение строк из выбранного столбца.
        /// </summary>
        /// <param name="numberOfTheColumn"> Выбранный столбец. </param>
        /// <returns> Массив строк. </returns>
        public string[] GetColumnInfo(int numberOfTheColumn)
        {
            try
            {
                string[] info = new string[dataGridView.RowCount - 1];
                for (int i = 0; i < info.Length; i++)
                    info[i] = dataGridView[numberOfTheColumn, i].Value.ToString();
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new string[] { "default1", "default2", "default3" };
        }

        /// <summary>
        /// Получение имени выбранного столбца.
        /// </summary>
        /// <param name="numberOfTheColumn"> Номер выбранного столбца. </param>
        /// <returns> Имя столбца. </returns>
        public string GetNameOfTheColumn(int numberOfTheColumn)
        {
            try
            {
                return dataGridView.Columns[numberOfTheColumn].Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "DefaultName";
        }
    }
}
