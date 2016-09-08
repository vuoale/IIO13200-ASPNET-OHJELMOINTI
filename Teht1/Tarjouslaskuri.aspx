<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tarjouslaskuri.aspx.cs" Inherits="Tarjouslaskuri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- ikkunan leveys -->
        <p>Ikkunan leveys:
        <asp:TextBox ID="txtIkkunaLeveys" runat="server"></asp:TextBox>
        </p>

        <!-- ikkunan korkeus -->
        <p>Ikkunan korkeus:
        <asp:TextBox ID="txtIkkunaKorkeus" runat="server"></asp:TextBox>
        </p>

        <!-- karmipuun leveys -->
        <p>Karmipuun leveys:
        <asp:TextBox ID="txtKarmiLeveys" runat="server"></asp:TextBox>
        </p>

        <p>
        <asp:Button ID="btnLaske" runat="server" Text="Laske tarjoushinta" OnClick="btnLaske_Click" />
        </p>

        <p>Ikkunan pinta-ala:
        <asp:Label ID="lblAla" runat="server" Text="tulos1"/>
        </p>

        <p>Karmin piiri:
        <asp:Label ID="lblKarmi" runat="server" Text="tulos2"/>
        </p>

        <p>Tarjoushinta
        <asp:Label ID="lblHinta" runat="server" Text="tulos3"/>
        </p>
    </div>
    </form>
</body>
</html>
