using BLL.PROPERTY;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN
{
    public class signupmanager
    {
        private DBhelper Db_Obj = new DBhelper();
        public signpro sig_Obj = new signpro();
        private SortedList S1 = new SortedList();



        //public string Rolling()
        //{
        //    S1.Clear();
        //    S1.Add("name", sig_Obj.name);
        //    S1.Add("Email", sig_Obj.Email);
        //    S1.Add("contactno", sig_Obj.contactno);
        //    S1.Add("password", sig_Obj.Password);
        //    S1.Add("role", sig_Obj.role);

        //    return Db_Obj.executeprocedure(S1, "rollingselect");
        //}
        public string signupinsert()
        {
            S1.Clear();
            S1.Add("name", sig_Obj.name);
            S1.Add("Email", sig_Obj.Email);
            S1.Add("contact", sig_Obj.contactno);
            S1.Add("password", sig_Obj.Password);
            S1.Add("role", sig_Obj.role);

            return Db_Obj.executeprocedure(S1, "signupinsert");
        }
    }
}