using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ViewStateDemo.FormAuthDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateUser(txtUserName.Text, txtPassword.Text);

        }

        public void AuthenticateUser(string usrname, string password)
        {
            String cs = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter username = new SqlParameter("@username", usrname);

                string encryptedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

                SqlParameter encrPassword = new SqlParameter("@password", encryptedpassword);

                cmd.Parameters.Add(username);
                cmd.Parameters.Add(encrPassword);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                { 
                    int RetryAttempts = Convert.ToInt32(rdr["RetryAttempts"]);
                    if(Convert.ToBoolean(rdr["AccountLocked"]))
                    {
                        lblMessage.Text = "Account locked. Please contact administrator";
                    }
                    else if(RetryAttempts>0)
                    {
                        int AttemptsLeft = (4 - RetryAttempts);
                        lblMessage.Text = "Invalid user name and/or password. " +
                            AttemptsLeft.ToString() + "attempt(s) left";
                    }
                    else if (Convert.ToBoolean(rdr["Authenticated"]))
                    {
                        FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, ChckboxRemberMe.Checked);
                    }
                }

            }
        }

    }  
}