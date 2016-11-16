<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LuoAsiakas.aspx.cs" Inherits="LuoAsiakas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Luo Asiakas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Tunnus:<br /><asp:TextBox runat="server" ID="txtTunnus" /><br />
        Nimi:<br /><asp:TextBox runat="server" ID="txtNimi" /><br />
        Yhteyshenkilö:<br /><asp:TextBox runat="server" ID="txtYhtHlo" /><br />
        Maa:<br /><asp:TextBox runat="server" ID="txtMaa" /><br />
        Postinumero:<br /><asp:TextBox runat="server" ID="txtPostinro" /><br />
        Postitoimipaikka:<br /><asp:TextBox runat="server" ID="txtPostitmp" /><br />
        Ostot:<br /><asp:TextBox runat="server" ID="txtOstot" /><br />
        Vuosi:<br /><asp:TextBox runat="server" ID="txtVuosi" /><br /><br />
        <asp:Button runat="server" Text="Luo uusi asiakas" ID="btnCreateCustomer" OnClick="btnCreateCustomer_Click" /><br />
        <asp:Label ID="lblMessages" runat="server" /><br />
        <a href="Asiakkaat.aspx">Selaa asiakkaita</a>
    </div>
    </form>
</body>
</html>
