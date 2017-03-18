using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.NavigationDemo.CrossPostBack
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page previousPage = Page.PreviousPage;

            //if (previousPage != null && previousPage.IsCrossPagePostBack)
            //{
            //    lblName.Text = ((TextBox)previousPage.FindControl("txtName")).Text;
            //    lblEmail.Text = ((TextBox)previousPage.FindControl("txtEmail")).Text;
            //    lblMsg.Visible = false;
            //}
            //else
            //{
            //    lblMsg.Text = "You have Trasfered to webform2 via method other than CrossPostBack";
            //}

            // INSTEAD of above code 
            // We can do it by obtaining Strongly Typed Refrence to avoid Null Exception

            WebForm1 previousPage = (WebForm1) this.PreviousPage;
            if (previousPage != null && previousPage.IsCrossPagePostBack)
            {
                lblName.Text = previousPage.Name;
                lblEmail.Text = previousPage.Email;
                lblMsg.Visible = false;
            }
            else
            {
                lblMsg.Text = "You have Trasfered to webform2 via method other than CrossPostBack";
            }
            
        }
    }
}