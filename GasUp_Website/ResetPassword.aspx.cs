using GasUp_Website.ServiceReference1;
using HashPass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userforgotpassword"] == null) //if the is not username assigned, then do not allow this page to be reached
            {
                Response.Redirect("ForgotPassword.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Session["userforgotpassword"] != null) //if user has assigned correct username, then allow password reset
            {
                var useruser =(User) Session["userforgotpassword"]; //cast to user
                bool useredited = client.updateUserpassword(useruser.email, Secrecy.HashPassword(password.Value));
                   if (useredited == true)
                { //if user successfully edited set to null
                    Session["userforgotpassword"] = null;
                    Response.Redirect("LogIn.aspx"); //Redirect to login page
                }
                else {
                    //remain on the same page
                    Response.Redirect("#");
                }
            }

            
        }
    }
}