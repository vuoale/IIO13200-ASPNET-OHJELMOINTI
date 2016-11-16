<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Asiakkaat.aspx.cs" Inherits="Asiakkaat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asiakkaat</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGetCustomers" Text="Hae kaikki asiakkaat" runat="server" OnClick="btnGetCustomers_Click" />
        <asp:DropDownList ID="ddlCountries" runat="server" AutoPostBack="true"></asp:DropDownList>
        <asp:Button ID="btnGetCustomersFromCountry" Text="Hae asiakkaat valitusta maasta" runat="server" OnClick="btnGetCustomersFromCountry_Click" />
        <asp:Button ID="btnGetCustomersByCountry" Text="Hae asiakkaat maittain" runat="server" OnClick="btnGetCustomersByCountry_Click" />
        <a href="LuoAsiakas.aspx">Luo uusi asiakas</a>
        <asp:GridView ID="gvCustomers" runat="server" />
        <asp:Label ID="lblCustomersByCountry" runat="server" />
    </div>
    </form>
</body>
</html>
