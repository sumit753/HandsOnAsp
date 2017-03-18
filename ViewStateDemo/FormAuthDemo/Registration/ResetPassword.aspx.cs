using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ViewStateDemo.FormAuthDemo.Registration
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spResetPassword",con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter username = new SqlParameter("@username", txtUserName.Text);

                cmd.Parameters.Add(username);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Convert.ToBoolean(rdr["ReturnCode"]))
                    {
                        sendEmail(rdr["Email"].ToString(), txtUserName.Text, rdr["UniqueID"].ToString());
                        lblMessage.Text = "A Password Reset Link has been sent to your mail id";
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Invalid UserName";
                    }
                
                }

            }
        }

        public void sendEmail(string RecieverEmailId, string username, string uniqueId)
        {
            MailMessage mailMsg = new MailMessage("sumit753@gmail.com",RecieverEmailId);

            StringBuilder mailBdy = new StringBuilder();
             
            mailBdy.Append("Dear " + username +",<br/><br/>");
            mailBdy.Append("Please Click on following link to Reset your password <br/> <br/>");
            mailBdy.Append("http://localhost:62395/FormAuthDemo/Registration/ChangePassword.aspx?uid=" + uniqueId + "<br/><br/>");
            mailBdy.Append("KarmaTechnologies");

            mailMsg.IsBodyHtml = true;
            mailMsg.Body = mailBdy.ToString();
            mailMsg.Subject = "Reset Your ASP.net Site Password";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);


            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "sumit753@gmail.com",
                Password = "7nokia_MICROMAX"
            };


            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMsg);
        }
    }
}