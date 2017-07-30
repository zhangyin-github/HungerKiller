using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class GetAllcomment
    {
        public async void getall(string ve)
        {
            try
            {
                string ty="dishname="+"辣炒鸡片";
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                System.Net.Http.StringContent content = new StringContent(ty, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                System.Net.Http.HttpResponseMessage response = await client.PostAsync("http://localhost:8080/HungerKillerBacked/getallcomment.jsp", content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArrayssssss = resdata.Split('"');
                int c = SArrayssssss.Count();
                int d = 3;
                informationforcomment.getinstance().getcomments().Clear();
                while (d < c)
                {
                    int z = d + 4;
                    int x = z + 4;
                    int f = x + 4;
                    int v = f + 4;
                    informationforcomment.getinstance().getcomments().Add(new commentinformation(SArrayssssss[d], SArrayssssss[z], SArrayssssss[x], SArrayssssss[f], SArrayssssss[v]));
                    d = v + 4;
                }
            }
            catch
            {


            }


        }
    }
}
