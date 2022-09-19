using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Project_GUI
{
    public partial class Productcard : UserControl
    {
        private string _product;

        public string Product
        {
            get { return _product; }
            set { _product = value; label1.Text = value; }
        }
        private string _product1;

        public string Product1
        {
            get { return _product1; }
            set { _product1 = value; label2.Text = value; }
        }
        private string _product2;

        public string Product2
        {
            get { return _product2; }
            set { _product2 = value; label3.Text = value; }
        }
        private string _product3;

        public string Product3
        {
            get { return _product3; }
            set { _product3 = value; label4.Text = value; }
        }
        private string _product4;

        public string Product4
        {
            get { return _product4; }
            set { _product4 = value; label5.Text = value; }
        }
        public Productcard()
        {
            InitializeComponent();
        }
        private void productcard_Load(object sender, EventArgs e)
        {

        }
    }
}
