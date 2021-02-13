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
public partial class UpdateDelivery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Delivery ViewDeli = new Delivery();
            DataTable dt = ViewDeli.GetDriverData();
            GridViewDelivery.DataSource = dt;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddDelivery.aspx");

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteDelivery.aspx");

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Delivery Updatedeli = new Delivery();
        int deliId = int.Parse(txt_del_id.Text);
        string date = txt_date.Text;
        string time = txt_time.Text;
        string location = txt_location.Text;
        int salesId = int.Parse(txt_sales_id.Text);
        int branchId = int.Parse(txt_br_id.Text);
        int driverId = int.Parse(txt_dr_id.Text);

        Updatedeli.UpdateDelivery(deliId, date, time, location, salesId, branchId, driverId);
        Response.Write("<script>alert('Success ');</script>");
    }
}