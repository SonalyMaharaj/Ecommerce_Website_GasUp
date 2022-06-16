using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class delete_product : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null && Session["UserType"].ToString().Equals("MA")) {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                bool isdeleted = client.remove_product(id);

                if (isdeleted == true)
                {
                    Response.Redirect("ListOfUsers.aspx?id=9");

                }
                else {
                    Response.Redirect("#");
                }
            }
            

        }
    }
}