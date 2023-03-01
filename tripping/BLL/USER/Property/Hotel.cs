using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.USER.Property
{
  public  class Hotel
    {
        public int HOTEL_ID
        {
            get;set;
        }
        public string HOTEL_NAME
        {
            get;
            set;
        }
        public string DESCRIPTION
        {
            get;
            set;
        }

        public int LOCATION
        {
            get;set;
        }
        public int PACKAGE
        {
            get;
            set;
        }
        public string STATUS
        {
            get;
            set;
        }
        public string HOTEL_IMAGE
        {
            get;
            set;
        }
        public int PRICE
        {
            get;
            set;
        }
    }
}
