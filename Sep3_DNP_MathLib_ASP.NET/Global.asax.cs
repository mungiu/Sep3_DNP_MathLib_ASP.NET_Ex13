using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Sep3_DNP_MathLib_ASP.NET
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //initialize an Application variable named clicks as follows: 
            // NOTE: This object is shared among all user sessions
            Application["clicks"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // NOTE: This object is NOT shred among all user sessions but is private to curent session only
            Session["session_clicks"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}