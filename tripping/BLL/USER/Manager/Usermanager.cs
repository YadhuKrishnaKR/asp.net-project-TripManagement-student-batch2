using BLL.USER.Property;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.USER.Manager
{
    public class Usermanager
    {
        private DBhelper db_obj = new DBhelper();
        public locationProperty lp_obj = new locationProperty();
        public packagelist pl_obj = new packagelist();
        private SortedList s1 = new SortedList();
        Activitylist al_obj = new Activitylist();
        Booking booking_obj=new Booking();
        Hotel hotel_obj = new Hotel();

        public  string getpackageamount(int akid)
        {
            DataTable dt = new DataTable();
            s1.Clear();
            s1.Add("PACKAGE_ID", akid);
          dt=  db_obj.getdatatable(s1,"SP_getpackagefare");
           if(dt.Rows.Count>0)
            {
                pl_obj.BASICFARE = Convert.ToInt32 (dt.Rows[0].ItemArray[0].ToString());
            }

            return Convert.ToInt32(pl_obj.BASICFARE).ToString();
        }

        public  List<locationProperty> locationdropdownlist()
        {
            DataTable dt = new DataTable();
            dt = db_obj.getdatatable("Locationdropdownlist");
            List<locationProperty> li = new List<locationProperty>();
            foreach(DataRow dr in dt.Rows)
            {
                li.Add(new locationProperty
                {
                    Name = dr["LOCATION_NAME"].ToString(),
                    Id = Convert.ToInt32(dr["LOCATION_ID"])
                });
            }
            return li;
        }

        public string bookinginsert(int Total,int Pid,int Hid,int Uid)
        {
            s1.Clear();
            s1.Add("PACKAGEID", Pid);
            s1.Add("HOTELID", Hid);
            s1.Add("TOTAL_AMOUNT", Total);
            s1.Add("USER_ID", Uid);
            return db_obj.executeprocedure(s1, "SP_bookinginsert");
        }

        public object packagelisting()
        {
            s1.Clear();
            s1.Add("LOCATION_ID", pl_obj.LOCATIONID);
            DataTable dt = new DataTable();
            dt = db_obj.getdatatable(s1, "sp_packagelisting");
            List<packagelist> li = new List<packagelist>();
            foreach (DataRow dr in dt.Rows)
            {
                li.Add(new packagelist
                {
                    Image = dr["IMAGE"].ToString(),
                    PACKAGE_ID = Convert.ToInt32(dr["PACKAGE_ID"]),
                    PACKAGE_NAME = dr["PACKAGE_NAME"].ToString(),
                    LOCATIONID = Convert.ToInt32(dr["LOCATIONID"]),
                    CORDINATORID = Convert.ToInt32(dr["CORDINATORID"]),
                    BASICFARE = Convert.ToInt32(dr["BASICFARE"])


                }) ;
            }
            return li;
           // return db_obj.execreader(s1, "sp_packagelisting");
        }

        public List<Activitylist> activitylisting(int pkid)
        {
            s1.Clear();
            s1.Add("PACKAGEID", pkid);
            DataTable dt = new DataTable();
            dt = db_obj.getdatatable(s1, "SP_ACTIVITYLISTING");
            List<Activitylist> li = new List<Activitylist>();
            foreach(DataRow dr in dt.Rows)
            {
                li.Add(new Activitylist
                {
                    ACTIVITY_NAME = dr["ACTIVITY_NAME"].ToString(),
                    AMOUNT = Convert.ToInt32(dr["AMOUNT"])
                });
            }
            return li;
        }
        public List<Hotel> hotellist(int pkid)
        {
            s1.Clear();
            s1.Add("PACKAGE", pkid);
            DataTable dt = new DataTable();
            dt = db_obj.getdatatable(s1, "SP_Hotellist");
            List<Hotel> li = new List<Hotel>();
            foreach(DataRow dr in dt.Rows)
            {
                li.Add(new Hotel
                {
                    HOTEL_IMAGE=dr["HOTEL_IMAGE"].ToString(),
                    HOTEL_ID = Convert.ToInt32(dr["HOTEL_ID"]),
                    HOTEL_NAME = dr["HOTEL_NAME"].ToString(),
                    DESCRIPTION=dr["DESCRIPTION"].ToString(),
                    PRICE=Convert.ToInt32(dr["PRIZE"])
                });
            }
            return li;






        }
    }




}
