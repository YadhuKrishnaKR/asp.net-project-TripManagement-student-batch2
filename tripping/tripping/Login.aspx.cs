using BLL.ADMIN;
using BLL.PROPERTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class Login : System.Web.UI.Page
    {
        loginmanager StuRegMngr_Obj = new loginmanager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {



            }

        }



        public void RoleSelect()
        {
            StuRegMngr_Obj.log_Obj.UserName = TextBoxusername.Text.Trim().ToString();
            StuRegMngr_Obj.log_Obj.Password = TextBoxpassword.Text.Trim().ToString();
            userProperty user = new userProperty();
            user = StuRegMngr_Obj.RoleSelect();

            if (user.Role != null)
            {
                Session["UserId"] = user.UserId;
                Session["Role"] = user.Role;
                // need to change redirect page
                Response.Redirect("signup.aspx");
            }

            else
            {

                Label.Visible = true;
                Label.Text = "login  error";

            }


        }


        protected void Buttonlogin_Click(object sender, EventArgs e)
        {
            RoleSelect();

        }


        protected void Buttonsignup_Click(object sender, EventArgs e)
        {

            //if (Buttonsignup.ValidationGroup == "a" && Page.IsValid == true)
            //{
                Response.Redirect("signup.aspx");
            //}
        }
    }

}


