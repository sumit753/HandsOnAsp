using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  
            // Associating Event handler using Delegates.
            Button1.Click +=new EventHandler(Button1_Click);
            Button1.Command +=new CommandEventHandler(Button1_Command);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Click Event Triggered");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Command Event Triggered");

        }
    }
}