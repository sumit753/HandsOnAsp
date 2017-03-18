using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ViewStateDemo
{
    public partial class XmlDataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml(Server.MapPath("Countries.xml"));

            DropDownList1.DataTextField = "countryName";
            DropDownList1.DataValueField = "countryId";

            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();

            ListItem item = new ListItem("Select", "-1");

            DropDownList1.Items.Insert(0, item);

            
        }
    }
}