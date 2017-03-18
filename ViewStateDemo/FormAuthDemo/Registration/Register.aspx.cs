using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace ViewStateDemo.FormAuthDemo.Registration
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                String cs = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spRegisterUser",con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = new SqlParameter("@username",txtUserName.Text);

                    String enycrtedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text,"SHA1");

                    SqlParameter password = new SqlParameter("@password",enycrtedPassword);

                    SqlParameter email = new SqlParameter("email", txtEmail.Text);

                    cmd.Parameters.Add(username);
                    cmd.Parameters.Add(email);
                    cmd.Parameters.Add(password);
                   

                    con.Open();
                    int ReturnCode = (int)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    {
                        lblMessage.Text = "User Name already in use, please choose another user name";
                    }
                    else
                    {
                        Response.Redirect("~/Login.aspx");
                    }
                    
                }
            }
            else
            { 
            
            }
        }
    }
}