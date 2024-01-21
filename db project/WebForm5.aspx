<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="db_project.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <body style="background-size:100%; background-image: url('https://yourimageshare.com/ib/Gi9CsgmbDe.jpg');" >
        <div>
              <asp:Panel ID="Panel1" HorizontalAlign="Center" runat="server">
            <body style="background-size:100%; background-image: url('https://yourimageshare.com/ib/Gi9CsgmbDe.jpg');" >
                <p style="font-family:Arial">Welcome <asp:Label ID="Label1" Text="" runat="server" ></asp:Label></p>
    <p style="font-family:Arial">Search Movie<asp:TextBox ID="SearchMovie" runat="server" BackColor="Black" ForeColor="White"></asp:TextBox> <asp:Button ID="Button3" BackColor="#ee4540" runat="server" Text="Search" OnClick="smovie_click"/>
                 </p>
                <div id="first" runat="server"></div>
                <asp:GridView ID="GridView5" HorizontalAlign="Center" runat="server"></asp:GridView>
                
     <p style="font-family:Arial">Search Show<asp:TextBox ID="SearchShow"  runat="server" BackColor="Black" ForeColor="White"></asp:TextBox> <asp:Button ID="Button4" BackColor="#ee4540" runat="server" Text="Search" OnClick="sshow_click"/>
                 </p>
                <div id="Div1" runat="server"></div>
                <asp:GridView ID="GridView6" HorizontalAlign="Center" runat="server"></asp:GridView>
                
                <asp:Button ID="Cast" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="CAST" Text="Search by cast" Width="150px"  />
                
                    
                    <div id="f" runat="server"></div><asp:TextBox ID="TextBox1"  runat="server" BackColor="Black" Visible="false" ForeColor="White"></asp:TextBox>&nbsp&nbsp;<div id="l" runat="server"></div><asp:TextBox ID="TextBox2" runat="server" BackColor="Black" ForeColor="White" Visible="false"></asp:TextBox>
                  <br>
                  <asp:Button ID="Button5" runat="server" BackColor="#ee4540" OnClick="ssCast" Text="Search" Visible="false" />
                  <asp:GridView ID="GridView8" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <div id="Div2" runat="server">
                  </div>
                  <asp:GridView ID="GridView7" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:Button ID="btnSave" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="Catlogue" Text="Catalogue" Width="150px" />
                  <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:GridView ID="GridView4" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:Button ID="Button1" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="ShuffleMovie" Text="Shuffle Movie" Width="150px" />
                  <asp:GridView ID="GridView2" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:Button ID="Button2" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="ShuffleShow" Text="Shuffle TV Show" Width="150px" />
                  <asp:GridView ID="GridView3" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:Button ID="Button9" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="showgenre1" Text="Show Genre" Width="150px" />
                  <br />
                  <asp:DropDownList ID="DropDownList1" Visible="false" runat="server">
                  </asp:DropDownList>
                  <asp:Button ID="Button10" runat="server" BackColor="#ee4540" OnClick="showgenre2" Text="Go" Visible="false" />
                  <br />
                  <asp:GridView ID="GridView9" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <asp:Button ID="Button11" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="moviegenre1" Text="Movie Genre" Width="150px" />
                  <br />
                  <asp:DropDownList ID="DropDownList2" runat="server" Visible="false">
                  </asp:DropDownList>
                  <asp:Button ID="Button12" runat="server" BackColor="#ee4540" OnClick="moviegenre2" Text="Go" Visible="false" />
                  <br />
                  <asp:GridView ID="GridView10" runat="server" HorizontalAlign="Center">
                  </asp:GridView>
                  <br />
                  <asp:Button ID="Button7" runat="server" BackColor="#ee4540" BorderColor="#40192e" BorderStyle="Double" BorderWidth="5px" Font-Bold="true" Font-Size="Medium" Height="70px" OnClick="showall" Text="Create another Profile" Width="212px" />
                  <br />
                  <div id="f0" runat="server">
                  </div>
                  <asp:TextBox ID="TextBox3" runat="server" BackColor="Black" ForeColor="White" Visible="false"></asp:TextBox>
                  &nbsp;&nbsp;<div id="l0" runat="server">
                  </div>
                  <asp:TextBox ID="TextBox4" runat="server" BackColor="Black" ForeColor="White" Visible="false"></asp:TextBox>
                  <br>
                  <asp:Button ID="Button8" runat="server" BackColor="#ee4540" OnClick="newprofile" Text="Create" Visible="false" />
                  <div id="div8" runat="server">
                  </div>
                  <br />
                  <br />
                  <asp:Button ID="Button6" runat="server" BackColor="#ee4540" PostBackUrl="~/buttons.aspx" Text="Sign Out" />
                 
              </asp:Panel>
        </div>
    </form>
</body>
</html>
