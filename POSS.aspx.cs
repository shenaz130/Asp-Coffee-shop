using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using William;

public partial class POSS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_packages_Click(object sender, EventArgs e)
    {
        Response.Redirect("packages.aspx");
    }
    protected void btn_main_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainMenu.aspx");
    }
}