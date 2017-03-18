using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace ViewStateDemo.FormAuthDemo.Registration
{
    public partial class LockedUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllData();
            }
        }

        private void getAllData()
        {
            String cs = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetAllLockedUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          EnableUserAccount(e.CommandArgument.ToString());
          getAllData();
        }
        private void EnableUserAccount(string UserName)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spEnableUserAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUserName = new SqlParameter()
                {
                    ParameterName = "@UserName",
                    Value = UserName
                };

                cmd.Parameters.Add(paramUserName);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }

}