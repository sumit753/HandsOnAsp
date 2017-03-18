using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ViewStateDemo.AnonymousAuthenticationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Application Code Executed Using :");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is user Authenticated :");
            Response.Write(User.Identity.IsAuthenticated.ToString() + "<br/>");

            Response.Write("Authentication Type , if authenticated :");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("UserName if authenticated");
            Response.Write(User.Identity.Name + "<br/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/Countries.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();
           
        }
    }
}