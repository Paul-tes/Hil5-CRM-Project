using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    internal class Events
    {
        public int id { get; set; }
        public string topic { get; set; }

        public string type { get; set; }

        public string status { get; set; }

        public string note { get; set; }

        public DateTime startDate { get; set; }
      //  public DateTime startTime { get; set; }
        public DateTime endDate { get; set; }
      //  public DateTime endTime { get; set; }
        public int addedBy { get; set; }

        //public List<Customers> customers { get; set; }
        //public Team team { get; set; }


    }
}
