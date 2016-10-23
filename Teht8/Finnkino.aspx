<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Finnkino.aspx.cs" Inherits="Finnkino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Finnkino</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="float:left">
            <asp:ListBox ID="lbTeatterit" runat="server" Height="400" OnSelectedIndexChanged="lbTeatterit_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
        </div>
        <div style="float:left">   
            <asp:GridView ID="gvLeffat" runat="server" AutoGenerateColumns="false">
                <RowStyle HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="MovieName" HeaderText="Titteli"/>
                    <asp:BoundField DataField="MovieStartTime" HeaderText="Alkaa" />
                    <asp:BoundField DataField="MovieEndTime" HeaderText="Päättyy"/>
                    <asp:BoundField DataField="MovieLength" HeaderText="Pituus (min)"/>
                    <asp:BoundField DataField="MovieGenres" HeaderText="Genret" />
                    <asp:ImageField DataImageUrlField="MovieImage" HeaderText="Kuva"/>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
