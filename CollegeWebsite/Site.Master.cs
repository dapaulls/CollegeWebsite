using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeWebsite
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PickAdImage();
            }
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            PickAdImage();         
        }

        private void PickAdImage()
        {
            if (ViewState["AdDisplayed"] == null)
            {
                ViewState["AdDisplayed"] = 1;
                Image1.ImageUrl = "~/Images/Ad1.jpg";
            }
            else
            {
                int i = (int)ViewState["AdDisplayed"];
                if (i == 3)
                {
                    ViewState["AdDisplayed"] = 1;
                    Image1.ImageUrl = "~/Images/Ad1.jpg";
                }
                else
                {
                    i = i + 1;
                    ViewState["AdDisplayed"] = i;
                    Image1.ImageUrl = "~/Images/Ad" + i.ToString() + ".jpg";
                }
            }
        }
    }
}
