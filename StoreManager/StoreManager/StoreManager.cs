using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace StoreManager
{
    public partial class StoreManager : Form
    {
        public StoreManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отображение активных кнопок.
        /// </summary>
        public void ShowButtons()
        {
            LoadButton.Visible = true;
            SaveButton.Visible = true;
            RandomGoods.Visible = true;
            AddGoods.Visible = true;
            RenameToolStripMenuItem.Visible = true;
            DeleteToolStripMenuItem1.Visible = true;
            AddSubNodeToolStripMenuItem.Visible = true;
            RandomSubDirToolStripMenuItem.Visible = true;
            SortMenuToolStripMenuItem.Visible = true;
            SortColumnsToolStripMenuItem.Visible = true;
        }

        /// <summary>
        /// Сокрытие неиспользуемых кнопок.
        /// </summary>
        public void HideButtons()
        {
            LoadButton.Visible = false;
            SaveButton.Visible = false;
            AddGoods.Visible = false;
            RandomGoods.Visible = false;
            RenameToolStripMenuItem.Visible = false;
            DeleteToolStripMenuItem1.Visible = false;
            AddSubNodeToolStripMenuItem.Visible = false;
            RandomSubDirToolStripMenuItem.Visible = false;
            SortMenuToolStripMenuItem.Visible = false;
            SortColumnsToolStripMenuItem.Visible = false;
        }


        /// <summary>
        /// Добавление подкаталога в дерево.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на наличие товаров.
                if (treeView1.SelectedNode.Tag!=null)
                {
                    MessageBox.Show(
                        "Невозможно добавить подкаталог!" +
                        " В данном классификаторе уже имеются товары!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                // Вызов новой формы.
                NameOfNode addForm = new NameOfNode();
                addForm.ShowDialog();
                addForm.button1.Click += new EventHandler(addForm.ApplyNameNode_Click);
                if (addForm.DialogResult == DialogResult.OK)
                    // Добавление подкаталога в выбранный каталог.
                    treeView1.SelectedNode.Nodes.Add(addForm.textBox1.Text);
                else
                    return;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Вы не выбрали классификатор!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Переименовать каталог.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Разрешение на редактирование.
                treeView1.LabelEdit = true;
                treeView1.SelectedNode.BeginEdit();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Вы не выбрали классификатор!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Удаление каталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на наличие подкаталогов или товаров.
                if (treeView1.SelectedNode.Nodes.Count > 0 || treeView1.SelectedNode.Tag != null)
                {
                    string caption = "Удаление";
                    string message = "Вы уверены, что хотите удалить классификатор,в котором содержатся товары?";
                    DialogResult result = MessageBox.Show(message, caption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;
                    treeView1.SelectedNode.Remove();
                    // Очищение таблицы с данными.
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    treeView1.SelectedNode.Remove();
                    dataGridView1.Rows.Clear();
                }
                // Скрытие неиспользуемых кнопок.
                if (treeView1.Nodes.Count == 0)
                    HideButtons();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы не выбрали классификатор!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        // Динамическая коллекция с данными товара.
        public ObservableCollection<Goods> DataCollection = new ObservableCollection<Goods>();

        /// <summary>
        /// Выбор каталога для показа товаров внутри.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleClick_Node(object sender, EventArgs e)
        {
            try
            {
                // Проверка на родительский раздел.
                if (treeView1.SelectedNode.GetNodeCount(true) > 0)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    MessageBox.Show(
                        "Товары больше не содержатся в классификаторе! Теперь он является разделом",
                        "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                // Отображение товаров в таблицу.
                ShowRows();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Товары отсутствуют! Попробуйте добавить товары прежде чем открыть классификатор",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Отображение строк в таблицу.
        /// </summary>
        public void ShowRows()
        {
            TreeNode node1 = treeView1.SelectedNode;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            // Добавление строк в таблицу.
            foreach (var item in (ObservableCollection<Goods>)node1.Tag)
            {
                dataGridView1.Rows.Add(item.Name, item.Code, item.Quantity, item.Price);
            }
        }

        /// <summary>
        /// Добавление товара в классификатор.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на родительский классификатор.
                if (treeView1.SelectedNode.GetNodeCount(true) > 0)
                {
                    MessageBox.Show(
                        "Невозможно добавить товар в родительский класификатор!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                DataGoods data = new DataGoods(DataCollection);
                TreeNode node = treeView1.SelectedNode;
                // Если никакие товары не содержатся.
                if (node.Tag != null)
                {
                    // Добавление товаров в коллекцию.
                    if (AddTableRows(node)) return;
                }
                else
                {
                    // Присваиваем тэгу динамическую коллекцию с товарами.
                    node.Tag = new ObservableCollection<Goods>();
                    // Добавление товаров в коллекцию.
                    if (AddTableRows(node)) return;
                }
                // Вывод товаров в таблицу.
                ShowRows();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Вы не выбрали классификатор!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        // Для одноразового вызова сообщения с подсказкой по интерфейсу
        static bool _helpMessage = true;

        /// <summary>
        /// Добавление данных о товаре в коллекцию.
        /// </summary>
        /// <param name="node">Выбранный каталог</param>
        /// <returns></returns>
        private static bool AddTableRows(TreeNode node)
        {
            // Вызов новой формы.
            TableBox tableAdd = new TableBox();
            tableAdd.ShowDialog();
            tableAdd.button1.Click += new EventHandler(tableAdd.ApplyButton_Click);
            if (tableAdd.DialogResult == DialogResult.OK)
            {
                uint.TryParse(tableAdd.textBox2.Text, out uint code);
                uint.TryParse(tableAdd.textBox3.Text, out uint quantity);
                uint.TryParse(tableAdd.textBox3.Text, out uint price);
                // Создание товара и добавление в коллекцию.
                Goods goods = new Goods(tableAdd.textBox1.Text, code, quantity, price);
                ((ObservableCollection<Goods>)node.Tag).Add(goods);
                // Чтобы вызывалось только один раз.
                if (_helpMessage)
                {
                    MessageBox.Show(
                        "Товар добавлен! Для просмотра товаров кликните два раза по классификатору. " +
                        "Больше вы не увидите это сообщение", "Подсказка по интерфейсу",
                        MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    _helpMessage = false;
                }
            }
            else
                return true;
            return false;
        }

        /// <summary>
        /// Создание родительского каталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDirectory_Click(object sender, EventArgs e)
        {
            // Вызов новой формы.
            NameOfNode addForm = new NameOfNode();
            addForm.ShowDialog();
            addForm.button1.Click += new EventHandler(addForm.ApplyNameNode_Click);
            // Отображение элементов интерфейса.
            if (addForm.DialogResult == DialogResult.OK)
            {
                treeView1.Nodes.Add(addForm.textBox1.Text);
                // Отображение кнопок интерфейса.
                ShowButtons();
            }
            else
                return;
        }

        /// <summary>
        /// Сохранение данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = @"xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.DefaultExt = ".xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // Экспортируем данные в xml.
                ExportToXml(treeView1, filename);
                // Закрываем поток.
                _sr.Close();
                treeView1.Nodes.Clear();
                dataGridView1.Rows.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        // Поток для записи в файл.
        private StreamWriter _sr;

        /// <summary>
        /// Экспорт файла в xml.
        /// </summary>
        /// <param name="tv">Дерево</param>
        /// <param name="filename">Путь к файлу</param>
        public void ExportToXml(TreeView tv, string filename)
        {
            _sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            _sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            //Заголовок.
            _sr.WriteLine("<Склад>");
            foreach (TreeNode n in tv.Nodes)
            {
                // Запись родительского каталога.
                _sr.WriteLine("<_" + n.Text + ">");
                // Добавление информации товаров в xml.
                if (n.Tag != null)
                {
                    foreach (var item in (ObservableCollection<Goods>)n.Tag)
                    {
                        _sr.WriteLine("<_goods>");
                        _sr.WriteLine($"{item.Name};{item.Code};{item.Quantity};{item.Price}");
                        _sr.WriteLine("</_goods>");
                    }
                }
                NodeSaveXml(n.Nodes);
                _sr.WriteLine("</_" + n.Text + ">");
            }
            _sr.WriteLine("</Склад>");
        }

        /// <summary>
        /// Сохранение каталогов.
        /// </summary>
        /// <param name="tnc">Коллекция каталогов</param>
        private void NodeSaveXml(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                // Если есть дочерние каталоги.
                if (node.Nodes.Count > 0)
                {
                    // Запись в формат xml.
                    _sr.WriteLine("<_" + node.Text + ">");
                    // Рекурсивный метод.
                    NodeSaveXml(node.Nodes);
                    _sr.WriteLine("</_" + node.Text + ">");
                }
                // Если дочерних каталогов нет.
                else
                {
                    _sr.WriteLine("<_" + node.Text + ">");
                    if (node.Tag != null)
                    {
                        // Добавление информации товаров в xml.
                        foreach (var item in (ObservableCollection<Goods>)node.Tag)
                        {
                            _sr.WriteLine("<_goods>");
                            _sr.WriteLine($"{item.Name};{item.Code};{item.Quantity};{item.Price}");
                            _sr.WriteLine("</_goods>");
                        }
                    }
                    _sr.WriteLine("</_" + node.Text + ">");
                }

            }
        }

        /// <summary>
        /// Преобразование в древовидную структуру из xml.
        /// </summary>
        private void TransformToTreeView()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    treeView1.Nodes.Clear();
                    XmlDocument xDoc = new XmlDocument();
                    // Загрузка документа.
                    xDoc.Load(dlg.FileName);
                    foreach (XmlNode item in xDoc.DocumentElement.ChildNodes)
                    {
                        TreeNode tNode = new TreeNode(item.Name);
                        AddNodesToTreeView(item, tNode);
                        // Добавление в дерево каталогов
                        treeView1.Nodes.Add(tNode);
                    }
                    // Раскрытие всех узлов для удобства.
                    treeView1.ExpandAll();
                }
                catch (XmlException xExc)
                {
                    MessageBox.Show(xExc.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// Добавление каталогов в дерево.
        /// </summary>
        /// <param name="xmlNode">Файл xml</param>
        /// <param name="treeNode">Дерево</param>
        private void AddNodesToTreeView(XmlNode xmlNode, TreeNode treeNode)
        {
            // Если есть дочерние узлы.
            if (xmlNode.HasChildNodes)
            {
                ObservableCollection<Goods> dataCollection = new ObservableCollection<Goods>();
                XmlNodeList xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    XmlNode xNode = xmlNode.ChildNodes[x];
                    if (xNode.Name == "_goods")
                    {
                        string[] data = xNode.InnerText.Split(';');

                         uint.TryParse(data[1], out uint code);
                         uint.TryParse(data[2], out uint quantity);
                         uint.TryParse(data[3], out uint price);
                         // Создание товара и добавление в коллекцию.
                         Goods goods = new Goods(data[0].Trim(), code, quantity, price); 
                         dataCollection.Add(goods);
                    }
                    else
                    {
                        TreeNode tree = new TreeNode(xNode.Name.Substring(1, xNode.Name.Length - 1));
                        treeNode.Nodes.Add(tree);
                        TreeNode tNode = treeNode.Nodes[x-dataCollection.Count];
                        // Рекурсивный вызов.
                        AddNodesToTreeView(xNode, tNode);
                    }
                }
                treeNode.Tag = dataCollection;
            }
            else
            {
                XmlNodeList xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    XmlNode xNode = xmlNode.ChildNodes[x];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    TreeNode tNode = treeNode.Nodes[x];
                }
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            // Вызов метода с загрузкой из файла xml.
            TransformToTreeView();
        }

        /// <summary>
        /// Сортировка каталогов по имени.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Каст каталогов в лист.
            List<TreeNode> nodes = treeView1.Nodes.Cast<TreeNode>().ToList();
            treeView1.Nodes.Clear();
            // Сортировка по имени.
            nodes = new List<TreeNode>(nodes.OrderBy(n => n.Text));
            // Добавление обратно в дерево.
            treeView1.Nodes.AddRange(nodes.ToArray());
        }

        /// <summary>
        /// Сортировка по количеству дочерних узлов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Каст в лист.
                List<TreeNode> nodes = treeView1.Nodes.Cast<TreeNode>().ToList();
                // Бабл сорт.
                for (int i = 0; i < nodes.Count - 1; i++)
                {
                    for (int j = i + 1; j < nodes.Count; j++)
                    {
                        if (nodes[i].Nodes.Count < nodes[j].Nodes.Count)
                        {
                            var temp = nodes[i];
                            nodes[i] = nodes[j];
                            nodes[j] = temp;
                        }
                    }
                }
                treeView1.Nodes.Clear();
                // Добавление обратно в дерево.
                treeView1.Nodes.AddRange(nodes.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ошибка сортировки!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        // Рандом.
        private static readonly Random random = new Random();

        /// <summary>
        /// Создание рандомного каталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Random_Click(object sender, EventArgs e)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string nameDir = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
            treeView1.Nodes.Add(nameDir);
            // Отображение элементов интерфейса.
            ShowButtons();
        }

        /// <summary>
        /// Добавление рандомного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomGoods_Click(object sender, EventArgs e)
        {
            try
            {
                // Если каталог уже содержит дочерние узлы.
                if (treeView1.SelectedNode.GetNodeCount(true) > 0)
                {
                    MessageBox.Show(
                        "Невозможно добавить товар в родительский класификатор!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                TreeNode node = treeView1.SelectedNode;
                // Проверка на наличие товаров в узле.
                if (node.Tag != null)
                {
                    // Создание рандомного товара.
                    RandomGoodsMethod(node);
                    // Отображение в таблице строк.
                    ShowRows();
                }
                else
                {
                    // Создание динамической коллекции в узле.
                    node.Tag = new ObservableCollection<Goods>();
                    RandomGoodsMethod(node);
                    ShowRows();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(
                    "Вы не выбрали классификатор!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Добавление рандомных параметров товара.
        /// </summary>
        /// <param name="node"></param>
        private static void RandomGoodsMethod(TreeNode node)
        {
            const string rndName = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string nameItem = new string(Enumerable.Repeat(rndName, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            int rndCode = random.Next(1, 100000000);
            int rndQuantity = random.Next(1, 10000);
            int rndPrice = random.Next(1, 100000);
            // Создание товара с рандомными параметрами.
            Goods goods = new Goods(nameItem, (uint)rndCode, (uint)rndQuantity, (uint)rndPrice);
            ((ObservableCollection<Goods>)node.Tag).Add(goods);
            if (_helpMessage)
            {
                MessageBox.Show(
                    "Товар добавлен! Для просмотра товаров кликните два раза по классификатору. " +
                    "Больше вы не увидите это сообщение",
                    "Подсказка по интерфейсу", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                _helpMessage = false;
            }
        }

        /// <summary>
        /// Создание рандомного подкаталога.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomSubDirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Проверка на наличие товаров.
                if (treeView1.SelectedNode.Tag != null)
                {
                    MessageBox.Show(
                        "Невозможно добавить подкаталог!" +
                        " В данном классификаторе уже имеются товары!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                const string rndName = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
                string nameItem = new string(Enumerable.Repeat(rndName, 5).Select(s
                    => s[random.Next(s.Length)]).ToArray());
                // Добавление в выбранный каталог.
                treeView1.SelectedNode.Nodes.Add(nameItem);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Вы не выбрали классификатор!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        /// <summary>
        /// Событие при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохранение если есть какие-то данные в таблице.
            if (treeView1.Nodes.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы хотите сохранить данные перед выходом?", "Peergrade",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Save_Click(sender, e);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Peergrade",
                    MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void DeleteGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            var dataGridViewRow = dataGridView1.CurrentRow;
            int n = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(n);
            dataGridView1.Refresh();
            ObservableCollection<Goods> rowCollection = new ObservableCollection<Goods>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string data = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    j++;
                    string data1 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    j++;
                    string data2 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    j++;
                    string data3 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    uint.TryParse(data1, out uint code);
                    uint.TryParse(data2, out uint quantity);
                    uint.TryParse(data3, out uint price);
                    // Создание товара и добавление в коллекцию.
                    Goods goods = new Goods(data, code, quantity, price);
                    rowCollection.Add(goods);
                }
            }

            treeView1.SelectedNode.Tag = rowCollection;
            ShowRows();
        }

        public static List<ClientData> clientDatas =new List<ClientData>();
        private void button1_Click(object sender, EventArgs e)
        {
            SignIn account = new SignIn();
            account.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}