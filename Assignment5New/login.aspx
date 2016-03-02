<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Assignment5New.login" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="mainContent" runat="server">
		<header>
			<hgroup>
				<h1>Login</h1>
			</hgroup>
		</header>
		<section>
				<table>
                    <tr><td>User Name:</td><td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Password:</td><td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                    <tr><td><asp:Label runat="server" ID="lblResults" BackColor="Red"></asp:Label></td><td><asp:Button runat="server" ID="btnRegister" OnClick="Register" Text="Register"></asp:Button></td><td><asp:Button runat="server" ID="btnLogin" OnClick="Login" Text="Login"></asp:Button></td></tr>
				</table> <br/><br/>
    	</section>
		<footer>
		</footer>
</asp:Content>