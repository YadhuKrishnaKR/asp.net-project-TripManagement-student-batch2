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
    public class MybookingManager
    {
        public mybookinpro mybooking = new mybookinpro();
        private DBhelper dbh_ob = new DBhelper();
        private SortedList sort = new SortedList();



        public List<mybookinpro> SelectAllDetails()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable(sort,"Sp_MyBooking");
            List<mybookinpro> list = new List<mybookinpro>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new mybookinpro
                {
                    Booking_id= int.Parse(dr["BOOKING_ID"].ToString()),
                    Image = dr["IMAGE"].ToString(),
                    Package_name = dr["PACKAGE_NAME"].ToString(),
                    Hotel_name = dr["HOTEL_NAME"].ToString(),
                    Activity_name = dr["ACTIVITY_NAME"].ToString(),
                     Appuser_name = dr["APPUSER_NAME"].ToString()

                });
            }
            return list;
        }
    }
}
