<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Cookie1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <%

    
            if (Request.Cookies["Name"] == null)
            {
                Response.Cookies["Name"].Value = TextBox1.Text;
            }
            else
            {
                Response.Redirect("WelcomePage.aspx"); 
            }
             %>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WelcomePage.aspx">Proceed</asp:HyperLink>
        <br />
    
        <br />
        <br />


       
    
    </div>
       
    </form>
</body>
</html>
