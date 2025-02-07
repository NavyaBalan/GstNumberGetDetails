using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GstNumberGetDetails.Model
{
    public class ApiResponse
    {
        public Customers data { get; set; }
    }

    public class Customers
    {
        public string Legal_Name { get; set; }
        public string State_Jurisdiction { get; set; }
        public string Centre_Jurisdiction { get; set; }
        public string GstIN { get; set; }
        public string Trade_Name { get; set; }
    }
}
