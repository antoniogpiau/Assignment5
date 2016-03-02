<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="Assignment5New.Posts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="mainBody">
        <header>
            <div>
				You are logged in <asp:Label ID="lblUserFullName" runat="server"></asp:Label>. 
				<asp:Button ID="btnLogout" runat="server" Text="LogOut" OnClick="LogOut"></asp:Button>
			</div>    
		</header>

        <asp:Label runat="server" ID="lblResults" BackColor="Red"></asp:Label>
        <h3>Posts</h3>	
        <asp:Repeater runat="server" ID="rptPosts">
            <HeaderTemplate>
                <ul id="expandedPostsList">
            </HeaderTemplate>
            <ItemTemplate>
                <li class="toggleListItem"><span style="font-weight:bold"><%#Eval("Title")%> <%#Eval("UserID")%></span> - <span><%#Eval("DatePosted")%></span>
                <p style="display:none"><%#Eval("Description")%></p>
                <p style="display:none"><%#Eval("Content")%></p>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>   

        <script type="text/javascript">
            $(document).ready(function () {
                $('.toggleListItem').click(function () {
                    $(this).children("p").toggle();
                });
            });
	    </script>

        <section>
				<table>
                    <tr><td>Title:</td><td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Description:</td><td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td></tr>
                    <tr><td>Post:</td><td><asp:TextBox ID="txtPost" runat="server"></asp:TextBox></td></tr>
                    <tr><td><asp:Button runat="server" ID="btnPost" OnClick="AddPost" Text="Post"></asp:Button></td></tr>
				</table> <br/><br/>
    	</section>
    
    </div>
    </form>
</body>
</html>
