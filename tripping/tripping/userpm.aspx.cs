using BLL.ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class userpm : System.Web.UI.Page
    {
        userpmmanager user_Obj = new userpmmanager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                GridviewBind();
       
            }
        }
        public void GridviewBind()
        {

            GridView1.DataSource = user_Obj.listofdetails();
            GridView1.DataBind();
        }
        public void listofdetails()
        {

        }
        


            
    }
}


