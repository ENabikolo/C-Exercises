<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Process.aspx.cs" Inherits="MethodForm.Process" %>

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
     
            int A = Int32.Parse(Request.Form["No1"]);
            int B = Int32.Parse(Request.Form["No2"]);
           
            Response.Write("The Result is " + (A + B));

             %>
    </form>
</body>
</html>
