using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
