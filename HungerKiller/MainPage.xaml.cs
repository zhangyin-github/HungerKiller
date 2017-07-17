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
            Homepage.IsSelected = true;           
            if(!MySplitView.IsPaneOpen)
            {
                BaseList.Visibility = Visibility.Collapsed;
                Setting_1.Visibility = Visibility.Collapsed;
                Setting_2.Visibility = Visibility.Visible;
            }
            else
            {
                BaseList.Visibility = Visibility.Visible;
                Setting_1.Visibility = Visibility.Visible;
                Setting_2.Visibility = Visibility.Collapsed;
            }
        }
      
     

        private void BaseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HamburgerButton.IsSelected)
            {
                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
                if (!MySplitView.IsPaneOpen)
                {
                    BaseList.Visibility = Visibility.Collapsed;
                    Setting_1.Visibility = Visibility.Collapsed;
                    Setting_2.Visibility = Visibility.Visible;
                }
                else
                {
                    BaseList.Visibility = Visibility.Visible;
                    Setting_1.Visibility = Visibility.Visible;
                    Setting_2.Visibility = Visibility.Collapsed;
                }
            }
            else if (Homepage.IsSelected)
            {

                MyFrame.Navigate(typeof(homepage));
            }
            else if (Deal.IsSelected)
            {

                MyFrame.Navigate(typeof(deal));
            }
        }

        private void ManegerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Maneger.IsSelected)
            {
                MyFrame.Navigate(typeof(Maneger));
            }
        }

        private void ControlListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void IfNotSignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Setting_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
             
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
