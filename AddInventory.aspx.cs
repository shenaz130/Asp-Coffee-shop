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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using William;

public partial class AddInventory : System.Web.UI.Page
{
    //private SpeechSynthesizer spsynthesizer = new SpeechSynthesizer();
    //private SpeechRecognitionEngine spEngine = new SpeechRecognitionEngine();
        
    protected void Page_Load(object sender, EventArgs e)
    {
        //Inventory inv = new Inventory();
        //DataTable dt = new DataTable();
        //dt = inv.GetInvData();
        //spsynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
        //spsynthesizer.Rate = 1;//voice speed
        //spsynthesizer.Volume = 100;
        //spsynthesizer.SpeakAsync("hi, welcome to the dashboard");


        //Choices choices = new Choices();
        //string[] commands;

        //for(int i=0; i<=int.Parse(dt.Rows.ToString());i++)
        // {
        //     string qty = dt.Rows[i][2].ToString();
        //     string item = dt.Rows[i][1].ToString();
        //     if (int.Parse(qty) <= 10)
        //     {
        //         commands = new string[]{ "Alert!",item, "Going Low" };
        //         choices.Add(commands);
        //         GrammarBuilder grammerBuilder = new GrammarBuilder();
        //         grammerBuilder.Append(choices);
        //         Grammar grammer = new Grammar(grammerBuilder);

        //         spEngine.LoadGrammarAsync(grammer);
        //         spEngine.SetInputToDefaultAudioDevice();
        //         spEngine.RecognizeAsync(RecognizeMode.Multiple);

        //         spEngine.SpeechRecognized += spEngine_SpeechRecognized;//mannually adding a button
        //     }
        // }


        //if (!IsPostBack)
        //{
        //    dt = inv.GetInvData();
        //    GridViewItem.DataSource = dt;
        //}
    }

    private void spEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        throw new NotImplementedException();
    }
    protected void btn_update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateInventory.aspx");
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
    //    Inventory inv = new Inventory();
    //    int inv_Id = int.Parse(txt_item_id.Text);
    //    string inv_name = txt_item_name.Text;
    //    int inv_supid = int.Parse(txt_sup_id.Text);
    //    int qty = int.Parse(txt_quantity.Text);


    //    inv.AddItem(inv_Id,inv_name,inv_supid,qty);
    //    Response.Write("<script>alert('Success ');</script>");
    }
}