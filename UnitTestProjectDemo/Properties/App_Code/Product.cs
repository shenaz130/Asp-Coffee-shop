using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace William
{

    /// <summary>
    /// Summary description for Product
    /// </summary>
    public abstract class Product
    {
        public string ProductName
        {
            get;
            private set;
        }

        public int ProductId
        {
            get;
            private set;
        }

        public int Quantity
        {
            get;
            private set;
        }

        public int UnitPrice
        {
            get;
            private set;
        }
        public bool drink
        {
            get;
            set;
        }
        public bool burger
        {
            get;
            set;
        }
        public bool salad
        {
            get;
            set;
        }
        public bool sndwch
        {
            get;
            set;
        }

        public bool dssrt
        {
            get;
            set;
        }
        public abstract void AddProduct();

        public abstract void DeleteProduct();

        public abstract void ViewProduct();

        public abstract void EditProduct();

        public abstract void Searchproduct();


        public Product()
        {
            
        }

        

        public DataTable GetProductData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT product_id, product_name, unit_price, quantity, drink, burger, sandwich, salad, dessert FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("products");
                sda.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Reach Error " + ex.Message);
                throw;
            }
        }

        public void DeleteProduct(int pro_id)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = "DELETE FROM products WHERE product_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);


            cmd.Parameters.AddWithValue("id", ProductId);
            con.Close();
        }

        public void AddProduct(int pro_id, string pro_name, int price, int supid, int qty, string type)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"INSERT into products
                    (product_id, product_name, unit_price, quantity, drink, burger, sandwich, salad, dessert)
                    VALUES 
                    (@id, @name, @price, @qty, @dr ,@burger, @san, @salad, @desrt)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", ProductId);
            cmd.Parameters.AddWithValue("name", ProductName);
            cmd.Parameters.AddWithValue("price", UnitPrice);
            cmd.Parameters.AddWithValue("qty", Quantity);
            cmd.Parameters.AddWithValue("dr", drink);
            cmd.Parameters.AddWithValue("burger", burger);
            cmd.Parameters.AddWithValue("san", sndwch);
            cmd.Parameters.AddWithValue("salad", salad);
            cmd.Parameters.AddWithValue("desrt", dssrt);
            con.Close();
        }

        public void UpdateProduct(int pro_id, string pro_name, int price, int supid, int qty, string type)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE products SET 
                        product_id= @id, product_name=@name, unit_price=@price, quantity=@qty, drink=@dr, burger=,@burger, sandwich= @san, salad= @salad, dessert@desrt,
                                 WHERE  product_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", ProductId);
            cmd.Parameters.AddWithValue("name", ProductName);
            cmd.Parameters.AddWithValue("price", UnitPrice);
            cmd.Parameters.AddWithValue("qty", Quantity);
            cmd.Parameters.AddWithValue("dr", drink);
            cmd.Parameters.AddWithValue("burger", burger);
            cmd.Parameters.AddWithValue("san", sndwch);
            cmd.Parameters.AddWithValue("salad", salad);
            cmd.Parameters.AddWithValue("desrt", dssrt);
            int result = cmd.ExecuteNonQuery();
            con.Close();

        }
    }

}