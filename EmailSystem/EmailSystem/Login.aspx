<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmailSystem.Login" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       
         <% 

                     SqlConnection Con = new SqlConnection();
                     Con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\EmailSystem\\EmailSystem\\App_Data\\EmailSystem.mdf';Integrated Security=True";
                     Con.Open();
                     SqlCommand cmd = Con.CreateCommand();
                     cmd.CommandText = "SELECT * FROM USERS WHERE UserName = '" + Request.Form ["UserName"] + "' and password='"+Request.Form ["Password"]+"'";
                      Response.Write(cmd.CommandText);
                     SqlDataReader Users = cmd.ExecuteReader();
                     if (Users.Read()) {
                            Session["User"] = Users["UserName"].ToString(); // Creates session if user is valid.
                            Response.Redirect("Inbox.aspx"); 
                        
                     } else {
                       Response.Redirect("InvalidLogin.aspx");
                     }

  
                  %>


        <a href ="InvalidLogin.aspx" > Invalid Login</a><br />
        <a href ="Inbox.aspx">Inbox</a>


    </div>
       
        
    </form>

        
        
</body>
</html>
