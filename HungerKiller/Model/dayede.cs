using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{/// <summary>
///一个单例，用来存储一个hehehhe格式的链表 
/// </summary>
    class dayede
    {
        private static dayede instance;
        private static List<hehehhe> Dishs = null;   //id,菜系,菜量,楼层,原料,菜名,图片的url,具体位置,评分,口味；
        private dayede()
        {

        }

        public static dayede getinstance()
        {
            if (instance == null)
            {
                instance = new dayede();
            }
            return instance;

        }
        public List<hehehhe> getDishs()
        {
            if (Dishs == null)
            {
                Dishs = new List<hehehhe>();
            }
            return Dishs;
        }
    }
}


