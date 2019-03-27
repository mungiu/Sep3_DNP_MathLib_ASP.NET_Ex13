using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep3_DNP_MathLib_ASP.NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///  Store Data in View State 
            ///  
            //if (ViewState["clicks"] != null)
            //{ ViewState["clicks"] = (int)ViewState["clicks"] + 1; } else { ViewState["clicks"] = 1; }
            //Label1.Text = " ViewState clicks: " + ((int)ViewState["clicks"]).ToString();



            /// Store Data in a Hidden Field 
            /// 
            //int clicks; int.TryParse(HiddenField1.Value, out clicks);
            //clicks++;
            //HiddenField1.Value = clicks.ToString();
            //Label1.Text = "HiddenField clicks: " + HiddenField1.Value;



            /// Store Data in a Cookie 
            /// read the cookie clicks and increment
            /// AKA STORING TEMP DATA IN COOKIES
            ///
            //int cookieClicks;
            //if (Request.Cookies["clicks"] != null)
            //{ cookieClicks = int.Parse(Request.Cookies["clicks"].Value) + 1; }
            //else { cookieClicks = 1; }
            ////save the cookie to be returned on the next visit   
            //Response.Cookies["clicks"].Value = cookieClicks.ToString();
            //Label1.Text = "Cookie clicks: " + cookieClicks.ToString();



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

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            MathLib.MathLib mathLib = new MathLib.MathLib();
            TextBoxAddResult.Text = Convert.ToString(mathLib.Add(int.Parse(TextBoxAdd1.Text), int.Parse(TextBoxAdd2.Text)));
        }

        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            MathLib.MathLib mathLib = new MathLib.MathLib();
            TextBoxSubResult.Text = Convert.ToString(mathLib.Sub(int.Parse(TextBoxSub1.Text), int.Parse(TextBoxSub2.Text)));
        }

        protected void ButtonMul_Click(object sender, EventArgs e)
        {
            MathLib.MathLib mathLib = new MathLib.MathLib();
            TextBoxMulResult.Text = Convert.ToString(mathLib.Mul(int.Parse(TextBoxMul1.Text), int.Parse(TextBoxMul2.Text)));
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            MathLib.MathLib mathLib = new MathLib.MathLib();
            TextBoxDivResult.Text = Convert.ToString(mathLib.Div(int.Parse(TextBoxDiv1.Text), int.Parse(TextBoxDiv2.Text)));
        }
    }
}