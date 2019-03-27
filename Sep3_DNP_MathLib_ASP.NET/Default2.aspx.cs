using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep3_DNP_MathLib_ASP.NET
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (ViewState["clicks"] != null)
            //{ ViewState["clicks"] = (int)ViewState["clicks"] + 1; } else { ViewState["clicks"] = 1; }

            //Label1.Text = " ViewState clicks: " + ((int)ViewState["clicks"]).ToString();

            /// Store Data in a Query String
            /// NOTE: This is convenient when the ame value must be used across multiple pages
            /// In this case value is incremented when pages are switched
            /// 

            if (!IsPostBack)
            {     //read the query string     
                int queryClicks;
                if (Request.QueryString["clicks"] != null)
                { queryClicks = int.Parse(Request.QueryString["clicks"]) + 1; }
                else { queryClicks = 1; }
                //define the query string in the hyperlink     
                HyperLink1.NavigateUrl += "?clicks=" + queryClicks.ToString();
                Label1.Text = "Query clicks: " + queryClicks.ToString();
            }

            // locking to facilitate synchronious actions
            Application.Lock();
            Application["clicks"] = ((int)Application["clicks"]) + 1; Application.UnLock();
            LabelApplicationClicks.Text = "Application clicks: " + Application["clicks"].ToString();

            //  code to increment the number of clicks for the given user’s session
            Session["session_clicks"] = (int)Session["session_clicks"] + 1;
            LabelSessionClicks.Text = "Session clicks: " + Session["session_clicks"].ToString();
        }
    }
}