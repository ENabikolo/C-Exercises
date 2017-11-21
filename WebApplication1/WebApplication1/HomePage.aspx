<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        This is my Home Page.
    </div>
        <% for (int i = 1; i<=20000; i++)
            {
                Response.Write("<a href= 'TimesTable.aspx?T="+ i +"'>"+ i +"</a>"+"<br/>"); 
            }

             %>

        <a href ="QA.aspx" > QA Consulting</a>
        <a href ="TimesTables.aspx?T=2&R=10">2</a>
        <a href ="TimesTables.aspx?T=3&R=20">3</a>
       
    </form>
</body>
</html>
