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

public partial class NetProfit : System.Web.UI.Page
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
            MySqlCommand sda = new MySqlCommand("SELECT branch_Id FROM tbl_NetProfit", con);
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
            lbl_rev1.Visible = true;
            lbl_p_cost1.Visible = true;
            lbl_g_profit1.Visible = true;

            lbl_adv_cost.Visible = true;
            lbl_travl_cost.Visible = true;
            lbl_rent.Visible = true;
            lbl_met_cost.Visible = true;
            lbl_utility_cost.Visible = true;
            lbl_discount.Visible = true;
            lbl_tot_exp.Visible = true;

            lbl_profit.Visible = true;
            lbl_tot_exp1.Visible = true;
            lbl_tax.Visible = true;
            lbl_intrest.Visible = true;
            lbl_net_profit.Visible = true;



            lbl_year1.Text = dt.Rows[0][2].ToString();
            lbl_rev1.Text = dt.Rows[0][3].ToString();
            lbl_p_cost1.Text = dt.Rows[0][4].ToString();
            lbl_g_profit1.Text = dt.Rows[0][5].ToString();
            

            lbl_adv_cost.Text = dt.Rows[0][6].ToString();
            lbl_travl_cost.Text = dt.Rows[0][7].ToString();
            lbl_rent.Text = dt.Rows[0][8].ToString();
            lbl_met_cost.Text = dt.Rows[0][9].ToString();
            lbl_utility_cost.Text = dt.Rows[0][10].ToString();
            lbl_discount.Text = dt.Rows[0][13].ToString();
            lbl_tot_exp.Text = dt.Rows[0][14].ToString();

            lbl_profit.Text = dt.Rows[0][5].ToString();
            lbl_tot_exp1.Text = dt.Rows[0][14].ToString();
            lbl_tax.Text = dt.Rows[0][11].ToString();
            lbl_intrest.Text = dt.Rows[0][12].ToString();
            lbl_net_profit.Text = dt.Rows[0][15].ToString();

        }
        catch (Exception ex)
        {
            lbl_year1.Visible = false;
            lbl_rev1.Visible = false;
            lbl_p_cost1.Visible = false;
            lbl_g_profit1.Visible = false;

            lbl_adv_cost.Visible = false;
            lbl_travl_cost.Visible = false;
            lbl_rent.Visible = false;
            lbl_met_cost.Visible = false;
            lbl_utility_cost.Visible = false;
            lbl_discount.Visible = false;
            lbl_tot_exp.Visible = false;

            lbl_profit.Visible = false;
            lbl_tot_exp1.Visible = false;
            lbl_tax.Visible = false;
            lbl_intrest.Visible = false;
            lbl_net_profit.Visible = false;


            return;

        }
        con.Close();
    }
    protected void btn_clear_Click(object sender, EventArgs e)
    {
        lbl_year1.Visible = false;
        lbl_rev1.Visible = false;
        lbl_p_cost1.Visible = false;
        lbl_g_profit1.Visible = false;

        lbl_adv_cost.Visible = false;
        lbl_travl_cost.Visible = false;
        lbl_rent.Visible = false;
        lbl_met_cost.Visible = false;
        lbl_utility_cost.Visible = false;
        lbl_discount.Visible = false;
        lbl_tot_exp.Visible = false;

        lbl_profit.Visible = false;
        lbl_tot_exp1.Visible = false;
        lbl_tax.Visible = false;
        lbl_intrest.Visible = false;
        lbl_net_profit.Visible = false;

    }
}