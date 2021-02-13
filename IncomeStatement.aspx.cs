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

public partial class NetIncome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            MySqlCommand sda = new MySqlCommand("SELECT branch_Id FROM tbl_revenue", con);
            MySqlDataReader dr;
            dr = sda.ExecuteReader();
            DropDownSearch.Items.Clear();
            while (dr.Read())
            {
                DropDownSearch.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            DropDownSearch.DataBind();
            con.Close();

        }
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_check_Click(object sender, EventArgs e)
    {
        string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);
        System.Data.DataTable dt = new System.Data.DataTable();

        try
        {
            lbl_year1.Visible = true;
            lbl_s_rev.Visible = true;
            lbl_intrest.Visible = true;
            lbl_comm.Visible = true;
            lbl_tot_rev.Visible = true;
            lbl_tot_exp1.Visible = true;
            lbl_net_income.Visible = true;

            lbl_year1.Text = dt.Rows[0][8].ToString();
            lbl_s_rev.Text = dt.Rows[0][2].ToString();
            lbl_intrest.Text = dt.Rows[0][3].ToString();
            lbl_comm.Text = dt.Rows[0][4].ToString();
            lbl_tot_rev.Text = dt.Rows[0][5].ToString();
            lbl_tot_exp1.Text = dt.Rows[0][6].ToString();
            lbl_net_income.Text = dt.Rows[0][7].ToString();
           
        }
        catch (Exception ex)
        {
            lbl_year1.Visible = false;
            lbl_s_rev.Visible = false;
            lbl_intrest.Visible = false;
            lbl_comm.Visible = false;
            lbl_tot_rev.Visible = false;
            lbl_tot_exp1.Visible = false;
            lbl_net_income.Visible = false;

            return;

        }
        con.Close();

    }

    protected void btn_clear_Click(object sender, EventArgs e)
    {
        lbl_year1.Visible = false;
        lbl_s_rev.Visible = false;
        lbl_intrest.Visible = false;
        lbl_comm.Visible = false;
        lbl_tot_rev.Visible = false;
        lbl_tot_exp1.Visible = false;
        lbl_net_income.Visible = false;
    }
}