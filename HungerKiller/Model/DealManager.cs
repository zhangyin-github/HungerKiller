using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HungerKiller.Model
{
    class turn
    {
        public string turnurl { get; set; }
        public string turnname { get; set; }

    }
    class DealManager
    {

        public async void DealCountAndCountt(int count, int countt)
        {
            List<int> counts = new List<int>();
            int i, s, j = 1;
            for (i = 1; i <= 10; s++)
            {
                s = count & j;
                if (s == j)
                    counts.Add(i);
                else
                    counts.Add(0);
                i++;
                j = 2 * j;
            }
            s = 0; j = 1;
            for (i = 1; i <= 10; s++)
            {
                s = countt & j;
                if (s == j)
                    counts.Add(i);
                else
                    counts.Add(0);
                i++;
                j = 2 * j;
            }
            int f = 0;
            List<string> countts = new List<string>();
            while (f < 10)
            {
                if (counts[f] > counts[f + 10])
                {
                    countts.Add("a");
                }
                else if (counts[f] < counts[f + 10])
                {
                    countts.Add("c");
                }
                else countts.Add("b");
                f++;
            }
            try
            {
                var url = "http://localhost:8080/HungerKillerBacked/DealCountts.jsp";
                List<KeyValuePair<string, string>> counttss = new List<KeyValuePair<string, string>>();
                counttss.Add(new KeyValuePair<string, string>("DishOne", countts[0]));
                counttss.Add(new KeyValuePair<string, string>("DishTwo", countts[1]));
                counttss.Add(new KeyValuePair<string, string>("DishThree", countts[2]));
                counttss.Add(new KeyValuePair<string, string>("DishFour", countts[3]));
                counttss.Add(new KeyValuePair<string, string>("DishFive", countts[4]));
                counttss.Add(new KeyValuePair<string, string>("DishSix", countts[5]));
                counttss.Add(new KeyValuePair<string, string>("DishSeven", countts[6]));
                counttss.Add(new KeyValuePair<string, string>("DishEight", countts[7]));
                counttss.Add(new KeyValuePair<string, string>("DishNine", countts[8]));
                counttss.Add(new KeyValuePair<string, string>("DishTen", countts[9]));
                Windows.Web.Http.HttpClient hc = new Windows.Web.Http.HttpClient();
                var content = new Windows.Web.Http.HttpFormUrlEncodedContent(counttss);
                var response = await hc.PostAsync(new Uri(url), content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArray = resdata.Split('"');
                List<KeyValuePair<string, string>> DishImageAndName = new List<KeyValuePair<string, string>>();
                int c = SArray.Count();
                int d = 3;
                while (d < c)
                {
                    int z = d + 4;
                    hahaha.getinstance().getDish().Add(new KeyValuePair<string, string>(SArray[d], SArray[z]));
                    d = d + 8;
                }
            }
            catch
            {

            }
        }





    }
}
