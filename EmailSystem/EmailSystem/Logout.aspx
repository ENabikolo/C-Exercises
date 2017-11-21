<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="EmailSystem.Logout" %>
<%@ Import Namespace="System.Data.SqlClient"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <%
            Session.Abandon();
            Response.Redirect("Login.aspx"); 

             %>
    </form>
</body>
</html>
