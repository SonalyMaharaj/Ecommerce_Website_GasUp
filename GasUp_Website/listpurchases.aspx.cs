using GasUp_Website.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GasUp_Website
{
    public partial class listpurchases : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {


            //id=98 --> list of users
            //id=99 --> list of products
            if (Session["UserType"].ToString().Equals("MA"))
            {

                if (Request.QueryString["cocid"] != null) {
                    //when the Manager requests the list of Coc Applications
                    String innerhtml = "<table>";
                    innerhtml += "<tr>";
                    innerhtml += "<th>Email</th>";
                    innerhtml += "<th>Phone</th>";
                    innerhtml += "<th>Installation</th>";

                    var CocList = client.getCocApplications();

                    foreach (var a in CocList) {
                        innerhtml += "<tr>";
                        innerhtml += "<td>" + a.Apply_Email + "</td>";
                        innerhtml += "<td>" + a.Apply_PhoneNumber + "</td>";
                        innerhtml += "<td>" + a.Apply_Install + "</td>";
                        innerhtml += "</tr>";
                    }
                    innerhtml += "</table>";
                    usertable.InnerHtml = innerhtml;
                }


                else if (Request.QueryString["tasked"] != null)
                {


                    //list of users
                    String innerhtml = "<table>";
                    innerhtml += "<tr>";
                    innerhtml += "<th>Name</th>";
                    innerhtml += "<th>Surname</th>";
                    innerhtml += "<th>Email</th>";
                    innerhtml += "<th>Assigned Task</th>";
                    innerhtml += "<th>Task Complete</th>";
                    innerhtml += "<th>Un-assign</th>";
                    innerhtml += "</tr>";
                    someinfo.InnerText = "List of TASKED Employees...................";

                   
                    if (Request.QueryString["unassign"] != null)
                    {
                        client.Unassign_Task(Convert.ToInt32(Request.QueryString["unassign"]),1);
                        Response.Redirect("listpurchases.aspx?pre=" + Convert.ToInt32(Request.QueryString["pre"]));
                    }
                  

                    

                    User toadd = new User();

                    var tasks = client.get_TaskedEmployees();



                    //display the employess not assigned

                    foreach (var b in tasks)
                    {

                        var a = client.getUser(b.emp_id);
                        var purchase = client.get_purchase(b.Task_ID);
                       // var task = client.getTaskid(b);
                        if (a.UserType.Equals("EM")) //display only employees
                        {

                            innerhtml += "<tr>";
                            innerhtml += "<td>" + a.Name + "</td>";
                            innerhtml += "<td>" + a.surname + "</td>";
                            innerhtml += "<td>" + a.email + "</td>";


                            innerhtml += "<td><a href='AboutProduct.aspx?PID=" + purchase.Product_id + "&pre=" + purchase.Id + "'><ul>" + purchase.delivery_date + "</ul></a></td>";
                            innerhtml += "<td>"+b.task_done+"</td>";

                            innerhtml += "<td><Button><a href='listpurchases.aspx?pre=" + purchase .Id+ "&unassign=" + b.id + "&tasked=0'>Un_Assign</a></Button></td>";
                            innerhtml += "</tr>";
                        }

                    }
                    innerhtml += "</table>";
                    usertable.InnerHtml = innerhtml;
                  
                }

                else if (Request.QueryString["contactus"] != null) {
                    //when the Manager requests the list of Coc Applications
                    String innerhtml = "<table>";
                    innerhtml += "<tr>";
                    innerhtml += "<th>Name</th>";
                    innerhtml += "<th>Surname</th>";
                    innerhtml += "<th>Email</th>";
                    innerhtml += "<th>Phone</th>";
                    innerhtml += "<th>Query</th>";

                    var queries = client.getQueries();

                    foreach (var a in queries) {
                        innerhtml += "<tr>";
                        innerhtml += "<td>" + a.Query_Name + "</td>";
                        innerhtml += "<td>" + a.Query_Surname + "</td>";
                        innerhtml += "<td>" + a.Query_Email + "</td>";
                        innerhtml += "<td>" + a.Query_PhoneNumber + "</td>";
                        innerhtml += "<td>" + a.Query_Message + "</td>";
                        innerhtml += "</tr>";
                    }
                    innerhtml += "</table>";
                    usertable.InnerHtml = innerhtml;
                }
                else {
                    //list of users
                    String innerhtml = "<table>";
                    innerhtml += "<tr>";
                    innerhtml += "<th>Name</th>";
                    innerhtml += "<th>Surname</th>";
                    innerhtml += "<th>Email</th>";
                    if (Request.QueryString["pre"] != null) {

                        someinfo.InnerText = "List of Employees...................";
                        if (Request.QueryString["assistant"] != null) {
                            //
                            client.Assign_Task(Convert.ToInt32(Request.QueryString["assistant"]), Convert.ToInt32(Request.QueryString["pre"]),1);
                        }
                     

                        innerhtml += "<th>Assigned Task</th>";
                        innerhtml += "<th>assign</th>";
                        //innerhtml += "<th>Un-assign</th>";
                        innerhtml += "</tr>";

                        User toadd = new User();

                        var employees = client.GetUsers();
                        List<User> todisplay = new List<User>(employees);

                        //display the employess not assigned

                        foreach (var a in todisplay)
                        {
                            if (a.UserType.Equals("EM")) //display only employees
                            {
                                var emp_task = client.get_TaskedEmployee(a.Id);

                                innerhtml += "<tr>";
                                innerhtml += "<td>" + a.Name + "</td>";
                                innerhtml += "<td>" + a.surname + "</td>";
                                innerhtml += "<td>" + a.email + "</td>";
                                if (emp_task != null)
                                {
                                    var tasks = client.num_tasks(a.Id);
                                    innerhtml += "<td><ul>Number of tasks: "+ tasks + "</ul></td>";
                                }
                                else
                                {
                                    innerhtml += "<td><ul>Number of tasks: 0</ul></td>";
                                }
                                if (Request.QueryString["unassign"]==null) {
                                    innerhtml += "<td><Button><a href='listpurchases.aspx?pre=" + Convert.ToInt32(Request.QueryString["pre"]) + "&assistant=" + a.Id + "'>Assign</a></Button></td>";

                                }
                                innerhtml += "</tr>";
                            }

                        }
                    }
                    else {
                        someinfo.InnerText = "List of purchases..........";
                        innerhtml += "<th>Product</th>";
                        innerhtml += "<th>delivery address</th>";
                        innerhtml += "<th>delivery date</th>";
                        innerhtml += "<th>Authorized</th>";
                        innerhtml += "<th>loyalty points</th>";

                        innerhtml += "</tr>";

                        var purchases = client.get_purchases();

                        foreach (var a in purchases)
                        {
                            //<div contenteditable>I'm editable</div>
                            //we going to use a pre to have a new combination of query strings for the listpurchases
                            var customer = client.getUser(a.Customer_id);
                            var product = client.getProduct(a.Product_id);
                            if (product != null)
                            {
                                innerhtml += "<tr>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.Name + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.surname + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.email + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + product.Product_Category + ": " + product.Product_Description + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.delivery_Address + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.delivery_date + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.Authorized + "</u></a></td>";
                                innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.loyalty_points + "</u></a></td>";

                                innerhtml += "</tr>";
                            }
                            else {
                                //INSTALLATIONS BOOKED
                                var installation = client.getInstallation(a.Product_id);
                                if (installation!=null) {

                                    innerhtml += "<tr>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.Name + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.surname + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + customer.email + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + installation.Install_Name + ": INSTALLATION:" + installation.Install_Description + " Duration: " + installation.Install_Duration +"hrs" + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.delivery_Address + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.delivery_date + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.Authorized + "</u></a></td>";
                                    innerhtml += "<td><a href='edit_purchase.aspx?" + customer.Name + "=0&pre=" + a.Id + "'><u>" + a.loyalty_points + "</u></a></td>";

                                    innerhtml += "</tr>";

                                }
                            }
                           



                        }
                    }
                    innerhtml += "</table>";


                    usertable.InnerHtml = innerhtml;
                }

            }
            else if (Session["UserType"].ToString().Equals("EM")) {
                if (Request.QueryString["taskdone"] != null)
                {
                    int taskid = Convert.ToInt32(Request.QueryString["taskdone"]);
                    client.task_done(taskid, "YES"); //send message to manager that task is done
                }
                else if (Request.QueryString["tasknotdone"] !=null) {
                    int taskid = Convert.ToInt32(Request.QueryString["tasknotdone"]);
                    client.task_done(taskid,"NO"); //send message to manager that task is done
                }
                someinfo.InnerText = "Outstanding Tasks..........";
                String innerhtml = "<table>";
                innerhtml += "<tr>";
                innerhtml += "<th>Name</th>";
                innerhtml += "<th>Surname</th>";
                innerhtml += "<th>Email</th>";
                innerhtml += "<th>Product</th>";
                innerhtml += "<th>delivery address</th>";
                innerhtml += "<th>delivery date</th>";
                innerhtml += "<th>Authorized</th>";
                innerhtml += "<th>Task Done</th>";
                innerhtml += "<th>Validate</th>";
                innerhtml += "<th>Validate</th>";
                var tasks = client.get_TaskedEmployees();

                
                foreach(var task in tasks){ 
                if (task != null && task.emp_id.Equals(Convert.ToInt32(Session["Userid"]))) {
                    
                    var purchase = client.get_purchase((int)task.Task_ID);
                    var customer = client.getUser(purchase.Customer_id);
                    var product = client.getProduct(purchase.Product_id);
                     
                    innerhtml += "<tr>";
                    innerhtml += "<td><u>" + customer.Name + "</u></td>";
                    innerhtml += "<td><u>" + customer.surname + "</u></td>";
                    innerhtml += "<td><u>" + customer.email + "</u></td>";
                        if (product != null)
                        {
                            innerhtml += "<td><u>" + product.Product_Category + ": " + product.Product_Description + "</u></td>";
                        }
                        else {
                            //Installation Booked

                            var installation = client.getInstallation(purchase.Product_id);
                            if (installation != null)
                            {
                                innerhtml += "<td>INSTALLATION:" + installation.Install_Description + " Duration: " + installation.Install_Duration + "hrs</td>";
                            }
                        }
                   
                    innerhtml += "<td><u>" + purchase.delivery_Address + "</u></td>";
                    innerhtml += "<td><a href='AboutProduct.aspx?PID=" + purchase.Product_id + "&pre=" + purchase.Id + "'><u>" + purchase.delivery_date + "</u></a></td>";
                    innerhtml += "<td><u>" + purchase.Authorized + "</u></td>";
                    innerhtml += "<td><u>" + task.task_done + "</u></td>";
                        
                    innerhtml += "<td><Button><a href='listpurchases.aspx?taskdone=" + task.id + "&tasked=0'>Task done</a></Button></td>";
                        innerhtml += "<td><Button><a href='listpurchases.aspx?tasknotdone=" + task.id + "&tasked=0'>Not done</a></Button></td>";


                        innerhtml += "</tr>";
                    

                }
            }
                innerhtml += "</table>";
                usertable.InnerHtml = innerhtml;

            }

            else
            {
                Response.Redirect("MasterHome.aspx");
            }

        }

    }
    
}