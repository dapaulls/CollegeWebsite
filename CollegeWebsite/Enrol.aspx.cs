using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeWebsite
{
    public partial class Enrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            ASPNETDBEntities enrol = new ASPNETDBEntities();
            EnrolList el = new EnrolList();

            el.FirstName = FirstNameTextBox.Text;
            el.LastName = LastNameTextBox.Text;
            el.Email = EmailTextBox.Text;
            el.CourseName = CourseListDropDownList.SelectedItem.Text;
            el.EnquiryDate = DateTime.Now;

            enrol.EnrolLists.AddObject(el);
            enrol.SaveChanges();

            EnrolSuccessfulLabel.Text = "Thank you for submitting your details. We will be in touch shortly.";
        }
    }
}