using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    internal class Task
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string referType { get; set; }
        public string referName { get; set; }
        public string priority { get; set; }
        public string note { get; set; }
        public int addedBy { get; set; }
        public Team team { get; set; }
    }
}
