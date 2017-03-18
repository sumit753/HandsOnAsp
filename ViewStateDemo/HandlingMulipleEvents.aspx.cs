using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class HandlingMulipleEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CommandButton_click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    Label1.Text = "Print Button Clicked";
                    break;
                case "Delete":
                    Label1.Text = "Delete Button Clicked";
                    break;
                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        Label1.Text = "Top10 button clicked";
                    }
                    else
                        Label1.Text = "Bottom10 button clicked";
                    break;
                default:
                    Label1.Text = "Don't Know which Button Clicked";
                    break;

            }
        }
    }
}