using System;
using System.Collections.Generic;
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
using HungerKiller.Model;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Maneger : Page
    {
        public Maneger()
        {
            this.InitializeComponent();
           
        }

        private void searchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {

        }

        private string[] selectionItems = new string[] { "张三", "讲座", "麻辣香锅", "麻婆豆腐", "社团活动", "社联活动", "张明", "张思", "王明", "李害了", "老衣" };
        private void searchAutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fabuguanli.IsSelected)
            {

                guanliFrame.Navigate(typeof(pinglunguanli));
                TitleTextBlock.Text = "评论管理";
            }
            else if (pinglunguanli.IsSelected)
            {
                
                TitleTextBlock.Text = "发布管理";
            }
        }

        private void searchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var filtered = selectionItems.Where(p => p.StartsWith(sender.Text)).ToArray();
            searchAutoSuggestBox.ItemsSource = filtered;
        }

        

        private void LogoutComboBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(homepage));
            homepage.IsSelected = true;
        }

        private void PublishActivity_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(publish));
            TitleTextBlock.Text = "发布活动";
        }

        private void PublishDilicious_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(Fabucaiping));
            TitleTextBlock.Text = "发布菜品";
        }

        private void DeleteComments_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(pinglunguanli));
            TitleTextBlock.Text = "评论删除";
        }

        private void RevokeActivity_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(RevokeActivity));
            TitleTextBlock.Text = "活动撤销";
        }
    }
}
