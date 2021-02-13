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

public partial class packages : System.Web.UI.Page
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
            connetionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);


            

        }
        

    }
    protected void dropdownPack_SelectedIndexChanged(object sender, EventArgs e)
    {
        string foodtype;
        foodtype = dropdownPack.SelectedIndex.ToString();
        if (foodtype.Equals("Morning ")){

            lblPack1.Text = "Cheese Sandwich";
            lblPack1.Visible  = true;

            lblPack2.Text = "Chicken Burger";
            lblPack2.Visible = true;

            lblPack3.Text = "Green Salad";
            lblPack3.Visible = true;

            lblPack4.Text = "Strawberry Sundae";
            lblPack4.Visible = true;

            lblPack5.Text = "Caramel Latte";
            lblPack5.Visible = true;
        }
        else if (foodtype.Equals("Lunch "))
        {
            lblPack1.Text = "Caramel Latte";
            lblPack1.Visible = true;

            lblPack2.Text = "Cream Mushroom Salad";
            lblPack2.Visible = true;

            lblPack3.Text = "Chicken Sandwich";
            lblPack3.Visible = true;

            lblPack4.Text = "Berry Blast";
            lblPack4.Visible = true;

            lblPack5.Text = " Beef Burger";
            lblPack5.Visible = true;
        }

        else  
        {
            lblPack1.Text = "Mix Sandwich";
            lblPack1.Visible = true;

            lblPack2.Text = " Mayo Salad";
            lblPack2.Visible = true;

            lblPack3.Text = "Chicken Burger";
            lblPack3.Visible = true;

            lblPack4.Text = "Lemon Ice Tea";
            lblPack4.Visible = true;

            lblPack5.Text = " ChocoSundae";
            lblPack5.Visible = true;
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
                        (user_id, sales_no, date, time, quantity,Cust_name, total_amount, delivery_id,
                                                        product_name)
                            VALUES
              (@u_id, @sales_no,@date,@time,@qty,@cust_name,@tot,@deli_id,@prd)";

        MySqlCommand cmd = new MySqlCommand(comm, con);

        cmd.Parameters.AddWithValue("u_id",txt_user_id.Text);
        cmd.Parameters.AddWithValue("sales_no", txt_sales_id.Text);
        cmd.Parameters.AddWithValue("date", DropDownDate.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("time", txt_time.Text);
        cmd.Parameters.AddWithValue("qty", txt_quantity.Text);
        cmd.Parameters.AddWithValue("cust_name", txt_cust_name.Text);
        cmd.Parameters.AddWithValue("tot", txt_total.Text);
        cmd.Parameters.AddWithValue("prd", dropdownPack.SelectedItem.ToString());
    
        con.Close();
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}