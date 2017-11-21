using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultantDets
{
    public partial class Home : System.Web.UI.Page
    {
        public String Name; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsCallback)
            {
                //NameValue.Text = "Name"; 
            }
        }
    }
}