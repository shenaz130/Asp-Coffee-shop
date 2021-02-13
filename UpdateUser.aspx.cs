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


public partial class UpdateUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User ur = new User();
        DataTable dt = ur.GetUsersdata();
        GridViewUsers.DataSource = dt;
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddUser.aspx");

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteUser.aspx");

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        User Upduser = new User();
        int u_Id = int.Parse(txt_user_id.Text);
        string u_name = txt_user_name.Text;
        int u_brid = int.Parse(txt_br_id.Text);
        string privillage = DropDownPrivilage.SelectedItem.ToString();
        string password = txt_password.Text;



        Upduser.UpdateUser(u_Id, u_name, u_brid, privillage, password);
        Response.Write("<script>alert('Success ');</script>");
    }
}