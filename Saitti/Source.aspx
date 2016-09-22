<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedon välitys demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Source -sivu</h1>
        <p>
            Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
            <!-- tässä valmis lista josta voi valita sopivan valmiin lauseen -->
            <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <!-- tapa 1: QueryString -->
            <asp:Button ID="btnQueryString" 
                runat="server" Text="Käytä QueryString"
                OnClick="btnQueryString_Click" /><br />
            <!-- tapa 2: HttpPost -->
            <asp:Button ID="btnHttpPost" 
                runat="server" Text="Käytä HttpPost"
                PostBackUrl="~/Tapa2.aspx" /><br />
            <!-- tapa 3: Session -->
            <asp:Button ID="btnSession" 
                runat="server" Text="Käytä Session"
                OnClick="btnSession_Click" /><br />
            <!-- tapa 4: Cookie -->
            <asp:Button ID="btnCookie" 
                runat="server" Text="Käytä Cookie"
                OnClick="btnCookie_Click" /><br />
            <!-- tapa 5: Public Property -->
            <asp:Button ID="btnProperty" 
                runat="server" Text="Käytä ominaisuutta (Public Property)"
                OnClick="btnProperty_Click" /><br />
        </p>
    </div>
    </form>
</body>
</html>
