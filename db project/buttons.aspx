<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buttons.aspx.cs" Inherits="db_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <body style="background-size:100%; background-image: url('https://yourimageshare.com/ib/Gi9CsgmbDe.jpg');" >
       </body>
            <asp:Panel ID="Panel1" HorizontalAlign="Center" runat="server">
                 <asp:Image ID="Image1" height="400px" Width="940px" ImageUrl="https://yourimageshare.com/ib/PNg8E8wo3E.gif" runat="server" />
                </br>
                <asp:Button ID="Button1" PostBackUrl="~/Login.aspx" Height="80px" Width="130px" Font-Bold="true" BorderColor="#40192e" BorderWidth="5px"  BorderStyle="Double" BackColor="#ee4540" Font-Size="Large"  runat="server" Text="Log in" />
                </br>
                </br>
                </br>
                 <asp:Button ID="Button2" Height="110px"  Width="130px" Font-Bold="true" BorderColor="#40192e" PostBackUrl="~/sign up.aspx" BorderWidth="5px"  BorderStyle="Double" BackColor="#ee4540" Font-Size="Large"  runat="server" Text="Sign Up" />
                </asp:Panel>
                </div>
    </form>
</body>
</html>
