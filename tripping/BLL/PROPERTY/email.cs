using BLL.ADMIN;

using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL.PROPERTY
{
    public class email
    {
        public string From = "tripping.manage.official@gmail.com";
        public string To { get; set; }
        public string Subject = "Login Details";
        public string Body { get; set; }
    
        //  void sendmail()
        //    {
        //email email_obj = new email();
        //tripmanager trpmngr_Obj = new tripmanager();
        //var host = "smtp.gmail.com";
        //var port = 587;

        //var username = "tripping.manage.official@gmail.com"; // get from Mailtrap
        //var password = "athbirwmszunyunm"; // get from Mailtrap

        //var message = new MimeMessage();


        //message.From.Add(new MailboxAddress("Admin", email_obj.From));
        //message.To.Add(new MailboxAddress("Admin", trpmngr_Obj.reg.EMAIL));
        //message.Subject = email_obj.Subject;

        //    var bodyBuilder = new BodyBuilder();
        //        bodyBuilder.HtmlBody = "<h3>USERNAME</h3>"; 
        //        bodyBuilder.TextBody=trpmngr_Obj.reg.APPUSER_NAME;
        //        bodyBuilder.HtmlBody = "<h3>PASSWORD</h3>";
        //        bodyBuilder.TextBody = trpmngr_Obj.reg.PASSWORD;
        //        message.Body = bodyBuilder.ToMessageBody();

        //    var client = new SmtpClient();

        //client.Connect(host, port, SecureSocketOptions.Auto);
        //client.Authenticate(username, password);

        //client.Send(message);
        //client.Disconnect(true);

        //Console.WriteLine("Email sent");
        //  } 
    
}   }

