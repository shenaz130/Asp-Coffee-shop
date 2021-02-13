<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Statement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/StyleSheet.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div style="background-color: #99FF99; width: 1346px; height: 866px;">
            <div id="nav" style="background-color: #009933; height: 124px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Finacial  Statements" Font-Names="Lucida Handwriting" Font-Overline="True" Font-Underline="True" ForeColor="White" Height="51px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Image ID="ImageLogo" runat="server" Height="100px" ImageUrl="~/NewFolder1/Images/logo.png" Width="153px" />
      
                &nbsp;&nbsp;&nbsp;<asp:Label ID="lbl_ShopName" runat="server" Font-Size="XX-Large" Text="WILLIAM'S COFFEE SHOP" Font-Names="Mistral" Font-Overline="False" Font-Strikeout="False" Font-Underline="True" ForeColor="White" Height="100px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButtonOption" runat="server" Height="51px" ImageUrl="~/NewFolder1/New folder (2)/options button.png" Width="64px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButtonHome" runat="server" Height="48px" ImageUrl="~/NewFolder1/New folder (2)/home button'.png" Width="61px" OnClick="ImageButtonHome_Click" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <div class="view" style="background-color:#66FF66; height: 603px; margin-left: 40px; width: 434px;" id="view">
                       
                       
                       <asp:Button ID="btn_gross_profit" runat="server" Height="58px" Text="GROSS PROFIT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" OnClick="btn_gross_profit_Click" />
                       <br />
                       <br />
 
                       <br />
                       
                       
                       <asp:Button ID="btn_net_profit" runat="server" Height="58px" Text="NET PROFIT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" OnClick="btn_net_profit_Click" />
                       <br />
                       <br />
                       <br />
                       
                       
                       <asp:Button ID="btn_income" runat="server" Height="58px" Text="INCOME STATEMENT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" OnClick="btn_income_Click" />
                       <br />
                       <br />
                       <br />
                       
                       
                       <asp:Button ID="btn_sales" runat="server" Height="58px" Text="SALES REPORT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" />
 
                       <br />
                       <br />
                       <br />
                       
                       
                       <asp:Button ID="btn_inv" runat="server" Height="58px" Text="INVENTORY REPORT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" />
 
                       <br />
                       <br />
                       <br />
                       
                       
                       <asp:Button ID="btn_delivery" runat="server" Height="58px" Text="DELIVERY REPORT" Width="371px" BackColor="#009900" Font-Names="Centaur" Font-Size="Large" ForeColor="White" Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="False" />
 
</div>
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                <%--  <div id="container" style="height: 504px; width: 1102px; margin-left: 40px">--%>
                </div>
            <br />
            <%--</div>--%>
              <div class="container" id="container" style="background-color: #99FF99; height: 825px; width: 1293px;">
                   <br />
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="350px" ImageUrl="~/NewFolder1/Images/logo/Financial-Background-Validations328.jpg" Width="490px" />
 
            </div>
    
    </form>
</body>
</html>
