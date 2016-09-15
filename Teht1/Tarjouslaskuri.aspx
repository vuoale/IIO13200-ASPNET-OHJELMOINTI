<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tarjouslaskuri.aspx.cs" Inherits="Tarjouslaskuri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teht1</title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="w3-container w3-light-green">
        <h2>Ikkunan dimensiot</h2>
        <table>
            <tr>
                <td>Ikkunan leveys:</td>
                <td>
                    <asp:TextBox ID="txtIkkunaLeveys" runat="server"></asp:TextBox>
                </td>
                <td> mm</td>
            </tr>
            <tr>
                <td>Ikkunan korkeus:</td>
                <td>
                    <asp:TextBox ID="txtIkkunaKorkeus" runat="server"></asp:TextBox>
                </td>
                <td> mm</td>
            </tr>
            <tr>
                <td>Karmipuun leveys:</td>
                <td>
                    <asp:TextBox ID="txtKarmiLeveys" runat="server"></asp:TextBox>
                </td>
                <td> mm</td>
            </tr>
        </table>
        <asp:Button ID="btnLaske" class="w3-btn w3-blue" runat="server" Text="Laske tarjoushinta" OnClick="btnLaske_Click" />
        <table>
            <tr>
                <td>Ikkunan pinta-ala</td>
                <td>
                    <asp:Label ID="lblAla" runat="server" Text=""/>
                </td>
                <td> m2</td>
            </tr>
            <tr>
                <td>Karmin piiri</td>
                <td>
                    <asp:Label ID="lblKarmi" runat="server" Text=""/>
                </td>
                <td> m</td>
            </tr>
            <tr>
                <td>Tarjoushinta</td>
                <td>
                    <asp:Label ID="lblHinta" runat="server" Text=""/>
                </td>
                <td> €</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
