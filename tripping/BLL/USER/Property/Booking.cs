using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.USER.Property
{
   public class Booking
    {
        public int BOOKING_ID
        {
            get;
            set;
        }
        public int USER_ID
        {
            get;
            set;
        }
        public int PACKAGEID
        {
            get;
            set;
        }
        public int HOTELID
        {
            get;
            set;
        }
        public int TOTAL_AMOUNT
        {
            get;
            set;
        }

        public string STATUS
        {
            get;
            set;
        }
    }
}
