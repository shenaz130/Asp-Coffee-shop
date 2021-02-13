using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using William;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
   
    
    protected void btn_user_Click(object sender, ImageClickEventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "cashier") == 0 || String.Compare(x, "manager") == 0 || String.Compare(x, "staff") == 0)
        {
            Response.Write("<script>alert('YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!');</script>");
        }
        else
        {
            Response.Redirect("AddUsers.aspx");
        }
    }
    
    protected void btn_branch_Click1(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "cashier") == 0 || String.Compare(x, "manager") == 0 || String.Compare(x, "staff") == 0)
        {
            Response.Write("<script>alert('YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!');</script>");
        }
        else
        {
            Response.Redirect("AddBranch.aspx");
        }
    }
    protected void btn_customers_Click1(object sender, EventArgs e)
    {
            Response.Redirect("AddCustomer.aspx");
        
    }
    protected void btn_inventory_Click1(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "staff") == 0 || String.Compare(x, "ChiefManager") == 0)
        {
            Response.Write("<script>alert('YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!');</script>");
        }
        else
        {
            Response.Redirect("AddInventory.aspx");
        }
    }
   
    protected void btn_delivery_Click1(object sender, EventArgs e)
    {
            Response.Redirect("AddDelivery.aspx");
        
    }
    protected void btn_driver_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "staff") == 0 || String.Compare(x, "cashier") == 0)
        {
            Response.Write("<script>alert('YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!');</script>");
        }
        else
        {
            Response.Redirect("AddDriver.aspx");
        }
    }
    protected void btn_product_Click(object sender, EventArgs e)
    {
            Response.Redirect("AddProduct.aspx");
        
    }
    protected void btn_poss_Click(object sender, EventArgs e)
    {
        Response.Redirect("POSS.aspx");
    }
    protected void btn_statemnent_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "staff") == 0 || String.Compare(x, "cashier") == 0 || String.Compare(x, "manager") == 0)
        {
            Response.Write("<script>alert('YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!');</script>");
        }
        else
        {
            Response.Redirect("Statement.aspx");
        }
    }
}