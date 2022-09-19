using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_Project_GUI
{
    internal class Sql_connection
    {
        static SqlConnection conn;
        public static void Sqlconn()
        {
            string cs = @"server=. ;database=product;integrated security=true";
            conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                //MessageBox.Show("connected");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static void insertpproduct(Product p)
        {
            string insertquery = "insert into product values(@object_name, @gender, @number,@date,@inventory_number,@price,@count)";

            try
            {
                Sqlconn();

                SqlCommand cmd = new SqlCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("@object_name", p.Object_name);
                cmd.Parameters.AddWithValue("@gender", p.Gender);
                cmd.Parameters.AddWithValue("@number", p.Number);
                cmd.Parameters.AddWithValue("@date", p.Date);
                cmd.Parameters.AddWithValue("@inventory", p.Inventory_number);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@count", p.Count);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"Product {p.Object_name} has been Added Successfully");
                //conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public static void selectallpproduct(List<Product> temp)
        {

            try
            {
                Sqlconn();
                SqlCommand cmd = new SqlCommand("select * from product", conn);
                SqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    Product p = new Product();
                    p.Object_name = res["objectname"].ToString();
                    char[] g = res[1].ToString().ToCharArray();
                    p.Gender = g[0];
                    p.Number = int.Parse(res[2].ToString());
                    p.Date = res[3].ToString();
                    p.Inventory_number = double.Parse(res[4].ToString());
                    p.Price = double.Parse(res[5].ToString());
                    p.Count = double.Parse(res[6].ToString());
                    temp.Add(p);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
