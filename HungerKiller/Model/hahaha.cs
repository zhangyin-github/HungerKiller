using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    /// <summary>
    /// 用来存储在趣味决策页面取出的菜品的名字和图片的名字，单例
    /// </summary>
    class hahaha
    {
        private static hahaha instance;
        private static List<KeyValuePair<string, string>> Dish=null;
        private hahaha()
        {

        }

        public static hahaha getinstance()
        {
            if (instance == null)
            {
                instance = new hahaha();
            }
            return instance;

        }
        public  List<KeyValuePair<string, string>> getDish()
        {
            if (Dish == null)
            {
                Dish = new List<KeyValuePair<string, string>>();
            }
            return Dish;
        }

    }
}
