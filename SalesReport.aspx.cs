using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using William;

public partial class SalesReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    //    if (!IsPostBack)
    //    {
    //        Sales sale = new Sales();
    //        DataTable dt = sale.GetSalesData();
    //        this.GridViewSales.Visible = true;
    //        GridViewSales.AutoGenerateColumns = false;
    //        GridViewSales.DataSource = dt;
    //    }
    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Statement.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_check_Click(object sender, EventArgs e)
    {

    }
}