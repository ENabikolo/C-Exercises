using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie1
{
    public partial class Home : System.Web.UI.Page
    {

        public String Name; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsCallback)
            {
                TextBox1.Text = "Esther";
            }
         
            }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Name"] == null)
            {
                Response.Cookies["Name"].Value = TextBox1.Text;
            }
            else
            {
                Response.Redirect("WelcomePage.aspx"); 
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}