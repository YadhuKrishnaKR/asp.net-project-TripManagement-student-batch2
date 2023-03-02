using BLL.USER.Manager;
using BLL.USER.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class Payment : System.Web.UI.Page
    {
        Booking booking_obj = new Booking();
        Usermanager um_obj = new Usermanager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserId"] == null || !Session["Role"].ToString().Equals("User"))
                    Response.Redirect("Login.aspx");


                HiddenFieldhotelid.Value = Request.QueryString["hotelid"];
                HiddenFieldpid.Value = Request.QueryString["packageid"];
                HiddenFieldactid.Value = Request.QueryString["actid"];
                TextBoxbasicfare.Text =  Request.QueryString["basicfare"];
               TextBoxactivityfare.Text = Request.QueryString["var"];
               TextBoxhotelfare.Text = Request.QueryString["hotelfare"];
                int s = Convert.ToInt32(TextBoxbasicfare.Text);
                int v = Convert.ToInt32(TextBoxactivityfare.Text);
                int h = Convert.ToInt32(TextBoxhotelfare.Text);
                
                int c = s + v + h;
                TextBoxtotal.Text = Convert.ToInt32(c).ToString();
             // int total = Convert.ToInt32 (TextBoxtotal.Text);
             //int pid = Convert.ToInt32(HiddenFieldpid.Value);
             //int hid = Convert.ToInt32(HiddenFieldhotelid.Value);
             //   int uid = Convert.ToInt32 (Session["UserId"]);
             //   um_obj.bookinginsert(total,pid,hid,uid);

            }
        }

        protected void Buttonproceed_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(TextBoxtotal.Text);
            int pid = Convert.ToInt32(HiddenFieldpid.Value);
            int hid = Convert.ToInt32(HiddenFieldhotelid.Value);
            int uid = Convert.ToInt32( Session["UserId"]);
            int activityid = Convert.ToInt32(HiddenFieldactid.Value);
            string result= um_obj.bookinginsert(total, pid, hid, uid,activityid);
            if(result== "Booking sucess")
            {
                Labelbooking.Visible = true;
                Labelbooking.Text = "Booking Sucessfull";
            }
            else if(result== "Booking Failed")
            {
                Labelbooking.Visible = true;
                Labelbooking.Text = "Booking Failed";
              
            }
            else
            {
                Labelbooking.Visible = true;
                Labelbooking.Text = "Failed";
            }
            
        }
    }
}