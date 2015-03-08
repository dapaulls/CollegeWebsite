using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeWebsite.StudentsOnly
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DownloadButton_Click(object sender, EventArgs e)
        {
            string filename = FileDropDownList.SelectedItem.Text;
            Response.Clear();
            Response.ContentType = "application/octate-stream";
            Response.AppendHeader("Content-Disposition", "filename =" + filename);
            Response.TransmitFile(Server.MapPath("~/StudentsOnly/UploadedFiles/" + filename));
            Response.End();
        }
    }
}