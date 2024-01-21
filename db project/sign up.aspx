<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign up.aspx.cs" Inherits="db_project.sign_up" %>

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
            
            <asp:Panel runat="server"  ID="Panel2" HorizontalAlign="Center">
               

                <%--<asp:Image ID="Logo"  ImageUrl="https://yourimageshare.com/ib/YdMCqxkXsQ.png" runat="server" />--%>
                 <asp:Image ID="Image1" height="400px" Width="940px" ImageUrl="https://yourimageshare.com/ib/PNg8E8wo3E.gif" runat="server" />
                <br>
                <br></br>
                <h style="font-size:40px;">
                    Sign Up</h>
                <p style="font-family:Arial">
                    First Name
                    <asp:TextBox ID="FirstName" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <p style="font-family:Arial">
                    Last Name
                    <asp:TextBox ID="LastName" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <p style="font-family:Arial">
                    Email &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="Email" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <p style="font-size:13px;font-family:Arial">
                    Backup Email
                    <asp:TextBox ID="BackupEmail" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <p style="font-family:Arial">
                    Username
                    <asp:TextBox ID="Username" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <p style="font-family:Arial">
                    Create Password</p>
                <asp:TextBox ID="Password" runat="server" BackColor="Black" ForeColor="White" ></asp:TextBox>
                <p style="font-family:Arial">
                    Confirm Password</p>
                <asp:TextBox ID="ConfirmPassword" runat="server" BackColor="Black" ForeColor="White" ></asp:TextBox>
                <br>
                <br></br>
                <p style="font-family:Arial">
                    Phone
                    <asp:TextBox ID="phone" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                    &nbsp; Credit/Debit
                    <asp:TextBox ID="card" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                </p>
                <br>
                <asp:Button ID="Button6" runat="server" BackColor="#ee4540" OnClick="Plan" Text="Choose a plan" />
                <br></br>
                <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
                </asp:GridView>
                <asp:DropDownList ID="DropDownList1" runat="server" Visible="false">
                </asp:DropDownList>
                <br>
                <br />
                <p>
                    Create atleast 1 profile</p>
                <asp:TextBox ID="TextBox3" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                <p>
                    Password</p>
                <asp:TextBox ID="TextBox4" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox>
                <br>
                <div id="div8" runat="server">
                </div>
                <br></br>
                <asp:Button ID="Button1" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Large" Height="80px" onClick="Signup_Click" Text="Sign Up" Width="130px" />
                <br />
                <br />
                <asp:Button ID="Button5" runat="server" BackColor="#ee4540" PostBackUrl="~/Login.aspx" Text="already have an account" />
                <div id="s1" runat="server">
                </div>
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

