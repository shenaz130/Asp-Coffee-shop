using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using William;

public partial class DeleteInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    Inventory inv = new Inventory();
        //    DataTable dt = new DataTable();
        //    dt = inv.GetInvData();
        //    GridViewItem.DataSource = dt;
        //}
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddInventory.aspx");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateInventory.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {

        //Inventory inv = new Inventory();
        //int inv_Id = int.Parse(txt_item_id.Text);
        //Inventory.DeleteInv(inv_Id);
        //Response.Write("<script>alert('Success ');</script>");
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {

    }
}