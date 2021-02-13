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

public partial class DeleteUser : System.Web.UI.Page
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
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateUser.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        User Deluser = new User();
        int u_Id = int.Parse(txt_user_id.Text);
        Deluser.DeleteUser(u_Id);
        Response.Write("<script>alert('Success ');</script>");
    }
}