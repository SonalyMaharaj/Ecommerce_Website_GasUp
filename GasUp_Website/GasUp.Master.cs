using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{

    /*KEYS
     id=0
     id=1
    id=3
    id=5
    id=7
    id=999 -->add product
    id=99 --->list of products
     */
    public partial class GasUp : System.Web.UI.MasterPage
    {

        Service1Client client = new Service1Client();
        public static List<ShoppingCart> CartItems = new List<ShoppingCart>();
        public static string province = "";
        public static string city = "";
        public static string town = "";
        public static string home = "";
        public static string postcode = "";
        public static int shippingfee = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null && Session["UserId"] != null)
            {
                var user = client.getUser(Convert.ToInt32(Session["UserId"]));

                string usertag = "<i class='fa fa-user' aria-hidden='true'></i> " + user.Name.Substring(0, 1) + " " + user.surname;

                if (Session["UserType"].ToString() == "CU")
                {
                    var purchase = client.get_purchase_cust(user.Id);
                    prev_purchases.Visible = true;
                    if (purchase != null)
                    {

                        usertag += "<br> points: " + purchase.loyalty_points;
                    }
                    else {
                        usertag += "<br> points: " + 0;
                    }
                    
                    carttext.InnerText = Session["CartItems"].ToString();
                  

                }
              
                welcometag.InnerHtml = usertag;

                loggedin1.Visible = true; //logout and cart
                loggedin2.Visible = false; //login and register

                if (Session["UserType"].ToString() == "MA") {  //if the UserType is manager
                    usertag = "<i class='fa fa-user' aria-hidden='true'></i> Manager Mode: " + user.Name.Substring(0,1) + " " + user.surname;
                    welcometag.InnerHtml = usertag;
                    customer_account.Visible = false;
                    add_product.Visible = true;
                    edit_product.Visible = true;
                    delete_product.Visible = true;
                    reports.Visible = true;
                    Manager_userOpt.Visible = true;
                }
                else if (Session["UserType"].ToString() == "EM") {
                    customer_account.Visible = false;
                    emp_navbar.Visible = true;
                }
                /*
                string innerhtml = "<a href='Add_Product.aspx?id=" +99 + "'>Edit Product</a>"; //when the manager clicks specifically on the editproduct from the nav bar
                edit_product.InnerHtml = innerhtml;

                int editproductid =0;
                editproductid = Convert.ToInt32( Request.QueryString["id"]);

                if (editproductid==99 || editproductid == 999) {

                    topbar.Visible = false;
                }
                */



            }
        }
    }
}