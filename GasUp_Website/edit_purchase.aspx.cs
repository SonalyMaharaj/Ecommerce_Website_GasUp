using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class edit_purchase : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string prepath = "images\\demo\\";
            if (Session["UserType"].Equals("MA") && Session["UserId"] != null)
            {
                var id = 0;

                id = Convert.ToInt32(Request.QueryString["pre"]);
                var purchase = client.get_purchase(id);
               




                if (purchase != null)
                {
                    var customer = client.getUser(purchase.Customer_id);

                    pagetitle.InnerHtml = "<h1>"+customer.Name + " " + customer.surname + "</h1>";

                    string innerhtml = "<img src=" + prepath + "logo.png alt='A Short description of image' class='img_resize'/>";
                   
                    pro_img.InnerHtml = innerhtml;

                   
                    var product = client.getProduct(purchase.Product_id);
                    if (!IsPostBack)
                    {
                        /*
                        innertexts+= customer.Name+"</br>";
                        innertexts += customer.surname + "</br>";
                        innertexts += customer.email + "</br>";
                        innertexts += product.Product_Category + ": " + product.Product_Size + "</br>";
                        
                        innertexts += purchase.delivery_Address + "</br>";
                        innertexts += Convert.ToString(purchase.loyalty_points) + "</br>";*/
                        authorized_purchase.Value = Convert.ToString(true);
                      
                        //assistant.Value = purchase.Assistant;
                        //product image here

                    }
                    //innertexts += "</h3>";
                   // display.InnerHtml = innertexts;
                }


                else
                {
                    string innerhtml = "<img src=" + prepath + "logo.png alt='A Short description of image' class='img_resize'/>";
                    pro_img.InnerHtml = innerhtml;
                }
                bool isedited = client.Edit_purchase(Convert.ToInt32(Request.QueryString["pre"]), Convert.ToBoolean(authorized_purchase.Value));

                //pass this user to the listpurchases(populated by list of employees)
                if (isedited == true)
                {
                    Response.Redirect("listpurchases.aspx?pre=" + Request.QueryString["pre"]);
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void editpurchase_Click(object sender, EventArgs e)
        {
           
        }
    }
}