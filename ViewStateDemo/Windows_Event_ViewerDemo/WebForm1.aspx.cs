using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ViewStateDemo.Windows_Event_ViewerDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //if don't handle the exception here,it will handle at page level or at application level.It wil also generate Http UnhandledException

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("~/Countris.xml");

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Server.Transfer("Error.aspx");
            }
        }
    }
}