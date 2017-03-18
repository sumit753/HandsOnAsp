using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //to understand AutoPostBack.
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("TextChanged Event Occured <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("ButtonClick Event Occured <br/>");
        }
    }
}