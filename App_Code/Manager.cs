﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;


namespace William
{
    /// <summary>
    /// Summary description for Manager
    /// </summary>
    public class Manager : User
    {
        public string Password
        {
            get;
            set;
        }

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

        public void ViewUser()
        {
            throw new System.NotImplementedException();
        }

        public void SearchUser()
        {
            throw new System.NotImplementedException();
        }

    }

}