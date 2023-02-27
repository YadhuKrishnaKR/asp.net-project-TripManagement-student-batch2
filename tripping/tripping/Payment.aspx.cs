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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBoxbasicfare.Text =  Request.QueryString["basicfare"];
               TextBoxactivityfare.Text = Request.QueryString["var"];
               TextBoxhotelfare.Text = Request.QueryString["hotelfare"];
                TextBoxtotal.Text = TextBoxbasicfare.Text + TextBoxactivityfare.Text + TextBoxhotelfare.Text;
            }
        }
    }
}