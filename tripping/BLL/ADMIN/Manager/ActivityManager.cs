using BLL.ADMIN.tourmanagerproperty;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN.Manager
{
    public class ActivityManager
    {
        private DBhelper dbh_ob = new DBhelper();
        public Tourmanagerpro manager_ob = new Tourmanagerpro();
        private SortedList sort = new SortedList();
        //public Appuserpro appuser_ob = new Appuserpro();
        public HotelPro hotel_ob = new HotelPro();
        public Locationpro location_ob = new Locationpro();
        public Activitypro activity_ob = new Activitypro();
        
        public string InsertActivity()
        {
            sort.Clear();
            sort.Add("activity_name", activity_ob.Activity_name);
            sort.Add("amount", activity_ob.Amount);
            sort.Add("packageid", activity_ob.PackageId);
            return dbh_ob.executeprocedure(sort, "Sp_InsertActivity");
        }
        public string UpdateActivity()
        {
            sort.Clear();
            sort.Add("activity_id", activity_ob.Activity_id);
            sort.Add("activity_name", activity_ob.Activity_name);
            sort.Add("amount", activity_ob.Amount);
            sort.Add("packageid", activity_ob.PackageId);
            return dbh_ob.executeprocedure(sort, "Sp_UpdateActivity");
        }
        public string DeleteActivity()
        {
            sort.Clear();
            sort.Add("activity_id", activity_ob.Activity_id);
            return dbh_ob.executeprocedure(sort, "Sp_DeleteActivity");
        }
        public void SelectAllById()
        {
            sort.Clear();
            sort.Add("activity_id", activity_ob.Activity_id);
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable(sort,"Sp_SelectAllById");
            if(dt.Rows.Count > 0)
            {
                activity_ob.Activity_name = dt.Rows[0].ItemArray[1].ToString();
                activity_ob.Amount= int.Parse(dt.Rows[0].ItemArray[2].ToString());
                activity_ob.PackageId =int.Parse(dt.Rows[0].ItemArray[3].ToString());
            }
        }
        public List<Activitypro> SelectAllActivity()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable("Sp_SelectAllActivity");
            List<Activitypro> list = new List<Activitypro>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new Activitypro
                {
                    Activity_id = Convert.ToInt32(dr["ACTIVITY_ID"]),
                    Activity_name = dr["ACTIVITY_NAME"].ToString(),
                    Amount = int.Parse(dr["AMOUNT"].ToString()),
                    Package_name = dr["PACKAGE_NAME"].ToString()
                }) ;
            }
            return list;
        }
    }
}
