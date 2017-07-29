using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    /// <summary>
    /// 一个单例，用来保存从数据库中取出的菜品的详细信息（趣味决策用）
    /// </summary>
    class dealturninformation
    {
        private static dealturninformation  dealff;
        private static List<trunresult> Dishinformations = null;
        private dealturninformation()
        {

        }
        public static dealturninformation getdealff()
        {
            if (dealff == null)
            {
                dealff = new dealturninformation();
            }
            return dealff;
        }
        public List<trunresult> getDishinformation()
        {
            if (Dishinformations == null)
            {
                Dishinformations = new List<Model.trunresult>();
            }
            return Dishinformations;
        }
    }
}
