using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.Sessions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendData_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Email"] = txtEmail.Text;

            Response.Redirect("~/Sessions/WebForm2.aspx");
        }
    }
}