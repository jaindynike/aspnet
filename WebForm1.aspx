<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ASPLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-ui-1.10.2.min.js"></script>
    <link href="style.css" rel="stylesheet" />
   


</head>
<body>
    <form id="form1" runat="server">
        <div id="p1">
            Username:
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
        </div>
        <p>
            Password:
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="messagelbl" runat="server" Enabled="False" Visible="False"></asp:Label>
        <p >
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </p>
    </form>
</body>
</html>

    <script src="script.js" type="text/javascript"></script>


