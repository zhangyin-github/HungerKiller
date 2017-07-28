using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    class Signinn
    {
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
                    return await Task.FromResult(4);
                else if (resdata[0] == '3')
                    return await Task.FromResult(3);
                else if (resdata[0] == '2')
                    return await Task.FromResult(2);
                else if (resdata[0] == '1')
                    return await Task.FromResult(1);
                else 
                    return await Task.FromResult(0);
            }
            catch
            {
                return await Task.FromResult(0);
            }
        }
    }
}
