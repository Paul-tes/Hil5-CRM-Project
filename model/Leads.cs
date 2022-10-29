using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    internal class Leads
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string source { get; set; }
        public string status { get; set; }
        public int addedBy { get; set; }
        public string note { get; set; }
        public DateTime createDate { get; set; }
        public Team team { get; set; }
        public Customers Customers { get; set; }

    }
}
