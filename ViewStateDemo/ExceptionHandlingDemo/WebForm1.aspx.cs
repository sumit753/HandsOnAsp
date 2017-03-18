using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ViewStateDemo.ExceptionHandlingDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //It will show the Current User Name of Windows Operating System using the Visual Studio.
            // If permission is denied to acess the file .We can find the user name & set acess permission.
            //Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            
            try
            {
                DataSet Ds = new DataSet();

                Ds.ReadXml(Server.MapPath("~/Countries.xml"));

                GridView1.DataSource = Ds;
                GridView1.DataBind();
            }
            catch (Exception error)
            { 
                //log the exception
                //lblErrorMsg.Text = "File Not Found";
                Response.Write(error.Message);
            }
        }
    }
}