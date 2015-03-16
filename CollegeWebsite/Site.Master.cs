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
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (ViewState["AdDisplayed"] == null)
            {
                ViewState["AdDisplayed"] = 1;
                Label1.Text = "To do - Advert 1";
            }
            else
            {
                int i = (int)ViewState["AdDisplayed"];
                if (i == 3)
                {
                    ViewState["AdDisplayed"] = 1;
                    Label1.Text = "To do - Advert 1";
                }
                else
                {
                    i = i + 1;
                    ViewState["AdDisplayed"] = i;
                    Label1.Text = "To do - Advert " + i.ToString();
                }
            }            
        }
    }
}
