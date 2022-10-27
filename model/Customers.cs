using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    internal class Customers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public string mobile { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zip { get; set; }

        public string country { get; set; }

        public string addedBy { get; set; }

        public string addedDate { get; set; }
        public byte[] photo { get; set; }
        public string website { get; set; }
        public int promoted { get; set; }
        public bool Active { get; set; }
        public Team Team { get; set; }
        public Events Events { get; set; }
        public List<Leads> Leads{ get; set; }
    }
}
