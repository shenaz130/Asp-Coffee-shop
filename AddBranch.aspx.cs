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



public partial class AddBranch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    //    if (!IsPostBack)
    //    {
    //        Branch br = new Branch();
    //        DataTable dt = br.GetBranchData();
    //        this.GridViewBranch.Visible = true;
    //        GridViewBranch.AutoGenerateColumns = false;
    //        GridViewBranch.DataSource = dt;
    //    }
    }

    protected void btn_add_Click(object sender, EventArgs e)
    {

    }


    protected void btn_ok_Click(object sender, EventArgs e)
    {
        Branch addbr = new Branch();
        int bid = int.Parse(txt_br_id.Text);
        string bname = txt_br_name.Text;
        addbr.AddBranch(bid,bname);
        Response.Write("<script>alert('Success ');</script>");
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateBranch.aspx");
    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteBranch.aspx");
    }
    protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");

    }
   
}