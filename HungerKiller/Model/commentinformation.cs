using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class commentinformation
    {
        public string usersd { get; set;}
        public string datess { get; set;}
        public string timess { get; set;}
        public string concent{ get; set;}
        public string dishhh { get; set;}
        public commentinformation(string v1, string v2, string v3, string v4,string v5)
        {
            usersd = v1;
            datess = v2;
            timess = v3;
            concent= v4;
            dishhh = v5;
        }
    }
}
