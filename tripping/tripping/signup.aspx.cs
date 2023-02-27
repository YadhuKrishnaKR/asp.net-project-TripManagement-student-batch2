using BLL.ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class signup : System.Web.UI.Page
    {
        signupmanager SignupMngr_Obj = new signupmanager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {



            }

        }
        //public void Rolling()
        //{
        //    SignupMngr_Obj.sig_Obj.name = TextBoxname.Text.Trim().ToString();
        //    SignupMngr_Obj.sig_Obj.Email = TextBoxemail.Text.Trim().ToString();
        //    SignupMngr_Obj.sig_Obj.contactno = TextBoxcontactno.Text.Trim().ToString();
        //    SignupMngr_Obj.sig_Obj.Password = TextBoxpassword.Text.Trim().ToString();
        //    //SignupMngr_Obj.sig_Obj.role = DropDownList1.SelectedValue;
        //    string result = SignupMngr_Obj.Rolling();


        //    if (result == "User")
        //    {


        //        Response.Redirect("Login.aspx");

        //    }
        //    else if (result == "Manager")
        //    {
        //        Response.Redirect("Login.aspx");
        //    }






        //}

        public void signupinsert()
        {
            SignupMngr_Obj.sig_Obj.name = TextBoxname.Text.Trim().ToString();
            SignupMngr_Obj.sig_Obj.Email = TextBoxemail.Text.Trim().ToString();
            SignupMngr_Obj.sig_Obj.contactno = TextBoxcontactno.Text.Trim().ToString();
            SignupMngr_Obj.sig_Obj.Password = TextBoxpassword.Text.Trim().ToString();
            //SignupMngr_Obj.sig_Obj.role = DropDownList1.SelectedValue;
            SignupMngr_Obj.sig_Obj.role = "User";
            string result = SignupMngr_Obj.signupinsert();
            if (result == "Success")
            {

                Labelmsg.Visible = true;
                Labelmsg.Text = "Inserted Successfully";

                if(SignupMngr_Obj.sig_Obj.role== "Manager")
                    Response.Redirect("Login.aspx");
                else
                    Response.Redirect("Login.aspx");

            }
            else if (result == "Error")
            {
                Labelmsg.Visible = true;
                Labelmsg.Text = "failed due to error";

            }
        }

        protected void Buttonsignup_Click(object sender, EventArgs e)
        {
            signupinsert();
         //   Response.Redirect("Login.aspx");

        }
      
        }
    }




