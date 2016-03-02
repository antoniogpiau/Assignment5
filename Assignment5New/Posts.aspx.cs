using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5New.Models;

namespace Assignment5New
{
    public partial class Posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"].ToString() == Session["LoggedInId"].ToString())
                {
                    LoadPosts();
                    lblUserFullName.Text = Session["LastName"] + ", " + Session["FirstName"];

                    using (ECTDBContext context = new ECTDBContext())
                    {
                        int uId = Int32.Parse(Request.QueryString["id"]);

                        var userPosts = (from p in context.Post
                                              where p.UserId == uId
                                              select new { p.Title, p.Id }).ToList();

                        ddlPosts.DataSource = userPosts;
                        ddlPosts.DataTextField = "Title";
                        ddlPosts.DataValueField = "Id";
                        ddlPosts.DataBind();

                    }
                }
                else {
                    Response.Redirect("login.aspx");
                }
            }
            else {
                Response.Redirect("login.aspx");
            }
        }


        protected void LoadPosts()
        {
            try
            {
                int uId = Int32.Parse(Request.QueryString["id"]);//Session["LoggedInId"]?
                using (ECTDBContext entities = new ECTDBContext())
                {
                    var posts = (from p in entities.Post
                                 //where p.UserId == uId
                                   select p).ToList();
                    rptPosts.DataSource = posts;
                    rptPosts.DataBind();
                }
            }
            catch (Exception)
            {
                lblResults.Text = "An error occurred. Please try again.";
            }
        }

        protected void RemovePost(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx");
            }

            using (ECTDBContext context = new ECTDBContext())
            {
                var selectedPost = Int32.Parse(ddlPosts.SelectedValue);

                var post = (from p in context.Post
                            where selectedPost == p.Id
                            select p).FirstOrDefault();

                if (post != null)
                {
                    context.Post.Remove(post);
                    context.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                    //Response.Redirect("Post.aspx?id=" + Session["LoggedInId"]);
                }
                else
                {
                    lblResults.Text = "This post no longer exists.";
                    Response.Redirect("Post.aspx?id=" + Session["LoggedInId"]);
                }
            }
        }

        protected void AddPost(object sender, EventArgs e)
        {
            if (Session["LoggedInId"] == null)
            {
                Response.Redirect("login.aspx");
            }

            using (ECTDBContext context = new ECTDBContext())
            {
                int id = Int32.Parse(Request.QueryString["id"]);//Session["LoggedInId"]?

                var post = context.Post.Create();
                post.UserId = id;
                post.Title = txtTitle.Text;
                post.Description = txtDescription.Text;
                post.DatePosted = DateTime.Now;

                if (post != null)
                {
                    context.Post.Add(post);
                    context.SaveChanges();
                    Response.Redirect(Request.RawUrl);
                    //Response.Redirect("Post.aspx?id=" + Session["LoggedInId"]);
                }
            }
        }

        protected void LogOut(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }

    }
}