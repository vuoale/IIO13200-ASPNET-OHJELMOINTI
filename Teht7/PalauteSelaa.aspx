<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PalauteSelaa.aspx.cs" Inherits="PalauteSelaa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selaa palautteita</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Selaa palautteita</h2>
        <asp:Button ID="btnLoadXML" runat="server" Text="Hae XML" OnClick="btnLoadXML_Click" />
        <asp:Button ID="btnLoadSQL" runat="server" Text="Hae SQL" OnClick="btnLoadSQL_Click" />
        <asp:GridView ID="gvFeedback" runat="server" />
        <asp:Label ID="lbMessages" runat="server" />
        <br /><br />
        <a href="Palaute.aspx">Anna palautetta</a>
    </div>
    </form>
</body>
</html>
