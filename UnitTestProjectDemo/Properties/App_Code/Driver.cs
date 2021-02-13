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
    /// Summary description for Driver
    /// </summary>
    public class Driver
    {
        public bool Available
        {
            get;
            set;
        }

        public string DriverName
        {
            get;
            set;
        }

        public int DriverId
        {
            get;
            set;
        }

        public int ContactNo
        {
            get;
            set;
        }

        public int LicenseNo
        {
            get;
            set;
        }

        public int VehicleNo
        {
            get;
            set;
        }

        public int DriverAge
        {
            get;
            set;
        }
        public int nic
        {
            get;
            set;
        }


        public DataTable SearchDriver(string keyword)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();
            string sql = @"SELECT 
                                      driver_id, driver_name, available, contact, nic, license_no, vehicle_no, driver_age
                                      FROM
                                      driver
                                      WHERE driver_id =@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("keyword", keyword);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            con.Close();
            return ds;
        }


        public void AddDriver(int drv_Id, string drv_name, int drv_contact, string drv_nic, int drv_lic)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"INSERT into delivery(driver_id, driver_name, available, contact, nic, license_no, vehicle_no, driver_age)
                        VALUES (@id, @name, @available, @contact, @nic, @lic)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", drv_Id);
            cmd.Parameters.AddWithValue("name", drv_name);
            //cmd.Parameters.AddWithValue("available", drv);
            cmd.Parameters.AddWithValue("contact", drv_contact);
            cmd.Parameters.AddWithValue("nic", drv_nic);
            cmd.Parameters.AddWithValue("lic", drv_lic);

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
                string sql = "SELECT driver_id, driver_name, available, contact, nic, license_no, vehicle_no, driver_age FROM delivery";
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

        public void UpdateDriver(int drv_Id, string drv_name, int drv_contact, string drv_nic, int drv_lic)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            string sql = @"UPDATE customer SET driver_id=@id, driver_name=@name, available= @available, contact=@contact, nic=@nic, license_no=@lic, vehicle_no=@veh_no, driver_age=@age,
                                 WHERE driver_id)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", drv_Id);
            cmd.Parameters.AddWithValue("name", drv_name);
            //cmd.Parameters.AddWithValue("available", drv);
            cmd.Parameters.AddWithValue("contact", drv_contact);
            cmd.Parameters.AddWithValue("nic", drv_nic);
            cmd.Parameters.AddWithValue("lic", drv_lic);
            int result = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteDriverDriver(int drv_Id)
        {
            string connectionstring = null;
            MySqlConnection con;
            connectionstring = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connectionstring);
            con.Open();

            string sql = "DELETE FROM driver WHERE driver_id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("id", drv_Id);
            con.Close();
        }
    }

}