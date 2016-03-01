<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Assignment5New.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta charset="UTF-8">
    <link type="text/css" rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">

    <div id="mainBody">
        <asp:Panel ID="pnlEditing" runat="server" Visible="true">
            <h1>Please Registrer:</h1>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" ToolTip="This is a First Name" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbFirstName" runat="server" Width="395px" AutoCompleteType="FirstName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqFirstName" runat="server" ControlToValidate="tbFirstName" ErrorMessage="First name is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br><asp:Label ID="lblLastName" runat="server" Text="Last Name:" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbLastName" runat="server" Width="395px" AutoCompleteType="LastName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqLastName" runat="server" ControlToValidate="tbLastName" ErrorMessage="Last name is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br>
            <asp:Label ID="lblUsername" runat="server" Text="Username:" ToolTip="This is an Username" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbUsername" runat="server" Width="395px" AutoCompleteType="DisplayName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqUsername" runat="server" ControlToValidate="tbUsername" ErrorMessage="Username is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br>
            <asp:Label ID="lblPassword" runat="server" Text="Password:" ToolTip="This is a Password" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" Width="395px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br>
            <asp:Label ID="lblRePassword" runat="server" Text="Reenter Password:" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbRePassword" runat="server" TextMode="Password" Width="395px"></asp:TextBox>
            <asp:CompareValidator ID="cmpPwdValidator" runat="server" ErrorMessage="Passwords do not match. " ControlToCompare="tbRePassword" ControlToValidate="tbPassword" ForeColor="Red"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="reqRePassword" runat="server" ControlToValidate="tbRePassword" ErrorMessage=" Password confirmation is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br>
            <asp:Label ID="lblEmail" runat="server" Text="Email:" ToolTip="This is an Email" Font-Bold="True"></asp:Label><br>
            <asp:TextBox ID="tbEmail" runat="server" Width="330px" AutoCompleteType="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email is required. " ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
            <br><br>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Sumbit Data" OnClick="btnSubmit_Click"></asp:Button>
        </asp:Panel>
        </div>
    </form>
</body>
</html>
