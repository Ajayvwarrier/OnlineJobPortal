﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineJobPortal.User
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lbRegisterOrProfile.Text = "Profile";
                lbLoginorLogout.Text = "Logout";
            }
            else
            {
                lbRegisterOrProfile.Text = "Register";
                lbLoginorLogout.Text = "Login";

            }
        }

       
        protected void lbRegisterOrProfile_Click(object sender, EventArgs e)
        {
            if (lbRegisterOrProfile.Text == "Profile")
            {
                Response.Redirect("Profile.aspx");
            }
            else
            {
                Response.Redirect("Register.aspx");
            }
        }

        protected void lbLoginorLogout_Click(object sender, EventArgs e)
        {
            if (lbLoginorLogout.Text == "Login")
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
        }
    }
}