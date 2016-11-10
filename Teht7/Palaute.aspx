<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Palaute.aspx.cs" Inherits="Palaute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anna palautetta</title>
    <style type="text/css">
        textarea 
        {
            resize: none;
        }
        td 
        {
            vertical-align: top;
            text-align: left;
            padding: 0px 10px 0px 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Anna palautetta</h2>

    <table>
		<tr>
			<td>Pvm:</td>
			<td><asp:TextBox ID="txtDate" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDate" ErrorMessage="Täytä kenttä." ForeColor="Red" />
                <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtDate" Type="Date" Operator="DataTypeCheck" ErrorMessage="Päivämäärä ei ole oikeassa muodossa." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Nimi:</td>
			<td><asp:TextBox ID="txtName" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Opintojakson nimi: </td>
			<td><asp:TextBox ID="txtCourse" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCourse" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Olen oppinut:</td>
			<td><asp:TextBox ID="txtHaveLearned" runat="server" TextMode="multiline" Rows="2" Columns="30" /><br /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtHaveLearned" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Haluan oppia:</td>
			<td><asp:TextBox ID="txtWantToLearn" runat="server" TextMode="multiline" Rows="2" Columns="30" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtWantToLearn" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Hyvää:</td>
			<td><asp:TextBox ID="txtFeedbackPositive" runat="server" TextMode="multiline" Rows="2" Columns="30" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFeedbackPositive" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Parannettavaa:</td>
			<td><asp:TextBox ID="txtFeedbackNegative" runat="server" TextMode="multiline" Rows="2" Columns="30" /></td>
            <td>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFeedbackNegative" ErrorMessage="Täytä kenttä." ForeColor="Red" />
            </td>
		</tr>
		<tr>
			<td>Muuta:</td>
			<td><asp:TextBox ID="txtFeedbackOther" runat="server" TextMode="multiline" Rows="2" Columns="30" /></td>
		</tr>
    </table>

    <asp:Button ID="btnSendXML" runat="server" Text="Lähetä XML" OnClick="btnSendXML_Click" />
    <asp:Button ID="btnSendSQL" runat="server" Text="Lähetä SQL" OnClick="btnSendSQL_Click" />
    <asp:Label ID="lbMessages" runat="server" ForeColor="Green" />
    <br /><br />
    <a href="PalauteSelaa.aspx">Selaa palautteita</a>
    </div>
    </form>
</body>
</html>
