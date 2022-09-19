using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB_Project_GUI
{
    public partial class Form1 : Form
    {
        public Form1(String name)
        {
            InitializeComponent();
            label7.Text = name;
        }
        Product p = new Product();
        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean x = false;
            Product p = new Product();
            Regex r = new Regex(@"^[0-9]+$");
            var item = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            MessageBox.Show(item.Name);

            if (radioButton2.Checked)
            {
                p.Gender = 'F';
            }
            else if (radioButton1.Checked)
            {
                p.Gender = 'M';
            }
            else
            {
                MessageBox.Show("gender not selected");
                x = true;
            }
            if (checkBox1.Checked)
            {
                MessageBox.Show("Item is available");
                p.Isavail = checkBox1.Checked;
            }
            else
            {
                MessageBox.Show("Item is not available");
            }

            try
            {
                errorProvider1.Clear();
                p.Number = int.Parse(textBox1.Text);
            }
            catch (Exception e1)
            {
                x = true;
                errorProvider1.SetError(textBox1, "Number is required");
            }
            //

            try
            {
                errorProvider2.Clear();
                p.Inventory_number = int.Parse(textBox2.Text);

            }
            catch (Exception e2)
            {
                x = true;
                errorProvider2.SetError(textBox2, "Inventory Number is required");
            }
            //

            if (r.IsMatch(textBox4.Text))
            {
                p.Count = int.Parse(textBox4.Text);
            }
            else
            {
                errorProvider1.SetError(textBox4, "Invalid Count number");
                x = true;
            }
            if (r.IsMatch(textBox5.Text))
            {
                p.Price = int.Parse(textBox5.Text);
            }
            else
            {
                errorProvider1.SetError(textBox5, "Invalid Price number");
                x = true;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Object name is required");

            }
            else
            {
                p.Object_name = textBox4.Text;
            }
            if (x == false)
            {
                p.Date = dateTimePicker1.Text;
                p.save();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox4.Clear();
                textBox1.Text = null;
                textBox2.Text = null;
                textBox5.Text = null;
                textBox3.Text = null;

            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox5.Text = null;
            textBox3.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Sql_connection.Sqlconn();

        }
    }
}
