<%@ Page Title="MoviesFromSQL" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesFromSQL.aspx.cs" Inherits="MoviesFromSQL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- DataSource SQLServeriltä -->
    <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:Movies %>" SelectCommand="SELECT [title], [director], [year], [url] FROM [Movies] ORDER BY [title]"></asp:SqlDataSource>
    <!-- GV esittää datan -->
    <div>
        <h2 class="w3-container w3-indigo">Leffat SQL Serveriltä</h2>
        <asp:GridView ID="gvMovies" DataSourceID="srcMovies" runat="server"></asp:GridView>
    </div>
    <!-- Data HTML:ssä -->
    <h2 class="w3-container w3-indigo">Leffat HTML:ssä</h2>
    <asp:Repeater ID="repeater" DataSourceID="srcMovies" runat="server">
        <ItemTemplate>
            <p><%# Eval("title") %> by <%# Eval("Director") %></p>
            <img src="<%# Eval("url") %>" alt="kuva puuttuu" width="200" />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

