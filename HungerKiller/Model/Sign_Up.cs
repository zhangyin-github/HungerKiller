using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    public class Sign_Up
    {
        public async void PostUser(string username, string password, string email, bool acid, bool sweet, bool hot, bool salty, bool meet, bool light, bool send)
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
                var url = "http://localhost:8080/HungerKillerBacked/insertUsernameAndPassword.jsp";
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

            }
            catch
            {

            }
        }

    }
    }
