<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title></title>
    <link rel="stylesheet" type="text/css" href="css/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="background-color: #99FF99; width: 1280px; height: 691px;">
            <div id="nav" style="background-color: #009933; height: 95px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="89px" Width="131px" ImageUrl="~/NewFolder1/Images/logo.png" />
      
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="WILLIAM'S COFFEE SHOP" Font-Names="Copperplate Gothic Light" Font-Overline="False" Font-Strikeout="False" Font-Underline="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
                <div id="menu" style="height: 461px; width: 365px; background-color: #008000; margin-left: 320px;">
                    <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <div style="height: 353px; width: 253px; margin-left: 40px; background-color: #99FF99;">
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_user_name" runat="server" Font-Names="Arial Nova Cond" Font-Size="X-Large" Text="User Name"></asp:Label>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_user_name" runat="server" BorderColor="#00CC00"></asp:TextBox>
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label11" runat="server" Font-Names="Arial Nova Cond" Font-Size="X-Large" Text="Password"></asp:Label>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txt_password" runat="server" BorderColor="#00CC00" TextMode="Password"></asp:TextBox>
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_submit" runat="server" BorderColor="#009900" Font-Bold="True" Font-Names="Arial Nova Cond" ForeColor="#006600" Height="33px" Text="SUBMIT" Width="77px" OnClick="btn_submit_Click" />
                        <br />
                        <br />
                        <br />
&nbsp;<asp:Button ID="btn_forget" runat="server" BorderColor="#009900" Font-Bold="True" Font-Names="Arial Nova Cond" ForeColor="Black" Height="25px" Text="Forget Password" Width="133px" />
&nbsp;&nbsp;
                        <asp:Button ID="btn_new" runat="server" BorderColor="#009900" Font-Bold="True" Font-Names="Arial Nova Cond" ForeColor="Black" Text="Create New" OnClick="btn_new_Click" />
&nbsp;&nbsp;
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </div>
              </div>  
   
        </div>
    
    </div>
    </form>
</body>
</html>

