using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class informationforcomment
    {
        private static informationforcomment instance;
        private static List<commentinformation> comments = null;   //用户名,日期,时间,内容,菜品名;
        private informationforcomment()
        {

        }
        public static informationforcomment getinstance()
        {
            if (instance == null)
            {
                instance = new informationforcomment();
            }
            return instance;

        }
        public List<commentinformation> getcomments()
        {
            if (comments == null)
            {
                comments = new List<commentinformation>();
            }
            return comments;
        }
    }
}
