using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace HungerKiller.Model
{
    class AllDish
    {
        public async Task<bool> getalldish()
        {
            try
            {
                var url = "http://172.17.23.68:8080/HungerKillerBacked/GetAll.jsp";
                List<KeyValuePair<string, string>> counttss = new List<KeyValuePair<string, string>>();
                counttss.Add(new KeyValuePair<string, string>("DishOne", "1"));
                Windows.Web.Http.HttpClient hc = new Windows.Web.Http.HttpClient();
                var content = new Windows.Web.Http.HttpFormUrlEncodedContent(counttss);
                var response = await hc.PostAsync(new Uri(url), content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] DishAllInformation = resdata.Split('"');
                List<hehehhe> Dishsdsd = new List<hehehhe>();
                int c = DishAllInformation.Count();
                int d = 3;
                dayede.getinstance().getDishs().Clear();
                while (d < c)
                {
                    int z = d + 4;
                    int x = z + 4;
                    int s = x + 4;
                    int v = s + 4;
                    int b = v + 4;
                    int n = b + 4;
                    int m = n + 4;
                    int l = m + 4;
                    int k = l + 4;
                    int id = Convert.ToInt32(DishAllInformation[d]);
                    dayede.getinstance().getDishs().Add(new hehehhe(id, DishAllInformation[z], "http://localhost:8080/HungerKillerBacked/HungerKiller/"+DishAllInformation[x], DishAllInformation[s], DishAllInformation[v], DishAllInformation[b], DishAllInformation[n], DishAllInformation[m], DishAllInformation[l], DishAllInformation[k]));
                    d = k + 4;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
