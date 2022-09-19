using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Project_GUI
{
    public class Product
    {
        public int Number { get; set; }
        public double Inventory_number { get; set; }
        public string Object_name { get; set; }
        public string Date { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public bool Isavail { get; set; }
        public char Gender { get; set; }

        public static List<Product> p = new List<Product>();
        public void save()
        {
            MessageBox.Show(this.Object_name + " has been added successfully!!");
            p.Add(this);
            Sql_connection sql_Conn = new Sql_connection();
            Sql_connection.insertpproduct(this);
        }
        public static List<Product> getproduct()

        {
            Sql_connection sql_Conn = new Sql_connection();
            List<Product> temp = new List<Product>();
            Sql_connection.selectallpproduct(temp);
            return temp;

        }

        public static List<Product> GetAllproduct(String name)
        {
            List<Product> p1 = new List<Product>();
            foreach (Product p in p)
                p1.Add(p);
            return p1;
        }

    }
}
