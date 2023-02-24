using BLL.ADMIN.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tripping.PackageManagers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HotelManager hotel = new HotelManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Session["UserId"] = 1;
                HotelBind();
                view_allLocation();
                txtpackage.Text = Request.QueryString["Package"];
                ddllocationhotel.SelectedValue = Request.QueryString["LOcation"];
            }
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
            if (fuhotelimage.HasFile == true)
            {
                string filename = GetRandomText();
                string path = Server.MapPath("~/Image/");
                fuhotelimage.SaveAs(path + filename + ".jpg");

                hotel.hotel_ob.Hotel_image = ("~/Image/" + filename + ".jpg");
                hotel.hotel_ob.Hotel_name = txthotelname.Text.Trim().ToString();
                hotel.hotel_ob.Description = txtdiscription.Text.Trim().ToString();
                hotel.hotel_ob.Location = int.Parse(ddllocationhotel.SelectedItem.Value);
                hotel.hotel_ob.Package = int.Parse(txtpackage.Text.Trim().ToString());
                hotel.hotel_ob.Prize = txthotelprice.Text.Trim().ToString();

                string result = hotel.InsertHotel();
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
                HotelBind();
                txthotelname.Text = "";
                txtdiscription.Text = "";
                txthotelprice.Text = "";
            }
        }

        public void HotelUpdate()
        {
            if (fuhotelimage.HasFile == true)
            {
                string filename = GetRandomText();
                string path = Server.MapPath("~/Image/");
                fuhotelimage.SaveAs(path + filename + ".jpg");
                hotel.hotel_ob.Hotel_id = int.Parse(hdfield.Value);
                hotel.hotel_ob.Hotel_image = ("~/Image/" + filename + ".jpg");
                hotel.hotel_ob.Hotel_name = txthotelname.Text.Trim().ToString();
                hotel.hotel_ob.Description = txtdiscription.Text.Trim().ToString();
                hotel.hotel_ob.Location = int.Parse(ddllocationhotel.SelectedItem.Value);
                hotel.hotel_ob.Package = int.Parse(txtpackage.Text.Trim().ToString());
                hotel.hotel_ob.Prize = txthotelprice.Text.Trim().ToString();

                string result = hotel.HotelUpdate();
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
                HotelBind();
                txthotelname.Text = "";
                txtdiscription.Text = "";
                txthotelprice.Text = "";
                hdfield.Value = "-1";
            }
        }
        public void view_allLocation()
        {
            ddllocationhotel.DataSource = hotel.SelectAllLocation();
            ddllocationhotel.DataTextField = "LOCATION_NAME";
            ddllocationhotel.DataValueField = "LOCATION_ID";
            ddllocationhotel.DataBind();
        }
        public void HotelBind()
        {
            GridView1.DataSource = hotel.SelectAllDetails();
            GridView1.DataBind();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if(hdfield.Value == "-1")
            {
                InsertPackages();
            }
            else
            {
                HotelUpdate();
            }
        }
        public void DeleteHotel()
        {
            hotel.hotel_ob.Hotel_id = int.Parse(hdfield.Value);
            string result = hotel.HotelDelete();
            hdfield.Value = "-1";
            HotelBind();


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
        public void SelectById()
        {
            string path = Server.MapPath("~/Image/");
            ImageMap1.Visible = true;
            hotel.hotel_ob.Hotel_id = int.Parse(hdfield.Value);
            hotel.SelectHotelById();
            txthotelname.Text = hotel.hotel_ob.Hotel_name;
            txtdiscription.Text = hotel.hotel_ob.Description.ToString();
            ddllocationhotel.SelectedValue = hotel.hotel_ob.Location.ToString();
            txtpackage.Text = hotel.hotel_ob.Package.ToString();
            ImageMap1.ImageUrl = hotel.hotel_ob.Hotel_image;
            txthotelprice.Text = hotel.hotel_ob.Prize;
        }
        protected void btnedithotel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString();
            SelectById();
        }

        protected void btndeletehotel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow grdvwrow = btn.NamingContainer as GridViewRow;
            hdfield.Value = GridView1.DataKeys[grdvwrow.RowIndex].Value.ToString();
            DeleteHotel();
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("TourPackagesManage.aspx?");
        }
    }
}