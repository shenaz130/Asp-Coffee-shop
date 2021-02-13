using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using William;

public partial class AddCustomer : System.Web.UI.Page
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
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Customer Addcust = new Customer();
        int custId= int.Parse(txt_cust_id.Text);
        string cust_name = txt_cust_name.Text;
        int cust_contact = int.Parse(txt_contact.Text);
        string cust_add= txt_cust_add.Text;
        Addcust.AddCustomer(custId,cust_name,cust_contact,cust_add);
        Response.Write("<script>alert('Success ');</script>");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateCustomer.aspx");
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteCustomer.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");

    }
    protected void btn_add_Click1(object sender, EventArgs e)
    {

    }
}