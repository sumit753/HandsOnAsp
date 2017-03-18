using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.NavigationDemo.Server.Execute
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Server.Execute("~/NavigationDemo/Server.Execute/WebForm2.aspx");
            lblStatus.Text = "Finished processing Form 2";
        }
    }
}