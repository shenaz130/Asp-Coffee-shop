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

public partial class DeleteCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Customer Viewcust = new Customer();
            DataTable dt = Viewcust.GetCustomerData();
            GridViewCustomer.DataSource = dt;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddCustomer.aspx");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateBranch.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Customer Deletecust = new Customer();
        int custId = int.Parse(txt_cust_id.Text);
        Deletecust.DeleteCustomer(custId);
        Response.Write("<script>alert('Success ');</script>");
    }
}