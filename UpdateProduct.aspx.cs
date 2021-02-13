using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using William;
public partial class UpdateProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Product prd = new Product();
        DataTable dt = prd.GetProductData();
        this.GridViewProducts.Visible = true;
        GridViewProducts.AutoGenerateColumns = false;
        GridViewProducts.DataSource = dt;
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddProduct.aspx");

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteProduct.aspx");

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Product prd = new Product();
        int pro_id = int.Parse(txt_pro_id.Text);
        string pro_name = txt_pro_name.Text;
        int price = int.Parse(txt_pro_price.Text);
        int supid = int.Parse(txt_sup_id.Text);
        int qty = int.Parse(txt_quantity.Text);
        string type = DropDownType.SelectedItem.ToString();


        prd.UpdateProduct(pro_id, pro_name, price, supid, qty, type);
        Response.Write("<script>alert('Success ');</script>");
    }
}