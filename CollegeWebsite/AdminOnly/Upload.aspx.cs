using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeWebsite.AdminOnly
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                ASPNETDBEntities upload = new ASPNETDBEntities();
                string path = Server.MapPath("~/StudentsOnly/UploadedFiles/");
                WebsiteUpload wu = new WebsiteUpload();

                wu.Title = TitleTextBox.Text;
                wu.Description = DescriptionTextBox.Text;
                wu.File = FileUpload.FileName;

                upload.WebsiteUploads.AddObject(wu);
                upload.SaveChanges();

                FileUpload.PostedFile.SaveAs(path + FileUpload.FileName);
                UploadSuccessfulLabel.Text = "Your file has successfully been uploaded!";
            }
            else
            {
                UploadSuccessfulLabel.Text = "Please select a file.";
            }
        }
    }
}