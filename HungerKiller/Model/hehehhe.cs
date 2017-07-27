using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class hehehhe
    {
        public int dishID { get; set; }
        public string dishname { get; set; }
        public string dishpicture { get; set; }
        public string dishscore { get; set; }
        public string dishingerdients { get; set; }
        public string dishcurrent { get; set; }
        public string dishfloor { get; set; }
        public string dishposition { get; set; }
        public string dishclass { get; set; }
        public string dishtatse { get; set; }
        public hehehhe(int se, string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9)
        {
            dishID = se;
            dishname = v1;
            dishpicture = v2;
            dishscore = v3;
            dishingerdients = v4;
            dishcurrent = v5;
            dishfloor = v6;
            dishposition = v7;
            dishclass = v8;
            dishtatse = v9;

        }
    }
}
