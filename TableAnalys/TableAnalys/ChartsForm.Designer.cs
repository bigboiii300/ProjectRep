
namespace TableAnalys
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfChart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFirstColumn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSecondColumn = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDeviation = new System.Windows.Forms.Label();
            this.labelDisp = new System.Windows.Forms.Label();
            this.labelMedian = new System.Windows.Forms.Label();
            this.labelAvarage = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(14, 231);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(1042, 458);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете тип графика:";
            // 
            // comboBoxTypeOfChart
            // 
            this.comboBoxTypeOfChart.FormattingEnabled = true;
            this.comboBoxTypeOfChart.Items.AddRange(new object[] {
            "Построение двумерных графиков зависимостей по числовым данным",
            "Построение гистограммы по частоте встречаемости данных",
            "Построение круговой диаграммы и аналис числового столбца "});
            this.comboBoxTypeOfChart.Location = new System.Drawing.Point(225, 20);
            this.comboBoxTypeOfChart.Name = "comboBoxTypeOfChart";
            this.comboBoxTypeOfChart.Size = new System.Drawing.Size(531, 28);
            this.comboBoxTypeOfChart.TabIndex = 2;
            this.comboBoxTypeOfChart.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfChart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберете номер столбца:";
            // 
            // comboBoxFirstColumn
            // 
            this.comboBoxFirstColumn.FormattingEnabled = true;
            this.comboBoxFirstColumn.Location = new System.Drawing.Point(225, 62);
            this.comboBoxFirstColumn.Name = "comboBoxFirstColumn";
            this.comboBoxFirstColumn.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFirstColumn.TabIndex = 4;
            this.comboBoxFirstColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirstColumn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(371, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберете номер второго столбца:";
            // 
            // comboBoxSecondColumn
            // 
            this.comboBoxSecondColumn.FormattingEnabled = true;
            this.comboBoxSecondColumn.Location = new System.Drawing.Point(649, 62);
            this.comboBoxSecondColumn.Name = "comboBoxSecondColumn";
            this.comboBoxSecondColumn.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSecondColumn.TabIndex = 6;
            this.comboBoxSecondColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondColumn_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSave.Location = new System.Drawing.Point(821, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(207, 42);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelDeviation);
            this.panel1.Controls.Add(this.labelDisp);
            this.panel1.Controls.Add(this.labelMedian);
            this.panel1.Controls.Add(this.labelAvarage);
            this.panel1.Location = new System.Drawing.Point(26, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 104);
            this.panel1.TabIndex = 8;
            // 
            // labelDeviation
            // 
            this.labelDeviation.AutoSize = true;
            this.labelDeviation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDeviation.Location = new System.Drawing.Point(545, 57);
            this.labelDeviation.Name = "labelDeviation";
            this.labelDeviation.Size = new System.Drawing.Size(274, 20);
            this.labelDeviation.TabIndex = 3;
            this.labelDeviation.Text = "Среднеквадратичное отклонение:";
            // 
            // labelDisp
            // 
            this.labelDisp.AutoSize = true;
            this.labelDisp.Location = new System.Drawing.Point(545, 18);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(95, 20);
            this.labelDisp.TabIndex = 2;
            this.labelDisp.Text = "Дисперсия:";
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Location = new System.Drawing.Point(15, 57);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(82, 20);
            this.labelMedian.TabIndex = 1;
            this.labelMedian.Text = "Медиана:";
            // 
            // labelAvarage
            // 
            this.labelAvarage.AutoSize = true;
            this.labelAvarage.Location = new System.Drawing.Point(15, 18);
            this.labelAvarage.Name = "labelAvarage";
            this.labelAvarage.Size = new System.Drawing.Size(159, 20);
            this.labelAvarage.TabIndex = 0;
            this.labelAvarage.Text = "Среднее значение: ";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1069, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxSecondColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFirstColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypeOfChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeOfChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFirstColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSecondColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDeviation;
        private System.Windows.Forms.Label labelDisp;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.Label labelAvarage;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}