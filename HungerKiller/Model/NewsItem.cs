using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Sockets;
using System.Globalization;
using System.Text.RegularExpressions;
using Windows.UI.Xaml.Controls;

namespace HungerKiller.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
    public class NewsManager
    {
        public static void GetAllItems(ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            newsItems.Clear();
            allItems.ForEach(p => newsItems.Add(p));
        }
        public static void GetAllItemsByCategory(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        public static void GetNewsItemsByHeadline(ObservableCollection<NewsItem> newsItems, string Headline)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Headline == Headline).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            for (int i=0; i<dayede.getinstance().getDishs().Count; i++)
            { 
            items.Add(new NewsItem() { Id = dayede.getinstance().getDishs()[i].dishID, Category = "主页", Headline = dayede.getinstance().getDishs()[i].dishname, Subhead = dayede.getinstance().getDishs()[i].dishingerdients, Dateline =dayede.getinstance().getDishs()[i].dishtatse, Image = dayede.getinstance().getDishs()[i].dishpicture, Text = dayede.getinstance().getDishs()[i].dishscore });
            }
            return items;
        }
        public static NewsItem GetNews(int id)
        {
            var items = getNewsItems();
            for (int i = 0; i < items.Capacity; i++)
            {
             if (items[i].Id == id)
             return items[i];
            }
            return null;
        }
    }
    /* public class User
     {
         private static User u;
         public static bool authentication(a,b)
         {
             User u = new User();
             u = null;
         }
         public static User get(name,pass)
         {
         
         }
         public static bool islogin()
         {
         if
         }

     }*/

    public static class OneUser     //存用户名密码静态类
    {
        public static string name { get; set; }
        public static string password { get; set; }
    }


    public class User           //用户服务
    {
        static User u = new User();
        public static bool sign_or_not = false;
        public static int category=0;
    }
    public class tiao       //登录界面跳转到主页的flag
    {
        static tiao jmp = new tiao();
        public static bool jm = false;
    }
    public class tiao1        //注销成功
    {
        static tiao1 jmp1 = new tiao1();
        public static bool jm1 = false;
    }

    public class zidongzhuxiao
    {
        public static string zhuxiaoming;
    }

    public class guanliyuan        //注销成功
    {
        public static bool son = false;
    }

    public class RegexUtilities             //正则表达式邮箱验证
    {
        bool invalid = false;

        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
