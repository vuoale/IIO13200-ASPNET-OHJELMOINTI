<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Levykauppa.aspx.cs" Inherits="Levykauppa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Levykauppa</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcLevyt" runat="server" DataFile="~/App_Data/LevykauppaX.xml" XPath="//record"></asp:XmlDataSource>
        <asp:DataList ID="dlLevyt" runat="server" DataSourceID="srcLevyt">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <img alt="kuva puuttuu" src="Images/<%# Eval("ISBN") %>.jpg" style="width:200px; height:200px" />
                        </td>
                        <td>
                            <b><%# Eval("Artist") %> : <%# Eval("Title") %></b><br /><br />
                            <b>ISBN:</b> <a href="LevynTiedot.aspx?isbn=<%# Eval("ISBN") %>"><%# Eval("ISBN") %></a><br />
                            <b>Hinta:</b> <%# Eval("Price") %>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
