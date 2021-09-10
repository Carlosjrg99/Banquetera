<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PracticaHotel.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:400px; margin:auto; margin-top:5%; border:solid; border-color: #1c1c1c; border-radius:10px">
            <asp:Login ID="login" runat="server" OnAuthenticate="Login1_Authenticate" Width="400px"></asp:Login>
        </div>
    </form>
</body>
</html>
