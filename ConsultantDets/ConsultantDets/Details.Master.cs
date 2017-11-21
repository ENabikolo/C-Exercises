using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; 

namespace ConsultantDets
{
    public partial class Dets : System.Web.UI.MasterPage
    {
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader R; 


        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\ConsultantDets\\ConsultantDets\\App_Data\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = SELECT * FROM PERSONALINFO['']
        }

        protected void NameValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}