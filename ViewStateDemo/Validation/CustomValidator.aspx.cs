using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo.Validation
{
    public partial class CustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;

            }
            else
            {
                int number;
                bool isNumber;

                isNumber = int.TryParse(args.Value,out number);

                if (isNumber && number >= 0 && number % 2 == 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
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