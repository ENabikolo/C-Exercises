<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MultiProjects.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> Times Tables</h1>
 
    </div>

        <%
            for (int i = 1; i <=1000; i++)
            {
                Response.Write("<a href = 'Second.aspx?T=" + i + "'>" + i + "</a>" + "</br>");        
            }

             %>

    </form>
</body>
</html>
