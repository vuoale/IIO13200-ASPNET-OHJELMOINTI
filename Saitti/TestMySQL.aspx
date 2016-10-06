<%@ Page Title="TestMySQL" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestMySQL.aspx.cs" Inherits="TestMySQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:SqlDataSource ID="srcMysli" runat="server" ConnectionString="<%$ ConnectionStrings:Mysli %>" ProviderName="MySql.Data.MySqlClient" SelectCommand="SELECT * FROM sanakirja"></asp:SqlDataSource>
    <h2>Sanakirja</h2>
    <asp:GridView ID="gvSanakirja" runat="server" DataSourceID="srcMysli"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

