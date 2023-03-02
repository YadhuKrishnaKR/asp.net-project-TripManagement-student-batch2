using BLL.ADMIN.tourmanagerproperty;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN.Manager
{
    public class HotelManager
    {
        private DBhelper dbh_ob = new DBhelper();
        //public Tourmanagerpro manager_ob = new Tourmanagerpro();
        private SortedList sort = new SortedList();
        //public Appuserpro appuser_ob = new Appuserpro();
        public HotelPro hotel_ob = new HotelPro();
        public Locationpro location_ob = new Locationpro();
        //public Activitypro activity_ob = new Activitypro();

        public string InsertHotel()
        {
            sort.Clear();
            sort.Add("hotel_name", hotel_ob.Hotel_name);
            sort.Add("description", hotel_ob.Description);
            sort.Add("location", hotel_ob.Location);
            sort.Add("package", hotel_ob.Package);
            sort.Add("hotel_image", hotel_ob.Hotel_image);
            sort.Add("prize", hotel_ob.Prize);
            return dbh_ob.executeprocedure(sort, "Sp_InsertHotel");
        }
        public string HotelUpdate()
        {
            sort.Clear();
            sort.Add("hotel_id", hotel_ob.Hotel_id);
            sort.Add("hotel_name", hotel_ob.Hotel_name);
            sort.Add("description", hotel_ob.Description);
            sort.Add("location", hotel_ob.Location);
            sort.Add("package", hotel_ob.Package);
            sort.Add("hotel_image", hotel_ob.Hotel_image);
            sort.Add("prize", hotel_ob.Prize);
            return dbh_ob.executeprocedure(sort, "Sp_UpdateHotel");
        }
        public string HotelDelete()
        {
            sort.Clear();
            sort.Add("hotel_id", hotel_ob.Hotel_id);
            return dbh_ob.executeprocedure(sort, "Sp_DeleteHotel");
        }
        public void SelectHotelById()
        {
            sort.Clear();
            sort.Add("hotel_id", hotel_ob.Hotel_id);
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable(sort, "Sp_SelectHotelById");
            if (dt.Rows.Count > 0)
            {
                hotel_ob.Hotel_name = dt.Rows[0].ItemArray[1].ToString();
                hotel_ob.Description = dt.Rows[0].ItemArray[2].ToString();
                hotel_ob.Location_name = dt.Rows[0].ItemArray[3].ToString();
                hotel_ob.Package_name = dt.Rows[0].ItemArray[4].ToString();
                hotel_ob.Hotel_image = dt.Rows[0].ItemArray[5].ToString();
                hotel_ob.Prize = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            }
        }
        public List<HotelPro> SelectAllDetails()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable("Sp_SelectAllHotels");
            List<HotelPro> list = new List<HotelPro>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new HotelPro
                {
                    Hotel_id = Convert.ToInt32(dr["HOTEL_ID"]),
                    Hotel_name = dr["HOTEL_NAME"].ToString(),
                    Description = dr["DESCRIPTION"].ToString(),
                    Location_name = dr["LOCATION_NAME"].ToString(),
                    Package_name = dr["PACKAGE_NAME"].ToString(),
                    Hotel_image = dr["HOTEL_IMAGE"].ToString(),
                    Prize = int.Parse( dr["PRIZE"].ToString())
                });
            }
            return list;
        }

        public List<Locationpro> SelectAllLocation()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable("Sp_LocationDropdownList");
            List<Locationpro> list = new List<Locationpro>();
            list.Add(new Locationpro
            {
                Location_name = "--select--",
                Location_id = -1
            });
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Locationpro
                {
                    Location_name = dr["LOCATION_NAME"].ToString(),
                    Location_id = Convert.ToInt32(dr["LOCATION_ID"])
                });
            }
            return list;
        }
    }
}
