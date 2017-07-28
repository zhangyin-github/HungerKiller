using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Recommend : Page
    {
        public ObservableCollection<NewsItem> NewsItems;
        public NewsItem NewsItem { get { return this.DataContext as NewsItem; } }
        public Recommend()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItem>();
            NewsManager.GetAllItems(NewsItems);
            this.DataContextChanged += (s, e) => Bindings.Update();
        }

        private void Mylistview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(comment), ((NewsItem)e.ClickedItem).Id);
        }
    }
}
