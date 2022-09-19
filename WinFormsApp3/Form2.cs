using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_Project_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Product.p.Clear();
            Sql_connection.selectallpproduct(Product.p);
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (textBox1.Text != username)
            {
                errorProvider1.SetError(textBox1, "User name is Invalid");
            }
            if (textBox2.Text != password)
            {
                errorProvider2.SetError(textBox2, "Password is Invalid");
            }
            if (textBox1.Text == username && textBox2.Text == password)
            {
                Mainform Form1 = new Mainform(username);
                this.Hide();
                Form1.Show();
            }

        }
    }
}
