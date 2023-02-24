using BLL.ADMIN.Manager;
using BLL.ADMIN.tourmanagerproperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping.PackageManagers
{
    public partial class Activities : System.Web.UI.Page
    {
        ActivityManager activity = new ActivityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ActivityBind();
                txtpackageid.Text = Request.QueryString["Package"];
            }
        }
        public void ActivityBind()
        {
            GridView1.DataSource = activity.SelectAllActivity();
            GridView1.DataBind();
        }
        public void InsertActivity()
        {
            activity.activity_ob.Activity_name = txtactivityname.Text.Trim().ToString();
            activity.activity_ob.Amount = txtamount.Text.Trim().ToString();
            activity.activity_ob.PackageId = int.Parse(txtpackageid.Text.Trim().ToString());

            string result = activity.InsertActivity();
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
            ActivityBind();
            txtactivityname.Text = "";
            txtamount.Text = "";
        }
        public void UpdateActivity()
        {
            activity.activity_ob.Activity_id = int.Parse(hdfield.Value);
            activity.activity_ob.Activity_name = txtactivityname.Text.Trim().ToString();
            activity.activity_ob.Amount = txtamount.Text.Trim().ToString();
            activity.activity_ob.PackageId = int.Parse(txtpackageid.Text.Trim());

            string result = activity.UpdateActivity();
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
            ActivityBind();
            txtactivityname.Text = "";
            txtamount.Text = "";
            hdfield.Value= "-1";
        }
        public void DeleteActivity()
        {
            activity.activity_ob.Activity_id = int.Parse(hdfield.Value);
            string result = activity.DeleteActivity();
            hdfield.Value = "-1";

            if (result == "Success")
            {
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
            ActivityBind();
        }
        public void SelectById()
        {
            activity.activity_ob.Activity_id = int.Parse(hdfield.Value);
            activity.SelectAllById();
            txtactivityname.Text = activity.activity_ob.Activity_name;
            txtamount.Text = activity.activity_ob.Amount;
            txtpackageid.Text = activity.activity_ob.PackageId.ToString();
        }
        protected void btnedit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvrow.RowIndex].Value.ToString();
            SelectById();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvrow.RowIndex].Value.ToString();
            DeleteActivity();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if(hdfield.Value == "-1")
            {
                InsertActivity();
            }
            else
            {
                UpdateActivity();
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("TourPackagesManage.aspx?");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Find the input control for the PACKAGEID field
                TextBox txtPackageID = e.Row.FindControl("PACKAGEID") as TextBox;

                if (txtPackageID != null)
                {
                    // Set the "readonly" attribute of the input control
                    txtPackageID.Attributes.Add("readonly", "readonly");
                }
            }
        }
    }
}