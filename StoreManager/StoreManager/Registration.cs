using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            ClientData client = new ClientData(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text);
            using (StreamWriter data = new StreamWriter("dataClient.txt", true, System.Text.Encoding.Default))
            { ;
                data.WriteLine($"{client.Login} {client.Password}");
            }
            MessageBox.Show(
                "Вы успешно зарегистрировались!", "Уведомление", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
