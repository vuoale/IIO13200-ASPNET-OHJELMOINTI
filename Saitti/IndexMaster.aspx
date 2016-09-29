<%@ Page Title="IIO13200. NET Ohjelmointi" Language="C#" AutoEventWireup="true" CodeFile="IndexMaster.aspx.cs" Inherits="Index" MasterPageFile="~/MasterPage.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div>
        <h2>1.kontaktikerta</h2>
        <p>Aleksin webbisaitti</p>
        <h3>Perus HTML kontrolleja</h3>
        <a href="Testi.html">Testi html-sivu</a>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Hello.aspx">My First ASPX page</asp:LinkButton>
        <p>
            Esimerkki ASP.NET DataKontrollista
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
        </p>
        <p>
            Esimerkki kuinka koodissa rakennetaan HTML:ää
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
        </p>
        <h2>To 22.9.2016</h2>
        <h3>Tiedon välitys sivulta toiselle:</h3>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Source.aspx">Tiedon välitys 6 tapaa</asp:HyperLink>
        </p>
        <h2>To 29.9.2016</h2>
        <h3>Responsiivinen sivu:</h3>
        <p>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/FordMustang.aspx">Ford Mustang</asp:HyperLink>
        </p>
    </div>
</asp:Content>

