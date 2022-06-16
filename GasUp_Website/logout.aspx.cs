using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null && Session["UserId"] != null) //if user is logged in
            {
                //reset the user 
                Session["UserType"] = null;
                Session["UserId"] = null;
                Session["CartItems"] = 0;
                GasUp.CartItems = new List<ShoppingCart>();
                Response.Redirect("MasterHome.aspx");
            }
            else {
                Response.Redirect("#");
            }
        }
    }
}