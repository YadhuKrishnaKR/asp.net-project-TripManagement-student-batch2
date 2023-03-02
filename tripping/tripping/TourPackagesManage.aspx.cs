using BLL.ADMIN.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace tripping.PackageManagers
{
    public partial class TourPackagesManage : System.Web.UI.Page
    {
        TourmanagingManager manager = new TourmanagingManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               // Session["UserId"] = 1;
               if(Session["UserId"]==null || !Session["Role"].ToString().Equals("Manager"))
                    Response.Redirect("Login.aspx");
                view_allLocation();
                PackageBind();
            }
        }
        public void PackageBind()
        {
            GridView1.DataSource = manager.SelectAllDetails();
            GridView1.DataBind();
        }
        private string GetRandomText()
        {
            string randomtext = "";
            string alphabet = "0123456789";
            Random r = new Random();

            for (int j = 0; j <= 3; j++)
            {
                randomtext += alphabet[r.Next(alphabet.Length)];
            }
            return randomtext;
        }
        public void InsertPackages()
        {
            if(fupackagephoto.HasFile == true)
            {
                string filename = GetRandomText();
                string path = Server.MapPath("~/Image/");
                fupackagephoto.SaveAs(path + filename + ".jpg");

                manager.manager_ob.Image = ("~/Image/" + filename + ".jpg");
                manager.manager_ob.Package_name = txttourname.Text.Trim().ToString();
                manager.manager_ob.Cordinatorid =(int)Session["UserId"];
                manager.manager_ob.Locationid = int.Parse( ddllocation.SelectedItem.Value);
                //manager.activity_ob.Activity_name = ddlactivities.SelectedValue.ToString();
                manager.manager_ob.Basicfare = int.Parse(txtamount.Text.Trim().ToString());

                string result = manager.InsertPackages();
                hdfield.Value = "-1";
                if (result == "Success")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Inserted successfully";
                }
                else if (result == "Already Exist")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Already exist";
                }
                else if (result == "Error")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "failed due to error";

                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "failed due to some technical error";
                }
                PackageBind();
            }
        }
        public void PckageUpdate()
        {
            if (fupackagephoto.HasFile == true)
            {
                string filename = GetRandomText();
                string path = Server.MapPath("~/Image/");
                fupackagephoto.SaveAs(path + filename + ".jpg");

                manager.manager_ob.Image = ("~/Image/" + filename + ".jpg");
                manager.manager_ob.Package_id = int.Parse(hdfield.Value);
                manager.manager_ob.Package_name = txttourname.Text.Trim().ToString();
                manager.manager_ob.Cordinatorid = (int)Session["UserId"];
                manager.manager_ob.Locationid = int.Parse(ddllocation.SelectedItem.Value);
                manager.manager_ob.Basicfare = int.Parse(txtamount.Text.Trim().ToString());
               
                string result = manager.PackageUpdate();
                hdfield.Value = "-1";

                if (result == "Success")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Successfully updated";


                }
                else if (result == "Error")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "failed due to some  error";
                }

                else if (result == "Already exist")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Already Exist";
                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "failed due to some technical error";
                }
            }
            PackageBind();
        }
        public void DeletePackage()
        {
            manager.manager_ob.Package_id = int.Parse(hdfield.Value);
            string result = manager.PackageDelete();
            hdfield.Value = "-1";
            PackageBind();


            if (result == "Success")
            {
                ImageMap1.Visible = false;
                lblmsg.Visible = true;
                lblmsg.Text = "Successfully Deleted";

            }
            else if (result == "Error")
            {
                lblmsg.Visible = true;
                lblmsg.Text = "failed due to some  error";
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "failed due to some technical error";
            }
           
           
        }
        public void view_allLocation()
        {
            ddllocation.DataSource = manager.SelectAllLocation();
            ddllocation.DataTextField = "LOCATION_NAME";
            ddllocation.DataValueField = "LOCATION_ID";
            ddllocation.DataBind();
        }
        protected void btnaddpackage_Click(object sender, EventArgs e)
        {

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (hdfield.Value == "-1")
            {
                InsertPackages();
            }
            else
            {
                PckageUpdate();
            }
        }
        public void SelectById()
        {
            string path = Server.MapPath("~/Image/");
            ImageMap1.Visible = true;
            manager.manager_ob.Package_id = int.Parse(hdfield.Value);
            manager.SelectPackageById();
            txttourname.Text = manager.manager_ob.Package_name;
            txtmanager.Text = manager.manager_ob.Appuser_name.ToString();
            ddllocation.SelectedValue = manager.manager_ob.Location_name.ToString();
            ImageMap1.ImageUrl = manager.manager_ob.Image; 
            txtamount.Text = manager.manager_ob.Basicfare.ToString();
        }
        protected void btnedit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString();
            SelectById();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString();
            DeletePackage();
        }

        protected void btnhotel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            string Location = grdvwrow.Cells[3].Text; 
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString(); 
            Response.Redirect("Hotel.aspx?Location=" + Location + "&Package=" + hdfield.Value);

        }

        protected void btnactivity_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString();
            Response.Redirect("Activities.aspx?Package=" +hdfield.Value );
        }

        protected void btnuser_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("userpm.aspx?");
        }
    }
}