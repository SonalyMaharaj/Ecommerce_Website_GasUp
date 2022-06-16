using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class ListOfUsers : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            //id=98 --> list of users
            //id=99 --> list of products
            if (Session["UserType"].ToString().Equals("MA") && Convert.ToInt32(Request.QueryString["id"]).Equals(98)) {
                //list of users
                String innerhtml = "<table>";
                innerhtml += "<tr>";
                innerhtml += "<th>Name</th>";
                innerhtml += "<th>Surname</th>";
                innerhtml += "<th>Email</th>";
                innerhtml += "<th>Phone Number</th>";
                innerhtml += "<th>User Type</th>";

      
                innerhtml += "</tr>";

                var users = client.GetUsers();

                foreach (var a in users)
                {

                    if (!a.UserType.Equals("MA")) //we do not want the manager to be displayed on the list of users
                    { 
                    innerhtml += "<tr>";
                    innerhtml += "<td><a href='Register.aspx?id=" + a.Id + "'><u>" + a.Name + "</u></a></td>";
                    innerhtml += "<td><a href='Register.aspx?id=" + a.Id + "'><u>" + a.surname + "</u></a></td>";
                    innerhtml += "<td><a href='Register.aspx?id=" + a.Id + "'><u>" + a.email + "</u></a></td>";
                    innerhtml += "<td><a href='Register.aspx?id=" + a.Id + "'><u>" + a.phone + "</u></a></td>";
                    String usertype = "";
                    if (a.UserType.Equals("CU"))
                    {
                        usertype = "Customer";
                    }
                    else if (a.UserType.Equals("EM"))
                    {
                        usertype = "Employee";
                    }
                    else
                    {
                        usertype = "UKNOWN##";
                    }

                    innerhtml += "<td><a href='Register.aspx?id=" + a.Id + "'><u>" + usertype + "</u></a></td>";
                    innerhtml += "</tr>";

                }
                }
                innerhtml += "</table>";
                usertable.InnerHtml = innerhtml;
            }

            else if (Session["UserType"].ToString().Equals("MA") && Convert.ToInt32(Request.QueryString["id"]).Equals(99) || Convert.ToInt32(Request.QueryString["id"]).Equals(9)) {

                //list of users
                String innerhtml = "<table>";
                innerhtml += "<tr>";
                innerhtml += "<th>Size</th>";
                innerhtml += "<th>Price</th>";
                innerhtml += "<th>Category</th>";
                innerhtml += "<th>Availability</th>";
                innerhtml += "<th>Description</th>";
                innerhtml += "<th>Image</th>";

                if (Convert.ToInt32(Request.QueryString["id"]).Equals(9))
                {

                    innerhtml += "<th>Remove</th>";
                }

                innerhtml += "</tr>";

                var users = client.getProducts();

                foreach (var a in users)
                {//img src = "img_girl.jpg" alt = "Girl in a jacket" width = "500" height = "600"

                    innerhtml += "<tr>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><u>" + a.Product_Size + "</u></a></td>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><u>" + a.Product_Price + "</u></a></td>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><u>" + a.Product_Category + "</u></a></td>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><u>" + a.Product_Availability + "</u></a></td>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><u>" + a.Product_Description + "</u></a></td>";
                    innerhtml += "<td><a href='Add_Product.aspx?id=" + a.Product_Id + "'><img src='images\\demo\\" + a.Product_image + "' alt='' widht='300' style='height: 200px'></img></a></td>";
                    if (Convert.ToInt32(Request.QueryString["id"]).Equals(9)) {
                        innerhtml += "<td><button type='button' style='background-color:red;color:white'><a href='delete_product.aspx?id=" + a.Product_Id + "'> X</a></button></td>";
                    }
                                    
                    innerhtml += "</tr>";


                }
                innerhtml += "</table>";
                usertable.InnerHtml = innerhtml;

            }
            else {
                Response.Redirect("MasterHome.aspx");
            }

        }
    }
}