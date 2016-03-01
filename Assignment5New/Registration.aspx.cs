using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5New.Models;

namespace Assignment5New
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (ECTDBContext context = new ECTDBContext())
                {
                    var user = context.User.Create();
                    user.FirstName = tbFirstName.Text;
                    user.LastName = tbLastName.Text;
                    user.Username = tbUsername.Text;
                    user.Password = tbPassword.Text;

                    if (user != null)
                    {
                        context.User.Add(user);
                        context.SaveChanges();
                        Response.Redirect("login.aspx");
                    }
                }
            }//else{print error message}
        }
    }
}
