<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Junat.aspx.cs" Inherits="Junat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Junat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="lbAsemat" runat="server"></asp:DropDownList>
        <asp:Button ID="btnHae" Text="Hae lähtevät junat" runat="server" OnClick="btnHae_Click" />
        <asp:GridView ID="gvJunat" runat="server"></asp:GridView>
        <asp:Label ID="lblMessages" runat="server" />
    </div>
    </form>
</body>
</html>
