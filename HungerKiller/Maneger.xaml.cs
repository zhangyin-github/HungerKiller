﻿using System;
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

       

        

        private void searchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var filtered = selectionItems.Where(p => p.StartsWith(sender.Text)).ToArray();
            searchAutoSuggestBox.ItemsSource = filtered;
        }

        

        private void LogoutComboBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(homepage));           
            //Homepage.IsSelected = true;
        }

        private void PublishActivity_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(publish));
            
        }

        private void PublishDilicious_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(Fabucaiping));
            
        }

        private void DeleteComments_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(pinglunguanli));
            
        }

        private void RevokeActivity_Click(object sender, RoutedEventArgs e)
        {
            guanliFrame.Navigate(typeof(RevokeActivity));
            
        }

        private void GobackButton_Click(object sender, RoutedEventArgs e)
        {
            if (guanliFrame.CanGoBack)
            {
                guanliFrame.GoBack();
            }
        }
    }
}
