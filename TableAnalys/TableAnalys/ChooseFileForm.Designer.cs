
namespace TableAnalys
{
    partial class ChooseFileForm
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
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxYes = new System.Windows.Forms.CheckBox();
            this.checkBoxNo = new System.Windows.Forms.CheckBox();
            this.checkBoxComma = new System.Windows.Forms.CheckBox();
            this.checkBoxSemiColon = new System.Windows.Forms.CheckBox();
            this.checkBoxPoint = new System.Windows.Forms.CheckBox();
            this.checkBoxColon = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.BackColor = System.Drawing.SystemColors.Info;
            this.buttonChooseFile.Location = new System.Drawing.Point(186, 42);
            this.buttonChooseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(101, 33);
            this.buttonChooseFile.TabIndex = 0;
            this.buttonChooseFile.Text = "Выбрать";
            this.buttonChooseFile.UseVisualStyleBackColor = false;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOpenFile.Location = new System.Drawing.Point(34, 250);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(179, 32);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберете разделитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "В первой строке содержатся названия столбцов?";
            // 
            // checkBoxYes
            // 
            this.checkBoxYes.AutoSize = true;
            this.checkBoxYes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxYes.Location = new System.Drawing.Point(34, 202);
            this.checkBoxYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxYes.Name = "checkBoxYes";
            this.checkBoxYes.Size = new System.Drawing.Size(56, 24);
            this.checkBoxYes.TabIndex = 5;
            this.checkBoxYes.Text = "Да";
            this.checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            this.checkBoxNo.AutoSize = true;
            this.checkBoxNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxNo.Location = new System.Drawing.Point(111, 202);
            this.checkBoxNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNo.Name = "checkBoxNo";
            this.checkBoxNo.Size = new System.Drawing.Size(65, 24);
            this.checkBoxNo.TabIndex = 6;
            this.checkBoxNo.Text = "Нет";
            this.checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxComma
            // 
            this.checkBoxComma.AutoSize = true;
            this.checkBoxComma.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxComma.Location = new System.Drawing.Point(34, 124);
            this.checkBoxComma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxComma.Name = "checkBoxComma";
            this.checkBoxComma.Size = new System.Drawing.Size(130, 24);
            this.checkBoxComma.TabIndex = 7;
            this.checkBoxComma.Text = "Запятая (\",\")";
            this.checkBoxComma.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemiColon
            // 
            this.checkBoxSemiColon.AutoSize = true;
            this.checkBoxSemiColon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxSemiColon.Location = new System.Drawing.Point(170, 124);
            this.checkBoxSemiColon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSemiColon.Name = "checkBoxSemiColon";
            this.checkBoxSemiColon.Size = new System.Drawing.Size(187, 24);
            this.checkBoxSemiColon.TabIndex = 8;
            this.checkBoxSemiColon.Text = "Точка с запятой (\";\")";
            this.checkBoxSemiColon.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoint
            // 
            this.checkBoxPoint.AutoSize = true;
            this.checkBoxPoint.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxPoint.Location = new System.Drawing.Point(365, 124);
            this.checkBoxPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPoint.Name = "checkBoxPoint";
            this.checkBoxPoint.Size = new System.Drawing.Size(109, 24);
            this.checkBoxPoint.TabIndex = 9;
            this.checkBoxPoint.Text = "Точка (\".\")";
            this.checkBoxPoint.UseVisualStyleBackColor = true;
            // 
            // checkBoxColon
            // 
            this.checkBoxColon.AutoSize = true;
            this.checkBoxColon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBoxColon.Location = new System.Drawing.Point(490, 124);
            this.checkBoxColon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxColon.Name = "checkBoxColon";
            this.checkBoxColon.Size = new System.Drawing.Size(149, 24);
            this.checkBoxColon.TabIndex = 10;
            this.checkBoxColon.Text = "Двоеточие (\":\")";
            this.checkBoxColon.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ChooseFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(672, 318);
            this.Controls.Add(this.checkBoxColon);
            this.Controls.Add(this.checkBoxPoint);
            this.Controls.Add(this.checkBoxSemiColon);
            this.Controls.Add(this.checkBoxComma);
            this.Controls.Add(this.checkBoxNo);
            this.Controls.Add(this.checkBoxYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonChooseFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(694, 374);
            this.MinimumSize = new System.Drawing.Size(694, 374);
            this.Name = "ChooseFileForm";
            this.Text = "Выбор таблицы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxYes;
        private System.Windows.Forms.CheckBox checkBoxNo;
        private System.Windows.Forms.CheckBox checkBoxComma;
        private System.Windows.Forms.CheckBox checkBoxSemiColon;
        private System.Windows.Forms.CheckBox checkBoxPoint;
        private System.Windows.Forms.CheckBox checkBoxColon;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}