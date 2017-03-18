using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ViewStateDemo
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            Application["NoOfUserOnline"] = 0;

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

            //Exception ex = Server.GetLastError();
            //if (ex != null)
            //{
            //    ViewStateDemo.Windows_Event_ViewerDemo.Logger.Log(ex);
            //    Server.ClearError();
            //    Server.Transfer("~/Windows_Event_ViewerDemo/Error.aspx");

            //}

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

            Application.Lock();
            Application["NoOfUserOnline"] = (int)Application["NoOfUserOnline"] + 1;
            Application.UnLock();

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
  
            Application.Lock();
            Application["NoOfUserOnline"] = (int)Application["NoOfUserOnline"] - 1;
            Application.UnLock();
        }

    }
}
