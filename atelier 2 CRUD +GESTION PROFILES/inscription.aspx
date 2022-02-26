<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscription.aspx.cs" Inherits="atelier_2_CRUD__GESTION_PROFILES.inscription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 login <asp:TextBox ID="logTX" runat="server"></asp:TextBox><br /><br />
 mot de passe <asp:TextBox ID="MpassTX" runat="server"></asp:TextBox><br /><br />
 confirmation du mot de passe  <asp:TextBox ID="CMpassTX" runat="server"></asp:TextBox><br /><br />
 e-mail <asp:TextBox ID="emailTX" runat="server"></asp:TextBox><br /><br />
 nom <asp:TextBox ID="nomTX" runat="server"></asp:TextBox><br /><br />
 date de naissance<asp:TextBox ID="dateTX" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="inscrire" runat="server" Text="inscrire" OnClick="inscrire_Click" />

        </div>
    </form>
</body>
</html>
