<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tapa2.aspx.cs" Inherits="Tapa2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tapa2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Kohde 2: HttpPost -tapa</h1>
    <p>
        Kutsuvalta sivulta luetaan viesti:
        <%=Request.Form["txtMessage"] %>
        <br />
    </p>
    </div>
    </form>
</body>
</html>
