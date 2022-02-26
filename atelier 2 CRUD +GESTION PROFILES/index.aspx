<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="atelier_2_CRUD__GESTION_PROFILES.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>vuiellez remplir les information </h1>
            lolgin :<asp:TextBox ID="loginTX" runat="server" style="margin-left: 32px" Width="288px"></asp:TextBox><br /><br />
            password :<asp:TextBox ID="passTX" runat="server" Width="288px"></asp:TextBox><br /><br />
            <asp:Button ID="connect" runat="server" Text="connect" Height="25px" Width="106px" OnClick="connect_Click" />
            <asp:Button ID="createACC" runat="server" Text="create account" style="margin-left: 186px" OnClick="createACC_Click" />

        </div>
    </form>
</body>
</html>
