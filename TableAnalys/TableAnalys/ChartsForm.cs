using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TableAnalys
{
    public partial class ChartsForm : Form
    {
        /// <summary>
        /// Параметры CultureInfo.
        /// </summary>
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");

        /// <summary>
        /// Количество столбцов в таблице.
        /// </summary>
        public int ColumsCount { get; set; }

        /// <summary>
        /// Тип столбца.
        /// </summary>
        public bool IsTypeDouble { get; set; }

        /// <summary>
        /// Индекс выбранного столбца.
        /// </summary>
        public int IndexOfTheColumn { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ChartsForm()
        {
            InitializeComponent();
            IsTypeDouble = false;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            label2.Visible = false;
            label3.Visible = false;
            comboBoxFirstColumn.Visible = false;
            comboBoxSecondColumn.Visible = false;
            panel1.Visible = false;
            chart1.Series[0].IsValueShownAsLabel = true;
        }


        /// <summary>
        /// Установка значений для panel1.
        /// </summary>
        private void SetDefaultSettingsForPanel()
        {
            labelAvarage.Text = "Среднее значение по столбцу:";
            labelMedian.Text = "Медиана столбца:";
            labelDeviation.Text = "Среднеквадратичное отклонение:";
            labelDisp.Text = "Дисперсия:";
        }


        /// <summary>
        /// Установка значений по умолчанию.
        /// </summary>
        private void SetDefaultSettings()
        {
            comboBoxFirstColumn.SelectedItem = null;
            comboBoxSecondColumn.SelectedItem = null;
            label2.Visible = false;
            comboBoxFirstColumn.Visible = false;
            label3.Visible = false;
            comboBoxSecondColumn.Visible = false;
            panel1.Visible = false;
            IsTypeDouble = false;
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series[0].IsValueShownAsLabel = false;
        }


        /// <summary>
        /// Настройки для графика.
        /// </summary>
        /// <param name="columnsInfo"> Масив со столбцами. </param>
        private void GraphSettings(string[] columnsInfo)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            label2.Visible = true;
            comboBoxFirstColumn.Visible = true;
            label3.Visible = true;
            comboBoxSecondColumn.Visible = true;
            if (comboBoxSecondColumn.Items.Count == 0)
                comboBoxSecondColumn.Items.AddRange(columnsInfo);
        }

        /// <summary>
        /// Настройки для столбчатой диаграммы.
        /// </summary>
        private void BarChartSettings()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            label2.Visible = true;
            label3.Visible = false;
            comboBoxFirstColumn.Visible = true;
        }

        /// <summary>
        /// Настройки для круговой диаграммы.
        /// </summary>
        private void PieChartSettings()
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            label2.Visible = true;
            label3.Visible = false;
            comboBoxFirstColumn.Visible = true;
            panel1.Visible = true;
        }

        /// <summary>
        /// Круговая диаграма.
        /// </summary>
        /// <param name="numberOfTheColumn"> Номер столбца. </param>
        private void PieChart(int numberOfTheColumn)
        {
            // Получение данных из столбца.
            string[] info = MainForm.Link.GetColumnInfo(numberOfTheColumn);
            double[] arr = new double[info.Length];
            // Среднее значение.
            double avarage = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (info[i] == "NaN" || !double.TryParse(info[i], out arr[i]))
                {
                    MessageBox.Show($"Невозможно провести анализ по выбранному столбцу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                avarage += arr[i];
                // Добавление точки на график.
                chart1.Series[0].Points.AddY(arr[i]);
                chart1.Series[0].Points[i].LegendText = $"{i + 1}";
            }
            if (arr.Length <= 20)
                chart1.Series[0].IsValueShownAsLabel = true;
            avarage /= arr.Length;
            Array.Sort(arr);
            // Подсчет среднего значения, медианы, среднеквадратичного отклонения и дисперсии.
            labelAvarage.Text = labelAvarage.Text + $" {avarage:f9}";
            labelMedian.Text = labelMedian.Text + $" {(arr[(arr.Length + 1) / 2]):f9}";
            labelDeviation.Text = labelDeviation.Text + $" {StandardDeviation(arr, avarage):f9}";
            labelDisp.Text = labelDisp.Text + $" {Dispertion((double[])arr.Clone(), avarage):f9}";
        }

        /// <summary>
        /// Подсчет среднеквардратичного отклонения.
        /// </summary>
        /// <param name="arr"> Массив с данными столбца. </param>
        /// <param name="avarage"> Среднее значение по столбцу.</param>
        /// <returns>Значение отколнения.</returns>
        private double StandardDeviation(double[] arr, double avarage)
        {
            double ans = 0;
            for (int i = 0; i < arr.Length; i++)
                ans += Math.Pow((arr[i] - avarage), 2);
            ans /= arr.Length;
            return ans;
        }

        /// <summary>
        /// Подсчет дисперсии.
        /// </summary>
        /// <param name="arr"> Массив с данными столбца. </param>
        /// <param name="avarage"> Среднее значение по столбцу.</param>
        /// <returns> Значение дисперсии.</returns>
        private double Dispertion(double[] arr, double avarage)
        {
            double ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= avarage;
                ans += Math.Pow(arr[i], 2);
            }
            return ans;
        }

        /// <summary>
        /// Столбчатая диаграма.
        /// </summary>
        /// <param name="numberOfTheColumn"> Номер выбранного столбца.</param>
        private void BarChart(int numberOfTheColumn)
        {
            // Словарь с данными, встречающимися в столбце.
            Dictionary<string, double> data = new Dictionary<string, double>();
            bool flag = false;
            IndexOfTheColumn = numberOfTheColumn;
            string[] info = MainForm.Link.GetColumnInfo(numberOfTheColumn);
            double[] arr = new double[info.Length];
            try
            {
                for (int i = 0; i < info.Length; i++)
                {
                    if (!double.TryParse(info[i], out arr[i]))
                        flag = true;
                    if (!data.ContainsKey(info[i]))
                        data.Add(info[i], 1);
                    else
                        data[info[i]]++;
                }
                if (flag)
                    AddData(data);
                else
                    IsTypeDouble = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Добавление информации о числе повторений столбце.
        /// </summary>
        /// <param name="data"> Словарь с данными. </param>
        private void AddData(Dictionary<string, double> data)
        {
            IsTypeDouble = false;
            bool flag = false;
            if (data.Count < 21)
                flag = true;
            string[] columnsInfo = new string[data.Count];
            for (int i = 0; i < data.Count; i++)
                columnsInfo[i] = $"{i + 1} столбец";
            chart1.Series.Clear();
            int j = 0;
            foreach (KeyValuePair<string, double> key in data)
            {
                chart1.Series.Add(key.Key);
                if (flag)
                    chart1.Series[j].IsValueShownAsLabel = true;
                chart1.Series[j++].Points.Add(key.Value);
            }
        }

        /// <summary>
        /// Построение графика.
        /// </summary>
        /// <param name="numberOfTheFirstColumn"> Номер первого столбца.</param>
        /// <param name="numberOfTheSecondColumn">Номер второго столбца.</param>
        private void Graph(int numberOfTheFirstColumn, int numberOfTheSecondColumn)
        {
            // Получение данных о столбцах.
            string[] info1 = MainForm.Link.GetColumnInfo(numberOfTheFirstColumn);
            string[] info2 = MainForm.Link.GetColumnInfo(numberOfTheSecondColumn);
            double[] arr1 = new double[info1.Length];
            double[] arr2 = new double[info2.Length];
            chart1.Series[0].Points.Clear();
            chart1.Series[0].BorderWidth = 3;
            // Парсинг данных столбца.
            for (int i = 0; i < info1.Length; i++)
            {
                if (info1[i] == "NaN" || info2[i] == "NaN" || !double.TryParse(info1[i], out arr1[i]) || !double.TryParse(info2[i], out arr2[i]))
                {
                    MessageBox.Show($"Невозможно провести данный анализ по выбранному столбцу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (info1.Length <= 20)
                chart1.Series[0].IsVisibleInLegend = true;
            // Добавление точек.
            for (int i = 0; i < info1.Length; i++)
                chart1.Series[0].Points.AddXY(arr1[i], arr2[i]);
            // Добавление подписей.
            chart1.Series[0].Name = "Функция";
            chart1.ChartAreas[0].AxisX.Title = $"{MainForm.Link.GetNameOfTheColumn(numberOfTheFirstColumn)}";
            chart1.ChartAreas[0].AxisY.Title = $"{MainForm.Link.GetNameOfTheColumn(numberOfTheSecondColumn)}";
            // Изменение цвета для точек.
            foreach (var i in chart1.Series[0].Points)
            {
                i.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                i.MarkerBorderColor = Color.Black;
                i.MarkerColor = Color.Green;
                i.MarkerSize = 8;
            }
        }

        /// <summary>
        /// Выбор типа графика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTypeOfChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainForm.Link.CountOfRows <= 2)
            {
                MessageBox.Show($"Недостаточно строк для выполнения анализа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            // Установка значений по умолчанию.
            SetDefaultSettings();
            try
            {
                string[] info = new string[ColumsCount];
                for (int i = 0; i < ColumsCount; i++)
                    info[i] = $"{i + 1} столбец";
                switch (comboBoxTypeOfChart.SelectedIndex)
                {
                    case 0:
                        GraphSettings(info);
                        break;
                    case 1:
                        BarChartSettings();
                        break;
                    case 2:
                        PieChartSettings();
                        break;
                }

                if (comboBoxFirstColumn.Items.Count == 0)
                    comboBoxFirstColumn.Items.AddRange(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Выбор столбца для анализа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFirstColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка количества строк.
            if (MainForm.Link.CountOfRows <= 2)
            {
                MessageBox.Show($"Недостаточно строк для выполнения анализа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            IsTypeDouble = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].IsValueShownAsLabel = false;
            switch (comboBoxTypeOfChart.SelectedIndex)
            {
                case 0:
                    if (comboBoxSecondColumn.SelectedItem == null || comboBoxFirstColumn.SelectedItem == null)
                        return;
                    Graph(comboBoxFirstColumn.SelectedIndex, comboBoxSecondColumn.SelectedIndex);
                    break;
                case 1:
                    if (comboBoxFirstColumn.SelectedItem == null)
                        return;
                    BarChart(comboBoxFirstColumn.SelectedIndex);
                    break;
                case 2:
                    SetDefaultSettingsForPanel();
                    if (comboBoxFirstColumn.SelectedItem == null)
                        return;
                    PieChart(comboBoxFirstColumn.SelectedIndex);
                    break;
            }
        }

        /// <summary>
        /// Выбор второго столбца.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSecondColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка количества строк.
            if (MainForm.Link.CountOfRows <= 2)
            {
                MessageBox.Show($"Недостаточно строк для выполнения анализа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            if (comboBoxSecondColumn.SelectedItem == null || comboBoxFirstColumn.SelectedItem == null)
                return;
            IsTypeDouble = false;
            chart1.Series[0].IsValueShownAsLabel = false;
            Graph(comboBoxFirstColumn.SelectedIndex, comboBoxSecondColumn.SelectedIndex);
        }

        /// <summary>
        /// Сохранение графика.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Сохранить изображение как ...";
                    saveFileDialog.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = "ChartImage";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1: chart1.SaveImage(saveFileDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                            case 2: chart1.SaveImage(saveFileDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                            case 3: chart1.SaveImage(saveFileDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                        }
                        MessageBox.Show("Изображение успешно сохранено!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
