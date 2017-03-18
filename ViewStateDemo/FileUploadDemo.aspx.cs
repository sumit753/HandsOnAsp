using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateDemo
{
    public partial class FileUploadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (ext.ToLower() != ".doc" && ext.ToLower() != ".docx")
                {
                    LabelOutput.Text = "Only Document file with the Extension \"doc\" or \"docx\" can be uploaded";
                    LabelOutput.ForeColor = System.Drawing.Color.Red;
                }
                else
                {   int fileSize = FileUpload1.PostedFile.ContentLength;
                    if(fileSize > 2097152)
                    {
                        LabelOutput.Text = "File Size can't be more than 2 MB";
                        LabelOutput.ForeColor = System.Drawing.Color.Red;
                    }

                    FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                    LabelOutput.Text = "File Uploaded Sucessfully";
                    LabelOutput.ForeColor = System.Drawing.Color.RoyalBlue;
                }
            }
            else
            {
                LabelOutput.Text = "Please Select a file to Upload";
                LabelOutput.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}