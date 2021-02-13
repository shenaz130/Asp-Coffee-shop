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

public partial class AddDriver : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Driver view_drv = new Driver();
            DataTable dt = view_drv.GetDriverData();
            GridViewDriver.DataSource = dt;
        }
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Driver Addddrv = new Driver();
        int drv_Id = int.Parse(txt_drv_id.Text);
        string drv_name = txt_drv_name.Text;
        int drv_contact = int.Parse(txt_contact.Text);
        string drv_nic = txt_nic.Text;
        int drv_lic = int.Parse(txt_lic.Text);
        

        Addddrv.AddDriver(drv_Id,drv_name,drv_contact,drv_nic,drv_lic);
        Response.Write("<script>alert('Success ');</script>");
    }

    
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateDriver.aspx");
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteDriver.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}