using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    /// <summary>
    /// 用来定义菜品的详细信息（趣味决策界面用）
    /// </summary>
    class trunresult
    {
        public string dishnamee { get; set;}
        public string dishscoree { get; set; }
        public string dishclasss { get; set; }
        public string dishfloors { get; set; }
        public string dishpositions { get; set;}
        public string dishmount { get; set;}
        public trunresult(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            dishnamee = v1;
            dishscoree = v2;
            dishclasss = v3;
            dishfloors = v4;
            dishpositions = v5;
            dishmount = v6;
        }
    }
}
