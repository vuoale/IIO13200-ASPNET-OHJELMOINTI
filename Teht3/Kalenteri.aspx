<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalenteri.aspx.cs" Inherits="Kalenteri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kalenteri</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Valitse päivä:</h3>
        <asp:Button ID="btnEdellinen" runat="server" Text="< vuosi" OnClick="btnEdellinen_Click"></asp:Button>                
        <asp:Button ID="btnSeuraava" runat="server" Text="vuosi >" OnClick="btnSeuraava_Click"></asp:Button><br />
        <asp:Calendar ID="kalenteri" runat="server" SelectionMode="Day" OnSelectionChanged="kalenteri_SelectionChanged"></asp:Calendar><br />
        <asp:Label runat="server" ID="lblPvm"></asp:Label><br />
        <asp:Label runat="server" ID="lblValittu"></asp:Label><br />
        <asp:Label runat="server" ID="lblErotus"></asp:Label>
    </div>
    </form>
</body>
</html>
