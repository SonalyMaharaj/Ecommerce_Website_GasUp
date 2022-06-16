using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class Removefromcart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            GasUp.CartItems.RemoveAt(id);
            int items = Convert.ToInt32(Session["CartItems"].ToString());
            items -=1;
            Session["CartItems"] = items;
            Response.Redirect("Cart.aspx");

        }
    }
}