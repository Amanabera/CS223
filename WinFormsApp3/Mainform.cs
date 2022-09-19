using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB_Project_GUI
{
    public partial class Mainform : Form
    {
        String name;
        public Mainform(string Username)
        {
            name = Username;
            InitializeComponent();
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }


            Form1 form1 = new Form1(name);
            form1.MdiParent = this;
            form1.Show();

        }

        private void ViewproductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Viewform V = new Viewform();
            V.MdiParent = this;
            V.Show();

        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Search s = new Search();
            s.MdiParent = this;
            s.Show();

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            AddToolStripMenuItem_Click(sender, e);
            AddtoolStripMenuItem.Enabled = true;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
