using BLL.ADMIN.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class MyBooking : System.Web.UI.Page
    {
        MybookingManager booking = new MybookingManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Session["UserId"] == null || !Session["Role"].ToString().Equals("User"))
                    Response.Redirect("Login.aspx");
                DataListBind();
            }
        }
        public void DataListBind()
        {
            DataList1.DataSource = booking.SelectAllDetails();
            DataList1.DataBind();
        }

        
    }
}