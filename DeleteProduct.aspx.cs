using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using William;

public partial class DeleteProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Product prd = new Product();
            DataTable dt = prd.GetProductData();
            this.GridViewProducts.Visible = true;
            GridViewProducts.AutoGenerateColumns = false;
            GridViewProducts.DataSource = dt;
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddProduct.aspx");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateProduct.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Product prd = new Product();
        int pro_id = int.Parse(txt_pro_id.Text);
       
        prd.DeleteProduct(pro_id);
        Response.Write("<script>alert('Success ');</script>");
    }
}