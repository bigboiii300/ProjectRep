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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool signIn = false;
            string data = $"{textBox1.Text} {textBox2.Text}";
            string[] readData = File.ReadAllLines("dataClient.txt");
            foreach (var info in readData)
            {
                if (data==info)
                {
                    MessageBox.Show("Вход выполнен!");
                    signIn = true;
                }
            }
            if (signIn == false)
            {
                MessageBox.Show("Пользователь не найден!");
            }
            this.Close();
        }
    }
}
