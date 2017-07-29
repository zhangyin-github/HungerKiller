using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    /// <summary>
    /// 登录与服务器的交互
    /// </summary>
    class Signinn
    {
        /// <summary>
        /// 收集用户名和密码，然后将其发送到服务端，并返回相应的值
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<int> siginin(string username, string password)
        {
            try
            {
                var url = "http://localhost:8080/HungerKillerBacked/Login.jsp";
                List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("username", username));
                data.Add(new KeyValuePair<string, string>("passwor", password));
                Windows.Web.Http.HttpClient hc = new Windows.Web.Http.HttpClient();
                var content = new HttpFormUrlEncodedContent(data);
                var response = await hc.PostAsync(new Uri(url), content);
                var resdata = await response.Content.ReadAsStringAsync();
                if (resdata[0] == '4')
                    return 4;
                else if (resdata[0] == '3')
                    return 3;
                else if (resdata[0] == '2')
                    return 2;
                else if (resdata[0] == '1')
                    return 1;
                else
                    return -1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
