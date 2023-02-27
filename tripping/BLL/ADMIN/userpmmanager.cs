using BLL.PROPERTY;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN
{
  public   class userpmmanager
   {
        private DBhelper Db_Obj = new DBhelper();
        public userpmpro userpmpro_Obj = new userpmpro();
        private SortedList S1 = new SortedList();

        public List<userpmpro> listofdetails()
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.getdatatable("listofdetails");
            List<userpmpro> list = new List<userpmpro>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new userpmpro
                {
                    Package_id = Convert.ToInt32(dr["PACKAGE_Id"]),
                    Location_name = dr["LOCATION_NAME"].ToString(),
                    Image = dr["IMAGE"].ToString(),
                    Package_name = dr["PACKAGE_NAME"].ToString(),
                    Activity_name = dr["ACTIVITY_NAME"].ToString(),
                    Hotel_name = dr["HOTEL_NAME"].ToString(),
                    Appuser_name = dr["APPUSER_NAME"].ToString(),
                    Contact = dr["CONTACT"].ToString()


                });
            }
            return list;
        }
       
        }
    }



