<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="db_project.WebForm1" %>

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
                 <br>
                 <br>
                 <br></br>
                 <br>
                 <p style="font-family:Arial">
                     Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="Username" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                 </p>
                 <p style="font-family:Arial">
                     Password
                     <asp:TextBox ID="Password" runat="server" BackColor="Black" ForeColor="White" TextMode="password"></asp:TextBox>
                 </p>
                 <br></br>
                 <asp:Button ID="Button1" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="Login_Button_Click" Text="Log in" Width="100px" />
                 <div id="message" runat="server">
                 </div>
                 <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
                 </asp:GridView>
                 <div id="p" runat="server">
                 </div>
                 <%-- <asp:TextBox ID="pid" BackColor="Black" ForeColor="White" runat="server" Visible="false" ></asp:TextBox>--%>
                 <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#ee4540" ForeColor="White" Height="55px" Visible="false" Width="101px">
                 </asp:DropDownList>
                 <div id="p2" runat="server">
                 </div>
                 <asp:TextBox ID="Password2" runat="server" BackColor="Black" ForeColor="White" TextMode="password" Visible="false"></asp:TextBox>
                 <asp:Button ID="Button2" runat="server" BackColor="#ee4540" BorderColor="#40192e" OnClick="Plogin_button" Text="Login" Visible="false" Width="87px" />
                 <asp:GridView ID="GridView2" runat="server" HorizontalAlign="Center">
                 </asp:GridView>
                 <asp:GridView ID="GridView3" runat="server" HorizontalAlign="Center">
                 </asp:GridView>
                 <asp:Button ID="Button3" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" PostBackUrl="~/WebForm5.aspx" Text="Next&gt;" Visible="false" Width="100px" />
                 <br>
                 <br></br>
                 <br>
                 <br></br>
                 <br></br>
                 <br></br>
                 <br></br>
                 </br>
                 </br>
                 </br>
                 </br>
                </br>
                
            </asp:Panel>

        </div>
    </form>
</body>
</html>
