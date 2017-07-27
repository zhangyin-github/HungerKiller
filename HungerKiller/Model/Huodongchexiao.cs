using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
   public  class Huodongchexiao
    {
        public string Theme { get; set; }
        public string EventSponsor { get; set; }
        public string ReleaseTime { get; set; }
    }
    public class HuodongchexiaoManager
    {
        public static List<Huodongchexiao> RevokeActivity()
        {
            var revoking = new List<Huodongchexiao>();

            revoking.Add(new Huodongchexiao { Theme = "校园十佳歌手大赛", EventSponsor = "东北大学学生会", ReleaseTime = "2017.7.1" });
            revoking.Add(new Huodongchexiao { Theme = "“百团”大战", EventSponsor = "东北大学学生社团联合会", ReleaseTime = "2017.3.5" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            revoking.Add(new Huodongchexiao { Theme = "校园国标舞大赛", EventSponsor = "东北大学舞蹈协会", ReleaseTime = "2017.4.2" });
            return revoking;
        }
    }
}
