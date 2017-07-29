using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    /// <summary>
    /// 用来与服务器进行交互，交互发生的时间为在转盘抉择出某一个菜品之后
    /// </summary>
    class Dealturnresult
    {
        /// <summary>
        /// 根据输入的菜品名在数据库中取出菜品的详细信息，然后将详细信息存在单例之中(Dealinformation)
        /// </summary>
        /// <param name="dishname"></param>
        /// <returns></returns>
        public async Task<bool> dealturnresult(string dishname)
        {
            try
            {
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                var url = "http://localhost:8080/HungerKillerBacked/Dealturn.jsp";
                string st = "dishname=" + dishname;
                System.Net.Http.StringContent content = new StringContent(st, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                System.Net.Http.HttpResponseMessage response = await client.PostAsync(url, content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArrayss = resdata.Split('"');
                if (SArrayss[3] != "error")
                {
                    int counttss = SArrayss.Count();
                    int dlll = 3;
                    dealturninformation.getdealff().getDishinformation().Clear();
                    while (dlll < counttss)
                    {
                        int zx = dlll + 4;
                        int xc = zx + 4;
                        int cv = xc + 4;
                        int vb = cv + 4;
                        int bn = vb + 4;
                        dealturninformation.getdealff().getDishinformation().Add(new trunresult(SArrayss[dlll], SArrayss[zx], SArrayss[xc], SArrayss[cv], SArrayss[vb], SArrayss[bn]));
                        dlll = bn + 4;
                    }
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
