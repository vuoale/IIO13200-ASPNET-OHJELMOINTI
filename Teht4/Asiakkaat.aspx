<%@ Page Title="Asiakkaat" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Asiakkaat.aspx.cs" Inherits="Asiakkaat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width:100%;
            height:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- DataSource SQLServeriltä -->
    <asp:SqlDataSource ID="srcAsiakkaat" runat="server" ConnectionString="<%$ ConnectionStrings:DemoxOy %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
    <!-- GV esittää datan -->
    <div class="w3-row">
         <div class="w3-indigo w3-container w3-half">
            <h2>Tapa 1) SQLDataSourcen avulla</h2>
            <asp:GridView ID="gvAsiakkaat" DataSourceID="srcAsiakkaat" runat="server"></asp:GridView>
        </div>
         <div class="w3-container w3-half">
            <h2>Tapa 2) DBDemoxOy-luokan metodien avulla</h2>
            <asp:GridView ID="gvAsiakkaat2" runat="server"></asp:GridView>
            <asp:Label ID="lblMessages" runat="server" Text="" />
        </div>
    </div> 
</asp:Content>

