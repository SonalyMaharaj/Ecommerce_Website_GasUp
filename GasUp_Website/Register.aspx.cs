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
    public partial class Register : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
			if(Session["UserType"]!=null) //if user is logged in
			{
				idgoback.Visible = true; //show the go back arrow
				if (Session["UserType"].ToString()!="CU" && Convert.ToInt32(Request.QueryString["id"]).Equals(1))
				{ //if the query

					
						pagetitle.InnerHtml = "<h2>Register User</h2>";
						utype.Visible=true;
				}
				else{

					if (Session["UserType"].ToString() == "MA" && Request.QueryString["id"]!=null) {
						utype.Visible = true;
					}

					pagetitle.InnerHtml="<h2>Edit Account</h2>";
					signup.Text="Edit";
					regDiv.Visible=false;
					
					if(!IsPostBack)
					{
						password1.Visible=false;
						password2.Visible=false;
						int uID = Convert.ToInt32(Session["UserID"].ToString());
						if (Request.QueryString["id"]!=null && Convert.ToInt32(Request.QueryString["id"])!=1) {
							//if there is query string passed, !=1 meaning, it is not for adding a user, but for editing
							uID = Convert.ToInt32(Request.QueryString["id"]);

						}

						var changeinfo=client.getUser(uID);
						
						fname.Value=changeinfo.Name;
						lname.Value=changeinfo.surname;
						email.Value=changeinfo.email;
						phone.Value=changeinfo.phone;
						
						
					}
				}
				
				//Response.Redirect("MasterHome.aspx");
			}
			else{
				
				selectUType.Value="CU";
			}
        }

        protected void signup_Click(object sender, EventArgs e)
        {
			if(Session["UserType"]==null){
			var hash= HashPass.Secrecy.HashPassword(password1.Value);
				
				
            bool isreg = client.RegUser(fname.Value, lname.Value, email.Value , phone.Value,hash, selectUType.Value);

            if (isreg == true)
            {

                Response.Redirect("logIn.aspx");

            }

			}
            else {

				if (Session["UserType"].ToString() == "MA")
				{
					if (Convert.ToInt32(Request.QueryString["id"]).Equals(1))
					{ //register new user
						var hash = Secrecy.HashPassword(password1.Value);
						bool isreg = client.RegUser(fname.Value, lname.Value, email.Value, phone.Value, hash, selectUType.Value);

						if (isreg == true)
						{

							Response.Redirect("logIn.aspx");

						}

					}

					else if (Request.QueryString["id"] == null)
					{

						selectUType.Value = "MA";
						int id = Convert.ToInt32(Session["UserID"].ToString());
						edituser(id);

					}
					else {
						//edit the given user
						int id = Convert.ToInt32(Request.QueryString["id"]);

						edituser(id);
					}

				}
				else if (Session["UserType"].ToString() == "EM") {
					selectUType.Value = "EM";
					int id = Convert.ToInt32(Session["UserID"].ToString());
					edituser(id);
				}
				else {
					int id = Convert.ToInt32(Session["UserID"].ToString());
					edituser(id);
				}
            }
            
        }

		public void edituser(int id)
		{
			//edit the user account

			bool isEdited = client.EditUser(id, fname.Value, lname.Value, phone.Value, email.Value, selectUType.Value);

			if (isEdited == true)
			{
				Response.Redirect("MasterHome.aspx");
			}

		}
    }
}