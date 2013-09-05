<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>IIO13200. NET Ohjelmointi Demot Syksy 2013</h1>
        <h2>5.9.2013</h2>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/BranchTest.aspx">Test branch</asp:HyperLink>
    </div>
    </form>
</body>
</html>
