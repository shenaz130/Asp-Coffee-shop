using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using William;

public partial class Statement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_gross_profit_Click(object sender, EventArgs e)
    {
        Response.Redirect("GrossProfit.aspx");
    }
    protected void btn_net_profit_Click(object sender, EventArgs e)
    {
        Response.Redirect("NetProfit.aspx");
    }
    protected void btn_income_Click(object sender, EventArgs e)
    {
        Response.Redirect("IncomeStatement.aspx");
    }
}