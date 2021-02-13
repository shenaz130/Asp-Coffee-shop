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

public partial class DeleteDelivery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Delivery delivery = new Delivery();
            DataTable dt = delivery.GetDriverData();
            GridViewDelivery.DataSource = dt;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddDelivery.aspx");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateDelivery.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Delivery Deletedeli = new Delivery();
        int deliId = int.Parse(txt_deli_id.Text);
        Deletedeli.DeleteDelivery(deliId);
        Response.Write("<script>alert('Success ');</script>");
    }
}