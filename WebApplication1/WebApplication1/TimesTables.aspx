<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimesTables.aspx.cs" Inherits="WebApplication1.TimesTables" %>

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
            int Table = Int32.Parse(Request.QueryString["T"]);
            int Range = Int32.Parse(Request.QueryString["R"]);
            Response.Write("<H1> Times table of " + Table + "</H1>");

            for(int i=1; i<=Range; i++)
            {
                Response.Write(Table + "x" + i + "=" + (i * Table) + "<br/>"); 
            }

             %>
    </form>
</body>
</html>
