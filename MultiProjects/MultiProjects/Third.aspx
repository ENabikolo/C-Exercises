<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Third.aspx.cs" Inherits="MultiProjects.Third" %>

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
            Response.Write("<h2> Times table of " + Table + "</h2>");

            for(int i=1; i<=Range; i++)
            {
                Response.Write(Table + "x" + i + "=" + (i * Table) + "<br/>"); 
            }

             %>
    </form>
</body>
</html>
