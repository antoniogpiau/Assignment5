﻿using System;
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
                post.Content = txtPost.Text;
                post.DatePosted = DateTime.Now;

                if (post != null)
                {
                    context.Post.Add(post);
                    context.SaveChanges();
                    Response.Redirect("Post.aspx?id=" + Session["LoggedInId"]);
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