using BLL.ADMIN;
using BLL.PROPERTY;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class tripadmin : System.Web.UI.Page
    {
        tripmanager trpmngr_Obj = new tripmanager();
        email email_obj = new email();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                pmBind();


            }
        }
        public void pmBind()
        {
            GridView1.DataSource = trpmngr_Obj.SellectAllpm();
            GridView1.DataBind();
        }

        protected void dlt_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }
        public void pmDelete()
        {
            trpmngr_Obj.reg.APPUSER_ID = int.Parse(HiddenField1.Value);
            string result = trpmngr_Obj.pmDelete();


            HiddenField1.Value = "-1";

            if (result == "Success")
            {


                Label1.Visible = true;
                Label1.Text = "Successfully Deleted";
                Clear();

            }
            else if (result == "Error")
            {
                Label1.Visible = true;
                Label1.Text = "failed due to some  error";
                Clear();
            }

            else if (result == "Already exist")
            {
                Label1.Visible = true;
                Label1.Text = "Already Exist";
                Clear();
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "failed due to some technical error";
                Clear();
            }
            pmBind();
        }
        public void pminsert()
        {

            trpmngr_Obj.reg.APPUSER_NAME = TextBox2.Text.Trim().ToString();
            trpmngr_Obj.reg.EMAIL = TextBox3.Text.Trim().ToString();
            trpmngr_Obj.reg.CONTACT = TextBox4.Text.Trim().ToString();
            trpmngr_Obj.reg.STATUS = TextBox10.Text.Trim().ToString();
            trpmngr_Obj.reg.PASSWORD = TextBox5.Text.Trim().ToString();
          
            string result = trpmngr_Obj.pmInsert();

            HiddenField1.Value = "-1";
            if (result == "Success")
            {
                Label6.Visible = true;
                Label6.Text = "Inserted Successfully";
                Clear();

            }
            else if (result == "Already Exist")
            {
                Label6.Visible = true;
                Label6.Text = "alreaddy Exist";
                Clear();

            }
            else if (result == "Error")
            {
                Label6.Visible = true;
                Label6.Text = "failed due to error";
                Clear();

            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "failed due to some technical error";
                Clear();
            }
            pmBind();
        }

        protected void save_Click(object sender, EventArgs e)
        {
            pminsert();
            SendMail();


        }

        public void SendMail()
        {

            var host = "smtp.gmail.com";
            var port = 587;

            var username = "tripping.manage.official@gmail.com"; // get from Mailtrap
            var password = "athbirwmszunyunm"; // get from Mailtrap

            var message = new MimeMessage();


            message.From.Add(new MailboxAddress("Admin", email_obj.From));
            message.To.Add(new MailboxAddress("Admin",trpmngr_Obj.reg.EMAIL));
            message.Subject = email_obj.Subject;

            var bodyBuilder = new BodyBuilder();
            //bodyBuilder.HtmlBody = "<h3>USERNAME</h3>";
            bodyBuilder.HtmlBody = "UserName="+trpmngr_Obj.reg.APPUSER_NAME +"\n"+
                                    "Password="+ trpmngr_Obj.reg.PASSWORD;
            //bodyBuilder.HtmlBody = "<h3>PASSWORD</h3>";
            //bodyBuilder.TextBody = trpmngr_Obj.reg.PASSWORD;
            message.Body = bodyBuilder.ToMessageBody();

            var client = new SmtpClient();

            client.Connect(host, port, SecureSocketOptions.Auto);
            client.Authenticate(username, password);

            client.Send(message);
            client.Disconnect(true);

            //Console.WriteLine("Email sent");

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox10.Text = "";
        }
        public void Clear()
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox10.Text = "";
        }

        protected void btndlt_Click(object sender, EventArgs e)
        {
            Button imgbtn = sender as Button;
            GridViewRow gvr = imgbtn.NamingContainer as GridViewRow;
            HiddenField1.Value = GridView1.DataKeys[gvr.RowIndex].Value.ToString();
            pmDelete();
        }
    }
}   
