<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lotto.aspx.cs" Inherits="Lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lotto</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Loton tyyppi:</h3>
        <asp:DropDownList ID="ddTyyppi" runat="server">
                <asp:ListItem Value="suomi">Suomi</asp:ListItem>
                <asp:ListItem Value="viking">Viking</asp:ListItem>
        </asp:DropDownList>
        <h3>Rivien lkm:</h3>
        <asp:TextBox runat="server" ID="txtLkmRivit"></asp:TextBox>
        <p>
            <asp:Button runat="server" ID="btnArvo" Text="Arvo" OnClick="btnArvo_Click" />
        </p>
        <hr />
        <div runat="server" id="divRivit">Arvotut rivit tulevat tähän...</div>
    </div>
    </form>
</body>
</html>
