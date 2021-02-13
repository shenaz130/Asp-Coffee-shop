using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;


namespace William
{
    public class User
    {
        public void AddUser(int u_Id, string u_name, int u_brid, string privillage, string password)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"INSERT into user(user_id, password, privilage, branch_id, user_name) 
                    VALUES (@id, @name,@password,@privillage,@branch_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", u_Id);
            cmd.Parameters.AddWithValue("name", u_name);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("privillage", privillage);
            cmd.Parameters.AddWithValue("branch_id", u_brid);
            con.Close();
        }


        public void UpdateUser(int u_Id, string u_name, int u_brid, string privillage, string password)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE user SET user_id=u_id, password=@password, privilage=@privillage, branch_id=@branch_id, user_name=@name, 
                                 WHERE user_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", u_Id);
            cmd.Parameters.AddWithValue("name", u_name);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("privillage", privillage);
            cmd.Parameters.AddWithValue("branch_id", u_brid);

            int result = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteUser(int u_Id)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = "DELETE FROM user WHERE user_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);


            cmd.Parameters.AddWithValue("id", u_Id);
            con.Close();
        }

        public System.Data.DataTable GetUsersdata()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT user_id FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("user");
                sda.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public System.Data.DataTable GetUsersData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT user_id FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("user");
                sda.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}