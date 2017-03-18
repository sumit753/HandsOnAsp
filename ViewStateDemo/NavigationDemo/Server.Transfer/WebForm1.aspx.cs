using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.NavigationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            //Server.Transfer("~/NavigationDemo/WebForm2");

            //overloaded Server.Transfer method,false is passed so that previous form values are not preserved by Request.Form.

            Server.Transfer("~/NavigationDemo/Server.Transfer/WebForm2.aspx", false);
    
        }

        protected void btnTransferToExternalWebsite_Click(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}