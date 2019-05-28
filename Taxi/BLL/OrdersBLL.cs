using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BLL
{
    class OrdersBLL
    {
        public string user_contact { get; set; }
        public string user_name { get; set; }
        public string user_lastname { get; set; }
        public string taxi_contact { get; set; }
        public string taxi_name { get; set; }
        public string taxi_number { get; set; }
        public string _class{ get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string distance { get; set; }
        public string cost { get; set; }
    }
}
