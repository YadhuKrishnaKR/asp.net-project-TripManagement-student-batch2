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
 public   class loginmanager
    {
        private DBhelper Db_Obj = new DBhelper();
        public loginpro log_Obj = new loginpro();
        private SortedList S1 = new SortedList();
        
        public userProperty RoleSelect()
        {
            
            S1.Clear();
            S1.Add("UserName", log_Obj.UserName);
            S1.Add("Password", log_Obj.Password);
            DataTable dt = new DataTable();
             
            dt=   Db_Obj.getdatatable(S1,"sp_login");

          
            userProperty loggedUser = new userProperty();

            foreach (DataRow dr in dt.Rows)
            {


                loggedUser.UserId = Convert.ToInt32(dr["APPUSER_ID"]);
                loggedUser.Role = (dr["Role"].ToString());


                
            }
            return loggedUser;

           
        }

    }
}
