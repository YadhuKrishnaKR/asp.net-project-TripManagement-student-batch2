using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ADMIN.tourmanagerproperty
{
    public class HotelPro
    {
        //hotel side
        public int Hotel_id { get; set; }
        public string Hotel_name { get; set; }
        public string Description { get; set; }
        public int Location { get; set; }
        public int Package { get; set; }
        public string Hotel_image { get; set; }
        public string Prize { get; set; }
    }
}
