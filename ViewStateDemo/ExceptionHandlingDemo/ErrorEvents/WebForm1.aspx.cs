using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ViewStateDemo.ExceptionHandlingDemo.EventHandler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    DataSet ds = new DataSet();

                    ds.ReadXml(Server.MapPath("~/Counties.xml"));

                    GridView1.DataSource = ds;
                    GridView1.DataBind();


        }

        //if we dont handle exception in our page ,all the exception can handled in the following method.
        //& if we dont handle error in following method ,then we can handle it in Application_Error method in Global.asax
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            //clear the exception
            Server.ClearError();

            //if we dont redirect it to any page then "Blank page will be opened"
                 Response.Redirect("~/ExceptionHandlingDemo/ErrorEvents/Error.aspx");

        }
    }
}