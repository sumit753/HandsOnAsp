using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ViewStateDemo.CascadingDropDownlist
{
    public partial class CascadingDrpDwnList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = getData("spGetContinents", null);
                DdlContinents.DataSource = ds;
                DdlContinents.DataBind();

                ListItem itemContinent = new ListItem("Select Continent","-1");
                DdlContinents.Items.Insert(0, itemContinent);

                ListItem itemCountry = new ListItem("Select Country","-1");
                DdlCountry.Items.Insert(0, itemCountry);

                ListItem itemCity = new ListItem("Select City","-1");
                DdlCity.Items.Insert(0,itemCity);

                DdlCity.Enabled = false;
                DdlCountry.Enabled = false;
            }

        }

        private DataSet getData(string SpName,SqlParameter SPparameters)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter(SpName,con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(SPparameters!=null)
            {
                da.SelectCommand.Parameters.Add(SPparameters);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds; 
        }

        protected void DdlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlContinents.SelectedIndex == 0)
            {
                DdlCountry.Enabled = false;
                DdlCountry.SelectedIndex = 0;

                DdlCity.Enabled = false;
                DdlCity.SelectedIndex = 0;
            }
            else
            {
                DdlCountry.Enabled =true;

                SqlParameter parameter = new SqlParameter("@ContinentID", DdlContinents.SelectedValue);
                DataSet ds = getData("spGetCountriesByContinentId", parameter);

                DdlCountry.DataSource = ds;
                DdlCountry.DataBind();

                ListItem itemCountry = new ListItem("Select Country", "-1");
                DdlCountry.Items.Insert(0, itemCountry);

                DdlCity.SelectedIndex = 0;
                DdlCity.Enabled = false;

            }

        }

       

        protected void DdlCountry_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DdlCountry.SelectedIndex == 0)
            {

                DdlCity.Enabled = false;
                DdlCity.SelectedIndex = 0;
            }

            else
            {
                DdlCity.Enabled = true;

                SqlParameter parameter = new SqlParameter("@countryId", DdlCountry.SelectedValue);
                DataSet ds = getData("spGetCityByCountryId", parameter);
                DdlCity.DataSource = ds;
                DdlCity.DataBind();

                ListItem itemCity = new ListItem("Select City", "-1");
                DdlCity.Items.Insert(0, itemCity);
            }
        }
        }

       
}