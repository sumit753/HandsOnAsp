using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.NavigationDemo.Server.Execute
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Collections.Specialized.NameValueCollection previousPageCollection = Request.Form;
            //lblName.Text = previousPageCollection["txtName"];
            //lblEmail.Text = previousPageCollection["txtEmail"];

            // it will preserve the values even if false is passed in the Server.Transfer
            Page previousPage = Page.PreviousPage;

            if (previousPage != null)
            {
                lblName.Text = ((TextBox)previousPage.FindControl("txtName")).Text;
                lblEmail.Text = ((TextBox)previousPage.FindControl("txtEmail")).Text;
            }

        }

    }
}