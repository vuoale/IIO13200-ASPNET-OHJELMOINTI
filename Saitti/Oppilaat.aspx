<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppilaat.aspx.cs" Inherits="Oppilaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Oppilaat:</h2>
        <div>
            <asp:Button ID="btnGet3" runat="server" Text="Hae 3 testioppilasta" OnClick="btnGet3_Click" />
            <asp:Button ID="btnGetAll" runat="server" Text="Hae oppilaat tietokannasta" OnClick="btnGetAll_Click" />
            <asp:Button ID="btnGetFromMysli" runat="server" Text="Hae Mysql-tietokannasta" OnClick="btnGetFromMysli_Click" />
        </div>
        <div id="tulos">
            <asp:GridView id="gvStudents" runat="server" />
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
