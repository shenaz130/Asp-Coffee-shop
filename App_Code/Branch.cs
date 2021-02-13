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
    /// Summary description for Branch
    /// </summary>
    public class Branch
    {
        public int BranchId
        {
            get;
            set;
        }

        public string BranchName
        {
            get;
            set;
        }

        public Revenue Revenue
        {
            get;
            set;
        }

        public NetProfit NetProfit
        {
            get;
            set;
        }







        public DataTable SearchBranch(string keyword)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();
            string sql = @"SELECT 
                                       branch_id, branch_name
                                      FROM
                                        branch
                                      WHERE branch_id =@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("keyword", keyword);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            con.Close();
            return ds;

        }




        public DataTable GetBranchData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT branch_id, branch_name FROM branch";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("branch");
                sda.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AddBranch(int bid, string bname)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = "INSERT into branch(branch_id, branch_name) VALUES (@id, @name)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", bid);
            cmd.Parameters.AddWithValue("name", bname);
            con.Close();
            return true;
        }

        public void EditBranch(int bid, string bname)
        {

            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE branch SET branch_id=@id, branch_name=@name, 
                                 WHERE branch_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", bid);
            cmd.Parameters.AddWithValue("name", bname);

            int result = cmd.ExecuteNonQuery();
            con.Close();
        }


        public void DeleteBranch(int bid)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = "DELETE FROM branch WHERE branch_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);


            cmd.Parameters.AddWithValue("id", bid);
            con.Close();
        }
    }
}