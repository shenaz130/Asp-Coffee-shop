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
    /// Summary description for Customer
    /// </summary>
    public class Customer
    {
        public string Address
        {
            get;
            set;
        }

        public int CustomerId
        {
            get;
            set;
        }

        public string CustomerName
        {
            get;
            set;
        }

        public int CustomerContact
        {
            get;
            set;
        }

        public Sales Sales
        {
            get;
            set;
        }



        public void ViewCustomer()
        {
            throw new System.NotImplementedException();
        }



        public DataTable SearchCustomer(string keyword)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();
            string sql = @"SELECT 
                                      cust_id, cust_name, cust_contact, cust_add
                                      FROM
                                      customer
                                      WHERE cust_id =@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("keyword", keyword);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            con.Close();
            return ds;

        }


        public void AddCustomer(int custId, string cust_name, int cust_contact, string cust_add)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"INSERT into customer(cust_id, cust_name, cust_contact, cust_add)
                        VALUES (@id, @name)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", custId);
            cmd.Parameters.AddWithValue("name", cust_name);
            cmd.Parameters.AddWithValue("contact", cust_contact);
            cmd.Parameters.AddWithValue("address", cust_add);
            con.Close();
        }

        public DataTable GetCustomerData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT cust_id, cust_name, cust_contact, cust_add FROM customer";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("customer");
                sda.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteCustomer(int custId)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();

            string sql = "DELETE FROM customer WHERE cust_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", custId);
            con.Close();
        }

        public void UpdateCustomer(int custId, string cust_name, int cust_contact, string cust_add)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE customer SET cust_id=@id, cust_name=@name, cust_contact=@contact,cust_add=@address
                                 WHERE branch_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", custId);
            cmd.Parameters.AddWithValue("name", cust_name);
            cmd.Parameters.AddWithValue("contact", cust_contact);
            cmd.Parameters.AddWithValue("address", cust_add);

            int result = cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}