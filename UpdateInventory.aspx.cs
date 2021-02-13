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


public partial class UpdateInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    Inventory inv = new Inventory();
        //    DataTable dt = inv.GetInvData();
        //    GridViewItem.DataSource = dt;
        //}
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddInventory.aspx");

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteInventory.aspx");

    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        //Inventory inv = new Inventory();
        //int inv_Id = int.Parse(txt_item_id.Text);
        //string inv_name = txt_item_name.Text;
        //int inv_supid = int.Parse(txt_sup_id.Text);
        //string price = txt_unit_price.Text;
        //int qty = int.Parse(txt_quantity.Text);


        //inv.UpdateInv(inv_Id, inv_name, inv_supid, price, qty);
        //Response.Write("<script>alert('Success ');</script>");
    }
}