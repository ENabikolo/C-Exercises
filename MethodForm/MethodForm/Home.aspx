<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MethodForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
          
    <form id="form1" runat="server">
        </form>

    <form action="Process.aspx" method ='post'>
        First No:<input type ='text' name="No1" /><br/>
        Second No:<input type ="text" name ="No2" />
        <input type ='submit' value ='Click'/> 

    </form>
</body>
</html>
