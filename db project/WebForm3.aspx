<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="db_project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
/* Global ------------------------------------------------------ */

html {
  overflow: hidden; /*FF fix*/
  height: 100%;
  font-family: Geneva, sans-serif;
  
}

body {
  margin: 0;
  width: 100%;
  height: 100%;
  text-align: center;
  
  display: flex;
  justify-content: center;
  align-items: center;
}

p {
    margin: 0;
}


/* box ------------------------------------------------------ */

#box {
  
  font-size: 2em;
  font-weight: bold;
  -webkit-backface-visibility: hidden; /* fixes flashing */
}


/* flashlight ------------------------------------------------------ */

#flashlight {
  color: hsla(0,0%,0%,0);
  perspective: 80px;
  outline: none;
}


/* flash ------------------------------------------------------ */

#flash {
  display: inline-block;
  text-shadow: #bbb 0 0 1px, #fff 0 -1px 2px, #fff 0 -3px 2px, rgba(0,0,0,0.8) 0 30px 25px;
  transition: margin-left 0.3s cubic-bezier(0, 1, 0, 1);
}
    
#box:hover #flash {
   text-shadow: #111 0 0 1px, rgba(255,255,255,0.1) 0 1px 3px;
  margin-left: 20px;
  transition: margin-left 1s cubic-bezier(0, 0.75, 0, 1);
}


/* light ------------------------------------------------------ */

#light {
  display: inline-block;
  text-shadow: #111 0 0 1px, rgba(255,255,255,0.1) 0 1px 3px;
}

#box:hover #light {
  text-shadow: #fff 0 0 4px, #fcffbb 0 0 20px;
  transform: rotateY(-60deg);
  transition:         transform 0.3s cubic-bezier(0, 0.75, 0, 1), text-shadow 0.1s ease-out;
}
}</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <body style="background-size:100%; background-image: url('https://yourimageshare.com/ib/Gi9CsgmbDe.jpg');" >
         <body>
             <asp:Panel ID="Panel1" HorizontalAlign="Center" runat="server">
             <asp:Image ID="Image1" ImageUrl="https://www.linkpicture.com/q/rexstream-logo-png-2.png" runat="server" />
             <p style="font-family:Arial">Search <asp:TextBox BackColor="Black" ForeColor="White" ID="Username"  runat="server"></asp:TextBox></p>
             </asp:panel>
             
            <div id="box">
                 <p id="flashlight">
                   <span id="flash">RexStream </span>
                <span id="light">Originals</span>
               </p>
</div>
        </body>
        </div>
    </form>
</body>
</html>
