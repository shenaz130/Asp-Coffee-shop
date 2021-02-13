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

public partial class DeleteDriver : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Driver view_drv = new Driver();
            DataTable dt = view_drv.GetDriverData();
            GridViewDrivers.DataSource = dt;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddDriver.aspx");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateDriver.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Driver Deletedrv = new Driver();
        int drv_Id = int.Parse(txt_drv_id.Text);
        Deletedrv.DeleteDriverDriver(drv_Id);
        Response.Write("<script>alert('Success ');</script>");
    }
}