using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace PracticaHotel
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if(FormsAuthentication.Authenticate(login.UserName, login.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(login.UserName, login.RememberMeSet);
            }
        }
    }
}