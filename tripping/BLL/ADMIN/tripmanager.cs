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
    public class tripmanager
    {
        private DBhelper Db_obj = new DBhelper();
        public registration reg = new registration();
        public SortedList S1 = new SortedList();
        public string pmDelete()
        {
            S1.Clear();
            S1.Add("APPUSER_ID", reg.APPUSER_ID);
            return Db_obj.executeprocedure(S1, "sp_delete");
        }
        public List<registration> SellectAllpm()
        {
            DataTable dt = new DataTable();
            dt = Db_obj.getdatatable("selectregpm");
            List<registration> _list = new List<registration>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new registration
                {

                    APPUSER_ID =Convert.ToInt32(dr["APPUSER_ID"]),
                    APPUSER_NAME = dr["APPUSER_NAME"].ToString(),
                    EMAIL = dr["EMAIL"].ToString(),
                    CONTACT = dr["CONTACT"].ToString(),
                    PASSWORD = dr["PASSWORD"].ToString(),
                    //CREATEDDATE = dr["CREATEDDATE"].ToString(),
                    //MODIFIEDDATE =dr["MODIFIEDDATE"].ToString(),
                    STATUS = dr["STATUS"].ToString(),
                    ROLE = dr["ROLE"].ToString(),


                });
            }
            return _list;

        }

       
        public void SelectpmById()
        {
            S1.Clear();
            S1.Add("APPUSER_ID", reg.APPUSER_ID);
            DataTable dt = new DataTable();
            dt = Db_obj.getdatatable(S1, "SellectpmById");
            if (dt.Rows.Count > 0)
            {
                reg.APPUSER_NAME = dt.Rows[0].ItemArray[1].ToString();

                reg.CONTACT = dt.Rows[0].ItemArray[3].ToString();

                reg.EMAIL = dt.Rows[0].ItemArray[2].ToString();
                reg.PASSWORD = dt.Rows[0].ItemArray[4].ToString();
                //reg.CREATEDDATE= dt.Rows[0].ItemArray[5].ToString();
                //reg.MODIFIEDDATE= dt.Rows[0].ItemArray[6].ToString();

            }


        }
        public string pmInsert()
        {
            S1.Clear();
            
            S1.Add("APPUSER_NAME", reg.APPUSER_NAME);
            S1.Add("CONTACT", reg.CONTACT);
            S1.Add("EMAIL", reg.EMAIL);
            S1.Add("PASSWORD",reg.PASSWORD);
            S1.Add("STATUS", reg.STATUS);
            //S1.Add("CREATEDDATE", reg.CREATEDDATE);
            //S1.Add("MODIFIEDDATE", reg.MODIFIEDDATE);
            S1.Add("ROLE", reg.ROLE);

            return Db_obj.executeprocedure(S1, "pm_insert");

        }
       

    }



}

    

