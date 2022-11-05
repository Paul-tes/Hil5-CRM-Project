using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    internal class Team
    {
        public int id { get; set; }
        public byte[] picture { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public string departement { get; set; }
        public string role { get; set; }
        public bool status { get; set; }

        public List<Leads> Teams { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Events> Events { get; set; }
        public List<Customers> Customers { get; set; }
    }
}
