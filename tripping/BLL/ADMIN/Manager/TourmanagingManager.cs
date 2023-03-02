using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ADMIN.tourmanagerproperty;
using DAL;

namespace BLL.ADMIN.Manager
{
    public class TourmanagingManager
    {
        private DBhelper dbh_ob = new DBhelper();
        public Tourmanagerpro manager_ob = new Tourmanagerpro();
        private SortedList sort = new SortedList();
        //public Appuserpro appuser_ob = new Appuserpro();
        //public HotelPro hotel_ob = new HotelPro();
        public Locationpro location_ob = new Locationpro();
        public Activitypro activity_ob = new Activitypro();

        public string InsertPackages()
        {
            sort.Clear();
            sort.Add("cordinator", manager_ob.Cordinatorid);
            sort.Add("location", manager_ob.Locationid);
            sort.Add("image", manager_ob.Image);
            sort.Add("basicfare", manager_ob.Basicfare);
            sort.Add("package_name", manager_ob.Package_name);
            return dbh_ob.executeprocedure(sort, "InsertManager");
        }
        public string PackageUpdate()
        {
            sort.Clear();
            sort.Add("package_id", manager_ob.Package_id);
            sort.Add("cordinator", manager_ob.Cordinatorid);
            sort.Add("location", manager_ob.Locationid);
            sort.Add("image", manager_ob.Image);
            sort.Add("basicfare", manager_ob.Basicfare);
            sort.Add("package_name", manager_ob.Package_name);
            return dbh_ob.executeprocedure(sort, "Sp_UpdateManager");
        }
        public string PackageDelete()
        {
            sort.Clear();
            sort.Add("package_id", manager_ob.Package_id);
            return dbh_ob.executeprocedure(sort, "Sp_DeleteManager");
        }
        public void SelectPackageById()
        {
            sort.Clear();
            sort.Add("package_id", manager_ob.Package_id);
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable(sort,"Sp_SelectPackageById");
            if (dt.Rows.Count > 0)
            {
                manager_ob.Package_name = dt.Rows[0].ItemArray[1].ToString();
                manager_ob.Appuser_name = dt.Rows[0].ItemArray[2].ToString();
                manager_ob.Location_name = dt.Rows[0].ItemArray[3].ToString();
                manager_ob.Image = dt.Rows[0].ItemArray[4].ToString();
                manager_ob.Basicfare = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            }
        }

        public List<Tourmanagerpro> SelectAllDetails()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable("Sp_SelectAllDetails");
            List<Tourmanagerpro> list = new List<Tourmanagerpro>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Tourmanagerpro
                {
                    Package_id = Convert.ToInt32(dr["PACKAGE_Id"]),
                    Package_name = dr["PACKAGE_NAME"].ToString(),
                    Appuser_name = dr["APPUSER_NAME"].ToString(),
                    Location_name = dr["LOCATION_NAME"].ToString(),
                    Image = dr["IMAGE"].ToString(),
                    //Activity_name = dr["ACTIVITY_NAME"].ToString(),
                    Basicfare = int.Parse(dr["BASICFARE"].ToString())
                });
            }
            return list;
        }

        public List<Activitypro> SelectAllActivity()
        {
            DataTable dt = new DataTable();
            dt = dbh_ob.getdatatable("Sp_LocationDropdownList");
            List<Activitypro> list = new List<Activitypro>();
            list.Add(new Activitypro
            {
                Activity_name = "--select--",
                Activity_id = -1
            });
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Activitypro
                {
                    Activity_name = dr["ACTIVITY_NAME"].ToString(),
                    Activity_id = Convert.ToInt32(dr["ACTIVITY_ID"])
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
                Location_name = "select location",
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
