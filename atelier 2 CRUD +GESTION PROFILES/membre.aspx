<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="membre.aspx.cs" Inherits="atelier_2_CRUD__GESTION_PROFILES.membre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="jquery-3.5.1.min.js"></script>
    <title></title>
  
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-left: 388px">
                <Columns>
                    <asp:BoundField DataField="loginn" HeaderText="login" />
                    <asp:BoundField DataField="motpass" HeaderText="motpass" />
                    <asp:BoundField DataField="Cmotpass" HeaderText="Cmotpass" />
                    <asp:BoundField DataField="email" HeaderText="email" />
                    <asp:BoundField DataField="nom" HeaderText="nom" />
                    <asp:BoundField DataField="dateNaissance" HeaderText="datenaissance" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Atelier2ConnectionString %>" SelectCommand="SELECT * FROM [Membres]"></asp:SqlDataSource><br /><br />
            <br /><br />
            <asp:Button ID="Button2" runat="server" Text="editer" OnClick="Button2_Click" Width="254px" />
            <div id="divedi" runat="server">
                  login <asp:TextBox ID="logTX" runat="server" style="margin-left: 270px"></asp:TextBox><br /><br />
 mot de passe <asp:TextBox ID="MpassTX" runat="server" style="margin-left: 190px"></asp:TextBox><br /><br />
 confirmation du mot de passe  <asp:TextBox ID="CMpassTX" runat="server" style="margin-left: 33px"></asp:TextBox><br /><br />
 e-mail <asp:TextBox ID="emailTX" runat="server" style="margin-left: 256px"></asp:TextBox><br /><br />
 nom <asp:TextBox ID="nomTX" runat="server" style="margin-left: 273px"></asp:TextBox><br /><br />
 date de naissance<asp:TextBox ID="dateTX" runat="server" style="margin-left: 155px"></asp:TextBox><br /><br />
            <asp:Button ID="Ajouter" runat="server" Text="Ajouter" Width="178px" OnClick="Ajouter_Click" />
            <asp:Button ID="modifier" runat="server" Text="modifier" style="margin-left: 36px" Width="199px" OnClick="modifier_Click" />
            <asp:Button ID="supprimer" runat="server" Text="supprimer" style="margin-left: 63px" Width="211px" OnClick="supprimer_Click" /><br /><br />
            
            </div>
          <asp:Button ID="Button1" runat="server" Text="se deconnecter" OnClick="Button1_Click" style="margin-left: 1037px" />

        </div>
    </form>
</body>
</html>
