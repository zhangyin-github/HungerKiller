using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    /// <summary>
    /// 注册与服务器的交互
    /// </summary>
    public class Sign_Up
    {
        /// <summary>
        /// 统计各个信息并将其发送到服务器之中然后返回是否成功。
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="acid"></param>
        /// <param name="sweet"></param>
        /// <param name="hot"></param>
        /// <param name="salty"></param>
        /// <param name="meet"></param>
        /// <param name="light"></param>
        /// <param name="send"></param>
        /// <returns></returns>
        public async Task<bool> PostUser(string username, string password, string email, bool acid, bool sweet, bool hot, bool salty, bool meet, bool light, bool send)
        {
            String acidd, sweett, hott, saltyy, meett, lightt, sendd;
            if (acid)
                acidd = "a";
            else acidd = "b";
            if (sweet)
                sweett = "a";
            else sweett = "b";
            if (hot)
                hott = "a";
            else hott = "b";
            if (salty)
                saltyy = "a";
            else saltyy = "b";
            if (meet)
                meett = "a";
            else meett = "b";
            if (light)
                lightt = "a";
            else lightt = "b";
            if (send)
                sendd = "a";
            else sendd = "b";
            try
            {
                var url = "http://172.17.23.68:8080/HungerKillerBacked/insertUsernameAndPassword.jsp";
                List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("username", username));
                data.Add(new KeyValuePair<string, string>("passwor", password));
                data.Add(new KeyValuePair<string, string>("email", email));
                data.Add(new KeyValuePair<string, string>("acid", acidd));
                data.Add(new KeyValuePair<string, string>("sweet", sweett));
                data.Add(new KeyValuePair<string, string>("hot", hott));
                data.Add(new KeyValuePair<string, string>("salty", saltyy));
                data.Add(new KeyValuePair<string, string>("meat", meett));
                data.Add(new KeyValuePair<string, string>("light", lightt));
                data.Add(new KeyValuePair<string, string>("send", sendd));
                Windows.Web.Http.HttpClient hc = new Windows.Web.Http.HttpClient();
                var content = new HttpFormUrlEncodedContent(data);
                var response = await hc.PostAsync(new Uri(url), content);
                var resdata = await response.Content.ReadAsStringAsync();
                if (resdata[0]=='1')
                    return await Task.FromResult(true);
                else
                    return await Task.FromResult(false);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

    }
    }
