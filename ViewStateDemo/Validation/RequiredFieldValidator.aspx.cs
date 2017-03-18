using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.Validation
{
    public partial class RequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //server-side validation
            
            if (Page.IsValid)
            {
                lblStatus.Text = "Data Saved SucessFully";
                lblStatus.ForeColor = System.Drawing.Color.Blue;

            }
            else
            {
                lblStatus.Text = "Validation failed..!";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}