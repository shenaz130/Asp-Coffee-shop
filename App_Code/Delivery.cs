using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using William;

namespace William
{
    /// <summary>
    /// Summary description for Delivery
    /// </summary>
    public class Delivery
    {
        public int DeliveryId
        {
            get;
            set;
        }

        public int CustomerId
        {
            get;
            set;
        }

        public int SalesId
        {
            get;
            set;
        }

        public string Date
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }

        public Driver DriverId
        {
            get;
            set;
        }

        public Branch BranchID
        {
            get;
            set;
        }

        public Customer Customer
        {
            get;
            set;
        }


        public void AddDelivery(Delivery dry)
        {

           
        }

      

        public DataTable SearchDelivery(string keyword)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();
            string sql = @"SELECT 
                                      delivery_id, date, time, location, sales_id, branch_id, driver_id
                                      FROM
                                      delivery
                                      WHERE delivery_id =@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("keyword", keyword);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            con.Close();
            return ds;

        }

        public void ViewDelivery()
        {
            throw new System.NotImplementedException();
        }

        public void AddDelivery(int deliId, string date, string time, string location, int salesId, int branchId, int driverId)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"INSERT into delivery(delivery_id, date, time, location, sales_id, branch_id, driver_id)
                        VALUES (@id, @date, @time, @location, @s_id, @br_id, @dr_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", DeliveryId);
            cmd.Parameters.AddWithValue("date", Date);
            cmd.Parameters.AddWithValue("time", Time);
            cmd.Parameters.AddWithValue("location", Location);
            cmd.Parameters.AddWithValue("s_id", SalesId);
            cmd.Parameters.AddWithValue("br_id", BranchID);
            cmd.Parameters.AddWithValue("dr_id", DriverId);

            con.Close();
        }

        public DataTable GetDriverData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = @"SELECT driver_id, driver_name, available, contact, nic, license_no, vehicle_no, driver_age 
                                FROM driver";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("driver");
                sda.Fill(dt);
                con.Close();
                return dt;

            }

            catch (Exception ex)
            {
                throw;
            }

        }

        public void UpdateDelivery(int deliId, string date, string time, string location, int salesId, int branchId, int driverId)
        {

            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE delivery SET delivery_id=@id, date=@date, time=@time, location=@location,
                                    sales_id=@s_id, branch_id=@br_id, driver_id=@dr_id,
                                     WHERE delivery_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id",DeliveryId);
            cmd.Parameters.AddWithValue("date", Date);
            cmd.Parameters.AddWithValue("time", Time);
            cmd.Parameters.AddWithValue("location",Location);
            cmd.Parameters.AddWithValue("s_id", SalesId);
            cmd.Parameters.AddWithValue("br_id", BranchID);
            cmd.Parameters.AddWithValue("dr_id", DriverId);

            int result = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteDelivery(int deliId)
        {
            Delivery delivery = new Delivery();
            delivery = null;
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();

            string sql = "DELETE FROM delivery WHERE delivery_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", DeliveryId);
            con.Close();
        }

        public DataTable GetDeliveryData()
        {
            try
            {
                string connetionString = null;
                MySqlConnection con;
                connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
                con = new MySqlConnection(connetionString);
                con.Open();
                string sql = "SELECT delivery_id, date, time, location, sales_id, branch_id, driver_id FROM delivery";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("delivery");
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
