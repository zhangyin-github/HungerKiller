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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HungerKiller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(homepage));
            TitleTextBlock.Text = "主页";
            Homepage.IsSelected = true;           
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Homepage.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Homepage.IsSelected)
            {

                MyFrame.Navigate(typeof(homepage));
                TitleTextBlock.Text = "主页";
            }
            else if (Deal.IsSelected)
            {

                MyFrame.Navigate(typeof(deal));
                TitleTextBlock.Text = "趣味决策";
            }
            else if (Maneger.IsSelected)
            {

                MyFrame.Navigate(typeof(Maneger));
                TitleTextBlock.Text = "趣味决策";
            }
            else if (SignUp.IsSelected)
            {

                MyFrame.Navigate(typeof(SignUp));
                TitleTextBlock.Text = "趣味决策";
            }         
        }
        /*
        private void LoggedButton_Click(object sender, RoutedEventArgs e)
        {

            MyFrame.Navigate(typeof(LoginPage));
            TitleTextBlock.Text = "登录";
        }
        */
    }
}
