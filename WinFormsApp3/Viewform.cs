using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Project_GUI
{
    public partial class Viewform : Form
    {
        public Viewform()
        {
            InitializeComponent();
        }


        private void Viewform_Load(object sender, EventArgs e)
        {
            if (Product.p.Count < 1)
                MessageBox.Show("No product has been added.");
            else
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in Product.getproduct())
                {
                    Productcard p = new Productcard();
                    p.Product = item.Object_name;
                    p.Product1 = item.Number.ToString();
                    p.Product2 = item.Inventory_number.ToString();
                    p.Product3 = item.Date;
                    p.Product4 = item.Price.ToString();
                    p.Click += card_click;
                    p.Click += (object s, EventArgs e1) =>
                    {

                    };
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
        }
        private void card_click(object sender, EventArgs e)
        {
            MessageBox.Show("card clicked");

        }
    }
}
