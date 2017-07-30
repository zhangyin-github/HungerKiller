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
        private static List<hehehhe> Dish = null;   //id,菜名,图片的url,评分，原料，菜量，楼层，具体位置，菜系，口味；
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
        public List<hehehhe> getDish()
        {
            if (Dish == null)
            {
                Dish = new List<hehehhe>();
            }
            return Dish;
        }
    }
}


