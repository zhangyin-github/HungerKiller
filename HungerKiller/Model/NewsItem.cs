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
    }
    public class NewsManager
    {

        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> getNewsItems()
        {

            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "主页", Headline = ".....", Subhead = ".....", Dateline = ".....", Image = "Assets/1.jpg" });
            items.Add(new NewsItem() { Id = 2, Category = "主页", Headline = ".....", Subhead = ".....", Dateline = ".....", Image = "Assets/2.jpg" });
            items.Add(new NewsItem() { Id = 3, Category = "主页", Headline = ".....", Subhead = ".....", Dateline = ".....", Image = "Assets/3.jpg" });
            items.Add(new NewsItem() { Id = 4, Category = "主页", Headline = ".....", Subhead = ".....", Dateline = ".....", Image = "Assets/4.jpg" });
            return items;
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

         }

     }*/


    public class RegexUtilities
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
