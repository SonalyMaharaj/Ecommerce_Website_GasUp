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
    public partial class LogIn : System.Web.UI.Page
    {
		Service1Client client=new Service1Client();
		
        protected void Page_Load(object sender, EventArgs e)
        {
			if(Session["UserType"]!=null) //if user is logged in
			{
				Response.Redirect("MasterHome.aspx");
			}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			string passwordlogin = Secrecy.HashPassword(password.Value);
			int userid=client.Login(email.Value, passwordlogin);
			
			if (userid != 0)
			{
				var loguser = client.getUser(userid);


				if (loguser != null)
				{
					Session["UserType"] = loguser.UserType;
					Session["UserId"] = loguser.Id;
					Session["username"] = loguser.Name;
					Session["CartItems"] = 0;
					Response.Redirect("MasterHome.aspx");
				}
			}
			else
			{
				//label with id error
				error.Text = "Invalid Username Or Password";
				//error.TextColor="Red"; change the color to red insomeway				
			}
			
			
        }
    }
}