using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.NavigationDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //In two ways we can get the data of previous WebForm

            //it will not preserve value when "false" is passed from the method.
           //System.Collections.Specialized.NameValueCollection previousFormCollection  = Request.Form;
           // lblName.Text = previousFormCollection["txtName"];
           // lblEmail.Text = previousFormCollection["txtEmail"];

            //another way
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