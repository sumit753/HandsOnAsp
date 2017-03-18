using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Web.Security;

namespace ViewStateDemo.FormAuthDemo.Registration
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!isPasswordlinkValid())
                {
                    lblMessage.Text = "Reset password link is invalid or has Expired";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (changePassword())
            {
                lblMessage.Text = "Password changed Sucessfully..!";
                lblMessage.ForeColor = System.Drawing.Color.RoyalBlue;
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Password Reset link has expired or is invalid";
            }
        }

        public bool isPasswordlinkValid()
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter()
                { 
                    ParameterName="@GUID",
                    Value= Request.QueryString["uid"]
                }
                
            };

            return ExecuteSp("spIsPasswordResetLinkValid",param);
        }

        public bool changePassword()
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName= "@GUID",
                    Value= Request.QueryString["uid"]
                },
                new SqlParameter()
                {
                    ParameterName="@password",
                    Value= FormsAuthentication.HashPasswordForStoringInConfigFile(txtNewPassword.Text,"SHA1")
                }
            };
            return ExecuteSp("spChangePassword",param);
        }

        public bool ExecuteSp(string spName, List<SqlParameter> paramterlist)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(spName,con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in paramterlist)
                {
                    cmd.Parameters.Add(param);
                }

                con.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }
    }
}