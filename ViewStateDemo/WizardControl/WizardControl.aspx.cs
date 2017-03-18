using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.WizardControl
{
    public partial class WizardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Writing javascript code.Programaticaly calling the javascript.
            //we had done the same thing by calling javascript function in HTML tag.
            Button nxtBtn = (Button) Wizard1.FindControl("StepNavigationTemplateContainerID").FindControl("StepNextButton");
            nxtBtn.OnClientClick = "return confirm('Are You sure,want to goto next step')";
        }

        protected void txtFirstName_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 0)
            {
                txtFirstName.Focus();
            }
           
            
        }
    }
}