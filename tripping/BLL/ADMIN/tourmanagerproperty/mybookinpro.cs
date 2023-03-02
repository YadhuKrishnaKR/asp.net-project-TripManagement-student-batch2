using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN.tourmanagerproperty
{
    public class mybookinpro
    {
        public int Booking_id { get; set; }
        public string Image { get; set; }
        public string Package_name { get; set; }
        public string Hotel_name { get; set;}
        public string Activity_name { get; set; }
        public string Appuser_name { get; set;}

        public int User_id { get; set; }
        public int Hotel_id { get; set; }
        public int Activity_id { get; set; }
        public int Total_amount { get; set; }
    }
}
