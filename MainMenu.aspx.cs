using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.IO;
using William;


public partial class MainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            System.Data.DataTable datedrop = new System.Data.DataTable();
            datedrop.Columns.Add(new System.Data.DataColumn("Dates"));
            datedrop.Rows.Add(System.DateTime.Today.ToShortDateString());

            for (int i = -7; i < 7; i++)
            {
                datedrop.Rows.Add(System.DateTime.Today.AddDays(i).ToShortDateString());
            }

            DropDownDate.DataSource = datedrop;
            DropDownDate.DataTextField = datedrop.Columns["Dates"].ToString();
            DropDownDate.DataBind();

            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);


            con.Open();
            MySqlCommand sda = new MySqlCommand("SELECT sandwich FROM products", con);
            MySqlDataReader dr;
            dr = sda.ExecuteReader();
            dropdownSandwich.Items.Clear();
            while (dr.Read())
            {
                dropdownSandwich.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdownSandwich.DataBind();
            con.Close();

            con.Open();
            sda = new MySqlCommand("SELECT burger FROM products", con);
            dr = sda.ExecuteReader();
            dropdownBurger.Items.Clear();
            while (dr.Read())
            {
                dropdownBurger.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdownBurger.DataBind();
            con.Close();

            con.Open();
            sda = new MySqlCommand("SELECT salad FROM products", con);
            dr = sda.ExecuteReader();
            dropdownSalad.Items.Clear();
            while (dr.Read())
            {
                dropdownSalad.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdownSalad.DataBind();
            con.Close();

            con.Open();
            sda = new MySqlCommand("SELECT drink FROM products", con);
            dr = sda.ExecuteReader();
            dropdownCoffee.Items.Clear();
            while (dr.Read())
            {
                dropdownCoffee.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdownCoffee.DataBind();
            con.Close();

            con.Open();
            sda = new MySqlCommand("SELECT dessert FROM products", con);
            dr = sda.ExecuteReader();
            dropdownDessert.Items.Clear();
            while (dr.Read())
            {
                dropdownDessert.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdownDessert.DataBind();
            con.Close();

        }
    }
    
    protected void btn_add_Click(object sender, EventArgs e)
    {
        string connetionString = null;
        MySqlConnection con;
        connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
        con = new MySqlConnection(connetionString);
        con.Open();
        string comm = @"INSERT INTO sales
                        (user_id, sales_no, date, time, quantity,Cust_name, total_amount, delivery_id,product_name)
                            VALUES
              (@u_id, @sales_no,@date,@time,@qty,@cust_name,@tot,@deli_id,@prd)";

        string str = dropdownSandwich.SelectedItem.ToString() + " - " + dd_san_qty.SelectedItem.ToString() + ", " + dropdownDessert.SelectedItem.ToString() + " - " + dd_d_qty.SelectedItem.ToString() + ", " + dropdownCoffee.SelectedItem.ToString() + " - " + dd_cof_qty.SelectedItem.ToString() + ", " + dropdownBurger.SelectedItem.ToString() + " - " + dd_b_qty.SelectedItem.ToString() + ", " + dropdownSalad.SelectedItem.ToString() + " - " + dd_s_qty.SelectedItem.ToString();
        MySqlCommand cmd = new MySqlCommand(comm, con);

        cmd.Parameters.AddWithValue("u_id", txt_user_id.Text);
        cmd.Parameters.AddWithValue("sales_no", txt_sales_id.Text);
        cmd.Parameters.AddWithValue("date", DropDownDate.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("time", txt_time.Text);
        cmd.Parameters.AddWithValue("qty", txt_quantity.Text);
        cmd.Parameters.AddWithValue("cust_name", txt_cust_name.Text);
        cmd.Parameters.AddWithValue("tot", txt_total.Text);
        cmd.Parameters.AddWithValue("deli_id", txt_deli_id.Text);
        cmd.Parameters.AddWithValue("prd", str);

        con.Close();
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {

    }
}