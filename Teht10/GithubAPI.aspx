<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GithubAPI.aspx.cs" Inherits="GithubAPI" Async="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Github API Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Github username:
    <asp:textbox id="txtGithubUser" runat="server" OnTextChanged="txtGithubUser_TextChanged" AutoPostBack="true"></asp:textbox>
    Select repo:
    <asp:dropdownlist id="ddlGithubRepo" runat="server"></asp:dropdownlist>
    <asp:button ID="btnGetData" runat="server" onclick="btnGetData_Click" Text="Get data from Github"/><br />
    <h3>Your followers:</h3>
    <div id="divFollowers" runat="server"></div>
    <h3>Commits for selected repo:</h3>
    <div id="divCommits" runat="server"></div>
    <h3>Languages for selected repo:</h3>
    <div id="divLanguages" runat="server"></div>
    <asp:Label ID="lblMessages" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
