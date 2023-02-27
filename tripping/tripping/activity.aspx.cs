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
    public partial class activity : System.Web.UI.Page
    {
        Usermanager um_obj = new Usermanager();
        Activitylist al_obj = new Activitylist();
        Hotel hotel_obj = new Hotel();
        protected void Page_Load(object sender, EventArgs e)
        {
         

            if (!IsPostBack)
            {
              
               Labelid.Text = Request.QueryString["id"];
                int s = Convert.ToInt32 (Labelid.Text);
                HiddenField1.Value = Convert.ToInt32(s).ToString();
                al_obj.PACKAGEID = Convert.ToInt32(s);
               DataListactivity.DataSource = um_obj.activitylisting(s);
                DataListactivity.DataBind();
                hotel_obj.PACKAGE = Convert.ToInt32(s);
                DataListhotel.DataSource = um_obj.hotellist(s);
                DataListhotel.DataBind();

            }
        }

        protected void CheckBoxactivityselect_CheckedChanged(object sender, EventArgs e)
        {
         

            foreach (DataListItem item in DataListactivity.Items)
            {
              
                CheckBox l1 = item.FindControl("CheckBoxactivityselect") as CheckBox;

                if (l1.Checked == true)
                {

                    CheckBox imgbtn = sender as CheckBox;
                    DataListItem gvr = imgbtn.NamingContainer as DataListItem;

                    HiddenField h1 = item.FindControl("HiddenFieldactivityid") as HiddenField;
               
               

                    int v = Convert.ToInt32(h1.Value);
                  

                    HiddenFieldactivityfare.Value = Convert.ToInt32(v).ToString();
                }
        }  
    }

        protected void Buttonpayment_Click(object sender, EventArgs e)
        {
            int id =  Convert.ToInt32(HiddenField1.Value.ToString());
          
            int var = Convert.ToInt32(HiddenFieldactivityfare.Value);
            int hotelfare = Convert.ToInt32(HiddenFieldhotelfare.Value);
            string pf = um_obj.getpackageamount(id).ToString();
            Response.Redirect("Payment.aspx?var=" + var + "&hotelfare=" + hotelfare +"&basicfare=" + pf);
          
          
        }

        protected void CheckBoxhotel_CheckedChanged(object sender, EventArgs e)
        {
            foreach(DataListItem item in DataListhotel.Items)
            {
                CheckBox c1 = item.FindControl("CheckBoxhotel") as CheckBox;
                if(c1.Checked==true)
                {
                    CheckBox imgbtn = sender as CheckBox;
                    DataListItem gvr = imgbtn.NamingContainer as DataListItem;
                    HiddenField h2 = item.FindControl("HiddenFieldhtl") as HiddenField;
                    int v = Convert.ToInt32(h2.Value);
                    HiddenFieldhotelfare.Value = Convert.ToInt32(v).ToString();
                }
            }
        }
    }

      
}
