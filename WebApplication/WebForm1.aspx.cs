using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name=TextBox1.Text;
            string pwd = TextBox2.Text;
            if (name=="Naveen"&pwd=="Naveen@23")
            {
                Server.Transfer("WebForm2.aspx");
            }
            else { Label3.Text = "User id or Password not correct"; }
        }
    }
}