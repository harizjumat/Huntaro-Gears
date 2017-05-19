using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.
                ConnectionStrings["db_1525593_co5027ConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //Create new user and try to store in DB.
            IdentityUser user = new IdentityUser();
            user.UserName = txtUserName.Text;

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //Create user object.
                    //Database will be created / expanded automatically.
                    IdentityResult result = manager.Create(user, txtPassword.Text);

                    if (result.Succeeded)
                    {
                        //Store user in DB
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //Set to log in new user by Cookie.
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //Log in the new user and redirect to homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }
            }
            else
            {
                litStatus.Text = "Passwords must match";
            }
        }
    }
}