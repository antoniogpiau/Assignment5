using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5New.Models;

namespace Assignment5New
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            if (Request.QueryString["error"] != null)
            {
                lblResults.Text = "You are not authorized to view pages until you login.";
            }
        }


        protected void Login(object sender, EventArgs e)
        {

            using (ECTDBContext context = new ECTDBContext())
            {
                var user = (from u in context.User
                            where u.Username == txtUsername.Text && u.Password == txtPassword.Text
                            select u).FirstOrDefault();

                if (user != null)
                {
                    Session["LoggedInId"] = user.Id.ToString();
                    Session["FirstName"] = user.FirstName;
                    Session["LastName"] = user.LastName;
                    Session["Username"] = user.Username;
                    Session["Email"] = user.Email;
                    lblResults.Text = "";

                    Response.Redirect("Posts.aspx?id="+ Session["LoggedInId"]);
                }
                else
                {
                    lblResults.Text = "User Name or Password are incorrect.";
                }

           }
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }


        }
}