<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 830px; width: 1277px">
    <form id="form1" runat="server">
        <div style="background-color: #99FF99; width: 1280px; height: 873px;">
            <div id="nav" style="background-color: #009933; height: 87px;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="HOMEPAGE"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="82px" ImageUrl="~/NewFolder1/Images/logo.png" Width="126px" />
      
                &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="WILLIAM'S COFFEE SHOP" Font-Names="Copperplate Gothic Light" Font-Overline="False" Font-Strikeout="False" Font-Underline="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="btn_user" runat="server" Height="40px" ImageUrl="~/NewFolder1/New folder (2)/users.jpg" Width="49px" OnClick="btn_user_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButtonHome" runat="server" Height="37px" ImageUrl="~/NewFolder1/New folder (2)/home button'.png" Width="44px" OnClick="ImageButtonHome_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
                <div id="menu" style="height: 711px; width: 303px; background-color: #008000;">
                    &nbsp;&nbsp;&nbsp;
                    <br />
                      &nbsp;
                    <asp:Button ID="btn_poss" runat="server" BackColor="#99FF99" Font-Size="Large" Height="51px" Text="POSS" Width="264px" OnClick="btn_poss_Click" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;
                    <asp:Button ID="btn_product" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="PRODUCT" Width="261px" OnClick="btn_product_Click" />
                    <br />
                    <br />
&nbsp;
                    <asp:Button ID="btn_branch" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="BRANCH" Width="261px" OnClick="btn_branch_Click1" />
                    <br />
                    <br />
&nbsp;
                    <asp:Button ID="btn_customers" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="CUSTOMERS" Width="261px" OnClick="btn_customers_Click1" />
                    <br />
                    <br />
&nbsp;
                    <asp:Button ID="btn_delivery" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="DELIVERY" Width="261px" OnClick="btn_delivery_Click1" />
                    <br />
                    <br />
&nbsp;
                    <asp:Button ID="btn_driver" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="DRIVERS" Width="261px" OnClick="btn_driver_Click" />
                    <br />
                    <br />
&nbsp;
                    <asp:Button ID="btn_inventory" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="iNVENTORY" Width="261px" OnClick="btn_inventory_Click1" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_statemnent" runat="server" BackColor="#99FF99" Font-Size="Large" Height="62px" Text="STATEMENTS" Width="261px" style="margin-left: 10px" OnClick="btn_statemnent_Click" />
                </div>
              </div>  
   
            <div style="width: 783px; height: 437px; margin-left: 320px; background-color: #FFFFFF;">
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <img alt="" border="1" src="NewFolder1/Images/logo/images.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" src="NewFolder1/New%20folder%20(2)/inventory.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" src="NewFolder1/New%20folder%20(2)/branches.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img alt="" src="NewFolder1/New%20folder%20(2)/statements.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="POSS"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Inventory"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Branches"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Statements"></asp:Label>
                <br />
                &nbsp;
                <br />
                &nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" src="NewFolder1/New%20folder%20(2)/delivery.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" src="NewFolder1/New%20folder%20(2)/customers.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" src="NewFolder1/New%20folder%20(2)/settings.png" style="border-color: #008000;border-radius:25px; height: 123px; width: 146px" border="1" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Delivery"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Customers"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Font-Size="Larger" Font-Strikeout="False" Font-Underline="True" Text="Settings"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </div>
   
        </div>
    </form>
</body>
</html>