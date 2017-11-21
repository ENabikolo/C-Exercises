<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="EmailSystem.Inbox" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <%

        
        
         %>
    <form id="form1" runat="server">
    <div>
        Welcome to your Inbox! <input type =" submit" value="Logout" />
         <%

            //UserName: Welcome to your inbox!
             SqlConnection Con = new SqlConnection();
             //SqlDataReader R; 
             Con.ConnectionString ="Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\EmailSystem\\EmailSystem\\App_Data\\EmailSystem.mdf';Integrated Security=True";
             Con.Open();
             SqlCommand cmd = Con.CreateCommand();
             cmd.CommandText = "SELECT * FROM EMAILS WHERE To ='" + Session["User"].ToString()+ "'";
             Response.Write(cmd.CommandText);

             if (Session["User"] == null){
                 Response.Redirect("login.aspx");
             }else {

                 SqlDataReader R = cmd.ExecuteReader();
                 while (R.Read()){
                     Response.Write(R["From"]);
                 }

             }
            %>
    </div>
    </form>
</body>
</html>
