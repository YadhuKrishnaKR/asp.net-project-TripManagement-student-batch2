using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.PROPERTY
{
    public class registration
    {
		public int APPUSER_ID { get; set; }
		public string  APPUSER_NAME { get; set; }
		public string EMAIL { get; set; }
		public string CONTACT { get; set; }
		public string PASSWORD { get; set; }
		public string STATUS { get; set; }
		public DateTime CREATEDDATE { get; set; }
		public DateTime MODIFIEDDATE { get; set; }
		public string ROLE { get; set; }
	}
}
