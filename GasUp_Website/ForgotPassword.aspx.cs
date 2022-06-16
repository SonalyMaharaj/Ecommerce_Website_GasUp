using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null) //if user is logged in
            {   
                Response.Redirect("MasterHome.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var useruser = client.EmailgetUser(email.Value); //getUser(email)

            if (useruser!=null)
            {

                Session["userforgotpassword"] = useruser; //assigning user that forgot the password

               Response.Redirect("ResetPassword.aspx");
            }

        }

    }
}