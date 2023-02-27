using BLL.USER.Manager;
using BLL.USER.Property;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping
{
    public partial class Homepage : System.Web.UI.Page
    {
        Usermanager usermanager_obj = new Usermanager();
        packagelist pl_obj = new packagelist();
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dropdownlistlocation();
            }
        }

        
        protected void Dropdownlistlocation()
        {
            DropDownListlocations.DataSource = usermanager_obj.locationdropdownlist();
            DropDownListlocations.DataTextField = "Name";
            DropDownListlocations.DataValueField = "Id";
            DropDownListlocations.DataBind();
        }

       

      


      

        protected void Buttonpackage_Click(object sender, EventArgs e)
        {
            HiddenFieldpacklist.Value = DropDownListlocations.SelectedItem.Value;
            usermanager_obj.pl_obj.LOCATIONID = int.Parse(HiddenFieldpacklist.Value);


            DataListlistpack.DataSource = usermanager_obj.packagelisting();
            DataListlistpack.DataBind();
        }

        protected void Buttonviewmore_Click(object sender, EventArgs e)
        {
            foreach (DataListItem item in DataListlistpack.Items)
            {
                HiddenField h1 = item.FindControl("HiddenField1") as HiddenField;
                int v = Convert.ToInt32(h1.Value);
                Button imgbtn = sender as Button;
                DataListItem gvr = imgbtn.NamingContainer as DataListItem;
                HiddenFieldpackageid.Value = DataListlistpack.DataKeys[gvr.TabIndex].ToString();
                //
                //HiddenFieldpackageid.Value = pl_obj.PACKAGE_ID.ToString();
                int s = int.Parse(HiddenFieldpackageid.Value);
                Response.Redirect("activity.aspx?id=" + s );
            }
        }
    }
}