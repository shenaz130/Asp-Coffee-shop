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
using William;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string connetionString = null;
        MySqlConnection con;
        connetionString = "server=localhost;database=coffeedb;Uid=root;Pwd=;";
        con = new MySqlConnection(connetionString);

        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT privilage FROM user WHERE user_name='" + txt_user_name.Text + "' AND password='" + txt_password.Text + "'", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        try
        {
            Session["Privilage"] = dt.Rows[0][0].ToString();
            Response.Redirect("Home.aspx");
        }
        catch (IndexOutOfRangeException ex)
        {
            Response.Write("<script>alert('Invalid username or password');</script>");
           
        }
        con.Close();
       

    }
    protected void btn_new_Click(object sender, EventArgs e)
    {

    }
    protected void lbl_user_id_TextChanged(object sender, EventArgs e)
    {

    }
}