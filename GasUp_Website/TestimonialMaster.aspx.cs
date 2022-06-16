using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class TestimonialMaster : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            string innerhtml = "";

            var tests = client.GetTestimonials();
            if (Request.QueryString["id"]!=null && Convert.ToInt32(Request.QueryString["id"]).Equals(1)) {
                foreach (var a in tests) {
                    var user = client.getUser(a.Customer_Id);
                    innerhtml += "<blockquote>" + a.Testimonial_description + "</blockquote>";
                    innerhtml += "<figure class='clear'><img src='images/demo/anon.png' alt=''>";
                    innerhtml += "<figcaption>";
                    innerhtml += "<h6 class='heading'>" + user.Name + "</h6>";
                    innerhtml += "<em>GasUp!!</em></figcaption>";
                    innerhtml += "</figure>";
                }
         
            }
            if (Session["UserType"]!=null) {
                testimonial_div.Visible = true;
                testimonial_label.InnerHtml = "Write Your Testimonial:";
            }
            idtestimonials.InnerHtml = innerhtml;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool isadded = client.add_testimonial(Convert.ToInt32(Session["UserId"]), txttestimonial.Value);

            if (isadded==true){
                Response.Redirect("TestimonialMaster.aspx");
            }
        }
    }
}