using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_
{
    
    public partial class Form1 : Form
    {
        // Счетчик вкладок.
        private int tabCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        // Создание нового файла.
        private void NewFile_Click(object sender, EventArgs e) => NewFileToolStripMenuItem_Click(sender, e);
        // Открытие файла.
        private void OpenFile_Click(object sender, EventArgs e) => OpenToolStripMenuItem_Click(sender,e);
        // Сохранение файла.
        private void SaveFile_Click(object sender, EventArgs e) => SaveToolStripMenuItem_Click(sender, e);
        // Отмена действия.
        private void CancelButton_Click(object sender, EventArgs e) => CancelToolStripMenuItem_Click(sender, e);
        // Возврат действия.
        private void ReturnButton_Click(object sender, EventArgs e) => ReturnToolStripMenuItem_Click(sender, e);

        /// <summary>
        /// Увеличение масштаба.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zoom_In_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на открытые вкладки.
                if (TabControl.TabPages.Count >= 1)
                {
                    var richTextBox = ControlTab();
                    // Максимальное значение масштаба.
                    if (richTextBox.ZoomFactor < 30)
                        richTextBox.ZoomFactor += 1;
                    else
                        MessageBox.Show("Значение масштаба слишком большое!");
                }
                else
                    MessageBox.Show("Нет открытых вкладок!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Уменьшение масштаба.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zoom_Out_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на открытые вкладки.
                if (TabControl.TabPages.Count >= 1)
                {
                    var richTextBox = ControlTab();
                    // Минимальное значение масштаба.
                    if (richTextBox.ZoomFactor > 2)
                        richTextBox.ZoomFactor -= 1;
                    else
                        MessageBox.Show("Значение масштаба слишком маленькое!");
                }
                else 
                    MessageBox.Show("Нет открытых вкладок!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Применение курсива.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItalicFont_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                    FontStyle.Italic ^ richTextBox.SelectionFont.Style);
            }
            else
                MessageBox.Show("Нет открытых вкладок!");
        }

        /// <summary>
        /// Жирный шрифт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldFont_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                    FontStyle.Bold ^ richTextBox.SelectionFont.Style);
            }
            else MessageBox.Show("Нет открытых вкладок!");
        }

        /// <summary>
        /// Подчеркнутый шрифт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrikeFont_Click(object sender, EventArgs e)
        {
            // Проверка на открытые вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                    FontStyle.Strikeout ^ richTextBox.SelectionFont.Style);
            }
            else MessageBox.Show("Нет открытых вкладок!");
        }

        /// <summary>
        /// Зачеркнутый шрифт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderlinedFont_Click(object sender, EventArgs e)
        {
            // Проверка на открытые вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                    FontStyle.Underline ^ richTextBox.SelectionFont.Style);
            }
            else MessageBox.Show("Нет открытых вкладок!");
        }

        /// <summary>
        /// Изменение заднего фона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                ColorDialog backGround = new ColorDialog();
                if (backGround.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.BackColor = backGround.Color;
                }
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Создание вкладок.
        /// </summary>
        /// <returns></returns>
        private RichTextBox ControlTab()
        {
            TabPage tabpage = this.TabControl.SelectedTab;
            RichTextBox richTextBox = null;
            foreach (var text in tabpage.Controls)
                switch (text)
                {
                    case RichTextBox box:
                        richTextBox = box;
                        break;
                }

            return richTextBox;
        }

        /// <summary>
        /// Открытие файла через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на вкладки.
                if (TabControl.TabPages.Count >= 1)
                {
                    var richTextBox = ControlTab();
                    openFileDialog1.Title = "Открыть файл";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader reader = new StreamReader(openFileDialog1.FileName);
                        if (this.openFileDialog1.FileName.Contains(".rtf"))
                            richTextBox.Text = reader.ReadToEnd();
                        else
                            richTextBox.Text = reader.ReadToEnd();
                        File.AppendAllText("DataHistory.txt",openFileDialog1.FileName + Environment.NewLine);
                        reader.Close();
                    }
                }
                else
                    MessageBox.Show("Нет открытых вкладок!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Копирование текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.Copy();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Выбрать все.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectAll();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Очистить текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Сохрание файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на вкладки.
                if (TabControl.TabPages.Count>= 1)
                {
                    var richTextBox = ControlTab();
                    saveFileDialog1.Filter = "Текстовый документ (.txt)|*.txt | RTF (*.rtf)|*.rtf";
                    openFileDialog1.Title = "Сохранить файл";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                        // Запись rtf-файла.
                        if (this.saveFileDialog1.FileName.Contains(".rtf"))
                            writer.WriteLine(richTextBox.Rtf);
                        else
                            writer.WriteLine(richTextBox.Text);
                        File.AppendAllText("DataHistory.txt", openFileDialog1.FileName + Environment.NewLine);
                        writer.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Нет открытых вкладок!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Печать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на вкладки.
                if (TabControl.TabPages.Count>=1)
                {
                    PrintDialog DialogPrint = new PrintDialog();
                    PrintDocument FilePrint = new PrintDocument { DocumentName = "Печать" };

                    DialogPrint.Document = FilePrint;
                    DialogPrint.AllowSelection = true;
                    DialogPrint.AllowSomePages = true;
                    if (DialogPrint.ShowDialog() != DialogResult.OK) return;
                    FilePrint.Print();
                }
                else
                {
                    MessageBox.Show("Нет открытых вкладок!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        /// <summary>
        /// Вставка текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                if (richTextBox.TextLength > 0)
                    richTextBox.Paste();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Вырезать текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                if (richTextBox.TextLength > 0)
                    richTextBox.Cut();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Отмена действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.Undo();
            }
            else
                MessageBox.Show("Нет открытых вкладок!");
        }

        /// <summary>
        /// Возврат действия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка на вкладки.
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.Redo();
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Выравнивание по левому краю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Выравнивание по правому краю.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
        }

        /// <summary>
        /// Выравнивание по центру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiddleAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }

        }

        /// <summary>
        /// Смена шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabControl.TabPages.Count >= 1)
                {
                    fontDialog1.ShowDialog();
                    richTextBox1.Font = fontDialog1.Font;
                }
                else
                    MessageBox.Show("Нет открытых вкладок!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Смена цвета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count>=1)
            {
                ColorDialog textColorDialog = new ColorDialog();
                if (textColorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.ForeColor = textColorDialog.Color;
                }
            }
            else
            {
                MessageBox.Show("Нет открытых вкладок!");
            }
           
        }

        /// <summary>
        /// Вырезать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripButton_Click(object sender, EventArgs e) => CutToolStripMenuItem_Click(sender,e);

        /// <summary>
        /// Выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click_1(object sender, EventArgs e) => ExitToolStripMenuItem_Click(sender,e);

        /// <summary>
        /// Розовая тема.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PinkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                this.menuStrip2.BackColor = Color.LightPink;
                this.menuStrip2.ForeColor = Color.DarkBlue;
                this.menuStrip2.BackColor = Color.Pink;
                this.menuStrip2.ForeColor = Color.DarkBlue;
                richTextBox.BackColor = Color.LightPink;
                richTextBox.ForeColor = Color.DarkBlue;
                this.toolStrip1.BackColor = Color.LightPink;
                this.toolStrip1.ForeColor = Color.DarkBlue;
                this.statusStrip1.BackColor = Color.LightPink;
                this.statusStrip1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.Pink;
            }
            else
            {
                this.menuStrip2.BackColor = Color.LightPink;
                this.menuStrip2.ForeColor = Color.DarkBlue;
                this.menuStrip2.BackColor = Color.Pink;
                this.menuStrip2.ForeColor = Color.DarkBlue;
                this.toolStrip1.BackColor = Color.LightPink;
                this.toolStrip1.ForeColor = Color.DarkBlue;
                this.statusStrip1.BackColor = Color.LightPink;
                this.statusStrip1.ForeColor = Color.DarkBlue;
                this.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Бежевая тема.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeigeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count>=1)
            {
                var richTextBox = ControlTab();
                this.menuStrip2.BackColor = Color.BlanchedAlmond;
                this.menuStrip2.ForeColor = Color.Black;
                richTextBox.BackColor = Color.Beige;
                richTextBox.ForeColor = Color.Black;
                this.toolStrip1.BackColor = Color.BlanchedAlmond;
                this.toolStrip1.ForeColor = Color.Black;
                this.BackColor = Color.BlanchedAlmond;
                this.statusStrip1.BackColor = Color.Beige;
                this.statusStrip1.ForeColor = Color.Black;
            }
            else
            {
                this.menuStrip2.BackColor = Color.BlanchedAlmond;
                this.menuStrip2.ForeColor = Color.Black;
                this.toolStrip1.BackColor = Color.BlanchedAlmond;
                this.toolStrip1.ForeColor = Color.Black;
                this.BackColor = Color.BlanchedAlmond;
                this.statusStrip1.BackColor = Color.Beige;
                this.statusStrip1.ForeColor = Color.Black;
            }
            
        }

        /// <summary>
        /// Российская тема.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RussianThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count>=1)
            {
                var richTextBox = ControlTab();
                this.menuStrip2.BackColor = Color.White;
                this.menuStrip2.ForeColor = Color.Black;
                richTextBox.BackColor = Color.Blue;
                richTextBox.ForeColor = Color.Yellow;
                this.toolStrip1.BackColor = Color.White;
                this.toolStrip1.ForeColor = Color.White;
                this.BackColor = Color.White;
                this.statusStrip1.BackColor = Color.Red;
                this.statusStrip1.ForeColor = Color.Black;
            }
            else
            {
                this.menuStrip2.BackColor = Color.White;
                this.menuStrip2.ForeColor = Color.Black;
                this.toolStrip1.BackColor = Color.White;
                this.toolStrip1.ForeColor = Color.White;
                this.BackColor = Color.White;
                this.statusStrip1.BackColor = Color.Red;
                this.statusStrip1.ForeColor = Color.Black;
            }
            
        }

        /// <summary>
        /// Подсчет символов и строк.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var richTextBox = ControlTab();
                string status = richTextBox?.Text;
                string[] lines = status.Split('\n');
                richTextBox.ContextMenuStrip = contextMenuStrip2;
                this.RowsStatus.Text = $"Rows: {lines.Length}";
                this.SymbolsStatus.Text = $"Symbols: {status.Length}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        /// <summary>
        /// Тема.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CyberpunkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.TabPages.Count>=1)
            {
                var richTextBox = ControlTab();
                this.menuStrip2.BackColor = Color.Orange;
                this.menuStrip2.ForeColor = Color.Black;
                this.BackColor = Color.Orange;
                richTextBox.BackColor = Color.Black;
                richTextBox.ForeColor = Color.Yellow;
                this.toolStrip1.BackColor = Color.Orange;
                this.toolStrip1.ForeColor = Color.Black;
                this.statusStrip1.BackColor = Color.Orange;
                this.statusStrip1.ForeColor = Color.Black;
            }
            else
            {
                this.menuStrip2.BackColor = Color.Orange;
                this.menuStrip2.ForeColor = Color.Black;
                this.BackColor = Color.Orange;
                this.toolStrip1.BackColor = Color.Orange;
                this.toolStrip1.ForeColor = Color.Black;
                this.statusStrip1.BackColor = Color.Orange;
                this.statusStrip1.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Создание нового файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox richTextBox = new RichTextBox { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None };
            TabPage tabPage = new TabPage { Text = $"Untitled{tabCount++}" };
            TabControl.ContextMenuStrip = contextMenuStrip1;
            richTextBox.ContextMenuStrip = contextMenuStrip2; 
            tabPage.Controls.Add(richTextBox);
            this.TabControl.SelectedTab = tabPage;
            this.TabControl.TabPages.Add(tabPage);
            Control richTextBox1 = TabControl.TabPages[this.TabControl.SelectedIndex].Controls[0];
            richTextBox1.Select();
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// Удаление вкладки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.Remove(this.TabControl.SelectedTab);
            tabCount--;
        }

        /// <summary>
        /// Сохранение при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TabControl.TabPages.Count >= 1)
            {
                var richTextBox = ControlTab();
                TabControl.TabPageCollection tabPageCollection = TabControl.TabPages;
                foreach (var item in tabPageCollection)
                {
                    if (richTextBox.Text.Length > 0)
                    {
                        DialogResult result = MessageBox.Show(
                            "Хотите сохранить файл перед выходом?",
                            $"{item}",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                SaveFile_Click(sender, e);
                                break;
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
        }

        // Копировать.
        private void CopyMenuStrip_Click(object sender, EventArgs e) => CopyToolStripMenuItem_Click(sender, e);
        // Вставить.
        private void PasteMenuStrip_Click(object sender, EventArgs e) => PasteToolStripMenuItem_Click(sender, e);
        // Вырезать.
        private void CutMenuStrip_Click(object sender, EventArgs e) => CutToolStripMenuItem_Click(sender, e);
        // Выбрать все.
        private void SelectAllMenuStrip_Click(object sender, EventArgs e) => SelectAllToolStripMenuItem_Click(sender, e);
        // Очистить.
        private void ClearTextMenuStrip_Click(object sender, EventArgs e) => ClearTextToolStripMenuItem_Click(sender, e);

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

/*         // Путь к автосохранениям.
        private string path = @"saves/save.rtf";

        /// <summary>
        /// Срабатывание таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                path = @"saves/save.rtf";
                TabControl.TabPageCollection itemCollection = TabControl.TabPages;
                TabPage tb = TabControl.SelectedTab;

                foreach (TabPage item in itemCollection)
                { 
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(item.Text);
                    writer.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Выключение таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    if (timer.Enabled == true)
                    {
                        timer.Stop();
                    }
                    else
                    {
                        timer.Start();
                    }
                }
                else return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }*/