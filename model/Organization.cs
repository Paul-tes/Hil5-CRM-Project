using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil5_CRM_Project.model
{
    public class Organization
    {
        public int id { get; set; }
        public byte[] logo { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string addres { get; set; }
    }
}
