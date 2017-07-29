using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class homepage : Page
    {
        public ObservableCollection<NewsItem> NewsItems;
        private List<string> Suggestions;
        private object frame;
        public static bool IsSelected { get; internal set; }
        public NewsItem NewsItem { get { return this.DataContext as NewsItem; } }

        public homepage()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItem>();
            NewsManager.GetAllItems(NewsItems);
            this.DataContextChanged += (s, e) => Bindings.Update();

            //轮播图
            this.LeftFlipView.ItemsSource = this.CenterFlipView.ItemsSource = this.RightFlipView.ItemsSource = new ObservableCollection<BitmapImage>()
            {
                new BitmapImage(new Uri("ms-appx:///Assets/1.jpg",UriKind.RelativeOrAbsolute)),
                new BitmapImage(new Uri("ms-appx:///Assets/2.jpg",UriKind.RelativeOrAbsolute)),
                new BitmapImage(new Uri("ms-appx:///Assets/3.jpg",UriKind.RelativeOrAbsolute))
            };
            this.CenterFlipView.SelectedIndex = 0;
            this.LeftFlipView.SelectedIndex = this.LeftFlipView.Items.Count - 1;
            this.RightFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex + 1;

        }

        /// <summary>
        /// 轮播图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CenterFlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.CenterFlipView.SelectedIndex == 0)
            {
                this.LeftFlipView.SelectedIndex = this.LeftFlipView.Items.Count - 1;
                this.RightFlipView.SelectedIndex = 1;
            }
            else if (this.CenterFlipView.SelectedIndex == 1)
            {
                this.LeftFlipView.SelectedIndex = 0;
                this.RightFlipView.SelectedIndex = this.RightFlipView.Items.Count - 1;
            }
            else if (this.CenterFlipView.SelectedIndex == this.CenterFlipView.Items.Count - 1)
            {
                this.LeftFlipView.SelectedIndex = this.LeftFlipView.Items.Count - 2;
                this.RightFlipView.SelectedIndex = 0;
            }
            else if ((this.CenterFlipView.SelectedIndex < (this.CenterFlipView.Items.Count - 1)) && this.CenterFlipView.SelectedIndex > -1)
            {
                this.LeftFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex - 1;
                this.RightFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex + 1;
            }
            else
            {
                return;
            }
            Debug.Write(this.LeftFlipView.SelectedIndex);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DispatcherTimer timer1 = new DispatcherTimer();
            DispatcherTimer timer2 = new DispatcherTimer();
            DispatcherTimer timer3 = new DispatcherTimer();
            timer1.Interval = timer2.Interval = timer3.Interval = new System.TimeSpan(0, 0, 7);
            timer1.Tick += (sender, args) =>
            {
                this.CenterFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex < this.CenterFlipView.Items.Count - 1 ? ++this.CenterFlipView.SelectedIndex : 0;
            };
            timer2.Tick += (sender, args) =>
            {
                this.LeftFlipView.SelectedIndex = this.LeftFlipView.SelectedIndex < this.LeftFlipView.Items.Count - 1 ? ++this.LeftFlipView.SelectedIndex : 0;
            };
            timer3.Tick += (sender, args) =>
            {
                this.RightFlipView.SelectedIndex = this.RightFlipView.SelectedIndex < this.RightFlipView.Items.Count - 1 ? ++this.RightFlipView.SelectedIndex : 0;
            };
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void juece2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(deal));
        }

        private void tuijian2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Recommend));
        }

        private void paihang2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ranking));
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            NewsManager.GetAllItems(NewsItems);
            Suggestions = NewsItems.Where(p => p.Headline.StartsWith(sender.Text)).Select(p => p.Headline).ToList();
            AutoSuggestBox.ItemsSource = Suggestions;
        }

        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            NewsManager.GetNewsItemsByHeadline(NewsItems, sender.Text);
        }

        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            NewsItem suggest = args.SelectedItem as NewsItem;
            if (suggest == null)
                return;
            sender.Text = suggest.Headline;
        }

        /*private void CenterFlipView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
                this.Frame.Navigate(typeof(comment));
            
            
        }
        */
        private void MyGridview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(comment),((NewsItem)e.ClickedItem).Id);
        }
    }

}
