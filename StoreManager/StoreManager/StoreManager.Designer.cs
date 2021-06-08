
namespace StoreManager
{
    partial class StoreManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SortColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТоваруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddSubNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomSubDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествуРазделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddGoods = new System.Windows.Forms.Button();
            this.AddDir = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RandomDir = new System.Windows.Forms.Button();
            this.RandomGoods = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameOfNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOfNodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOf,
            this.Code,
            this.Quantity,
            this.Price});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(703, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(887, 681);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameOf
            // 
            this.NameOf.HeaderText = "Название товара/услуги";
            this.NameOf.MinimumWidth = 8;
            this.NameOf.Name = "NameOf";
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortColumnsToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 100);
            // 
            // SortColumnsToolStripMenuItem
            // 
            this.SortColumnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поКодуToolStripMenuItem,
            this.поКоличествуToolStripMenuItem,
            this.поТоваруToolStripMenuItem});
            this.SortColumnsToolStripMenuItem.Name = "SortColumnsToolStripMenuItem";
            this.SortColumnsToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.SortColumnsToolStripMenuItem.Text = "Сортировать";
            this.SortColumnsToolStripMenuItem.Visible = false;
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            // 
            // поКодуToolStripMenuItem
            // 
            this.поКодуToolStripMenuItem.Name = "поКодуToolStripMenuItem";
            this.поКодуToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            // 
            // поКоличествуToolStripMenuItem
            // 
            this.поКоличествуToolStripMenuItem.Name = "поКоличествуToolStripMenuItem";
            this.поКоличествуToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            // 
            // поТоваруToolStripMenuItem
            // 
            this.поТоваруToolStripMenuItem.Name = "поТоваруToolStripMenuItem";
            this.поТоваруToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.удалитьToolStripMenuItem.Text = "Удалить ";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteGoodsToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSubNodeToolStripMenuItem,
            this.RandomSubDirToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.DeleteToolStripMenuItem1,
            this.SortMenuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(278, 164);
            // 
            // AddSubNodeToolStripMenuItem
            // 
            this.AddSubNodeToolStripMenuItem.Name = "AddSubNodeToolStripMenuItem";
            this.AddSubNodeToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.AddSubNodeToolStripMenuItem.Text = "Добавить подкаталог";
            this.AddSubNodeToolStripMenuItem.Visible = false;
            this.AddSubNodeToolStripMenuItem.Click += new System.EventHandler(this.AddSubNodeToolStripMenuItem_Click);
            // 
            // RandomSubDirToolStripMenuItem
            // 
            this.RandomSubDirToolStripMenuItem.Name = "RandomSubDirToolStripMenuItem";
            this.RandomSubDirToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.RandomSubDirToolStripMenuItem.Text = "Рандомный подкаталог";
            this.RandomSubDirToolStripMenuItem.Visible = false;
            this.RandomSubDirToolStripMenuItem.Click += new System.EventHandler(this.RandomSubDirToolStripMenuItem_Click_1);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.RenameToolStripMenuItem.Text = "Переименовать";
            this.RenameToolStripMenuItem.Visible = false;
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem1
            // 
            this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
            this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(277, 32);
            this.DeleteToolStripMenuItem1.Text = "Удалить";
            this.DeleteToolStripMenuItem1.Visible = false;
            this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SortMenuToolStripMenuItem
            // 
            this.SortMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortNameToolStripMenuItem,
            this.поКоличествуРазделовToolStripMenuItem});
            this.SortMenuToolStripMenuItem.Name = "SortMenuToolStripMenuItem";
            this.SortMenuToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.SortMenuToolStripMenuItem.Text = "Сортировать";
            this.SortMenuToolStripMenuItem.Visible = false;
            // 
            // SortNameToolStripMenuItem
            // 
            this.SortNameToolStripMenuItem.Name = "SortNameToolStripMenuItem";
            this.SortNameToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.SortNameToolStripMenuItem.Text = "По названию";
            this.SortNameToolStripMenuItem.Click += new System.EventHandler(this.SortNameToolStripMenuItem_Click);
            // 
            // поКоличествуРазделовToolStripMenuItem
            // 
            this.поКоличествуРазделовToolStripMenuItem.Name = "поКоличествуРазделовToolStripMenuItem";
            this.поКоличествуРазделовToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.поКоличествуРазделовToolStripMenuItem.Text = "По количеству разделов";
            this.поКоличествуРазделовToolStripMenuItem.Click += new System.EventHandler(this.SortDirToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            // 
            // AddGoods
            // 
            this.AddGoods.AutoSize = true;
            this.AddGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddGoods.Location = new System.Drawing.Point(0, 279);
            this.AddGoods.Name = "AddGoods";
            this.AddGoods.Size = new System.Drawing.Size(202, 93);
            this.AddGoods.TabIndex = 3;
            this.AddGoods.Text = "Добавить товар";
            this.AddGoods.UseVisualStyleBackColor = true;
            this.AddGoods.Visible = false;
            this.AddGoods.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // AddDir
            // 
            this.AddDir.AutoSize = true;
            this.AddDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddDir.Location = new System.Drawing.Point(0, 0);
            this.AddDir.Name = "AddDir";
            this.AddDir.Size = new System.Drawing.Size(202, 93);
            this.AddDir.TabIndex = 4;
            this.AddDir.Text = "Добавить раздел";
            this.AddDir.UseVisualStyleBackColor = true;
            this.AddDir.Click += new System.EventHandler(this.AddDirectory_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.Location = new System.Drawing.Point(0, 372);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(202, 93);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить и очистить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSize = true;
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadButton.Location = new System.Drawing.Point(0, 465);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(202, 89);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.Load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RandomDir
            // 
            this.RandomDir.AutoSize = true;
            this.RandomDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.RandomDir.Location = new System.Drawing.Point(0, 93);
            this.RandomDir.Name = "RandomDir";
            this.RandomDir.Size = new System.Drawing.Size(202, 93);
            this.RandomDir.TabIndex = 7;
            this.RandomDir.Text = "Рандомный раздел";
            this.RandomDir.UseVisualStyleBackColor = true;
            this.RandomDir.Click += new System.EventHandler(this.Random_Click);
            // 
            // RandomGoods
            // 
            this.RandomGoods.AutoSize = true;
            this.RandomGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.RandomGoods.Location = new System.Drawing.Point(0, 186);
            this.RandomGoods.Name = "RandomGoods";
            this.RandomGoods.Size = new System.Drawing.Size(202, 93);
            this.RandomGoods.TabIndex = 8;
            this.RandomGoods.Text = "Рандомный товар";
            this.RandomGoods.UseVisualStyleBackColor = true;
            this.RandomGoods.Visible = false;
            this.RandomGoods.Click += new System.EventHandler(this.RandomGoods_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.AddGoods);
            this.panel1.Controls.Add(this.RandomGoods);
            this.panel1.Controls.Add(this.RandomDir);
            this.panel1.Controls.Add(this.AddDir);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 554);
            this.panel1.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(504, 681);
            this.treeView1.TabIndex = 2;
            this.treeView1.DoubleClick += new System.EventHandler(this.DoubleClick_Node);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Аккаунт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGoodsBindingSource
            // 
            this.dataGoodsBindingSource.DataSource = typeof(global::StoreManager.DataGoods);
            // 
            // nameOfNodeBindingSource
            // 
            this.nameOfNodeBindingSource.DataSource = typeof(global::StoreManager.NameOfNode);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(global::StoreManager.StoreManager);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(global::StoreManager.StoreManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOfNodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem AddSubNodeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Button AddGoods;
        private System.Windows.Forms.Button AddDir;
        private System.Windows.Forms.BindingSource nameOfNodeBindingSource;
        private System.Windows.Forms.BindingSource dataGoodsBindingSource;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SortMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествуРазделовToolStripMenuItem;
        private System.Windows.Forms.Button RandomDir;
        private System.Windows.Forms.Button RandomGoods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem RandomSubDirToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SortColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТоваруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

