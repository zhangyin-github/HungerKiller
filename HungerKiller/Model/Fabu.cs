using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    public class Fabu
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Date { get; set; }

    }
    public class FabuManager
    {
        public static List<Fabu> GetFabus()
        {
            var fabus = new List<Fabu>();

            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });
            fabus.Add(new Fabu { Title = "麻辣香锅", Publisher = "张三", Date = "2017/7/7" });

            return fabus;
        }
    }
}
