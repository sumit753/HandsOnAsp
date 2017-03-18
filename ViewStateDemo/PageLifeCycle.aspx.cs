using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page PreInit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Initialization" + "<br/>");

        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page InitComplete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page PreLoad" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page Load complete" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page PreRender" + "<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page PreRender Complete" + "<br/>");
        }
    }
}