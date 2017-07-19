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
            IfSplitViewOpen();
        }

        public void IfSplitViewOpen()
        {
            if (!MySplitView.IsPaneOpen)
            {
                BaseList.Visibility = Visibility.Collapsed;
                Setting_1.Visibility = Visibility.Collapsed;
                SettingListBox_2.Visibility = Visibility.Visible;
            }
            else
            {
                BaseList.Visibility = Visibility.Visible;
                Setting_1.Visibility = Visibility.Visible;
                SettingListBox_2.Visibility = Visibility.Collapsed;
            }
        }


        private void BaseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HamburgerButton.IsSelected)
            {
                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
                IfSplitViewOpen();
            }
            else if (Homepage.IsSelected)
            {
                MyFrame.Navigate(typeof(homepage));
                IfSplitViewOpen();
            }
            else if (Deal.IsSelected)
            {
                MyFrame.Navigate(typeof(deal));
                IfSplitViewOpen();
            }
        }

        private void ManegerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Maneger.IsSelected)
            {
                MyFrame.Navigate(typeof(Maneger));
                IfSplitViewOpen();
            }
        }



        /*  SplitView 打开时点击用户头像，这是个button_click事件*/
        /* 横版的用户登录入口*/
        private void MyUserHeaderImageButton_1_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 点击未登录提示符，可以跳转至登录或注册页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IfNotSignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 点击用户名，可以打开个人信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserName_Click(object sender, RoutedEventArgs e)
        {

        }


        /*  SplitView 关闭时点击用户头像、或者设置按钮，这是个ListBoxSelectionChanged事件*/
        /*竖版的用户登录入口及设置按钮*/
        private void SettingListBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyUserHeaderImage_2.IsSelected)
            {
                //判断已经登录？ 否，则打开登录页面
                /*MyFrame.Navigate(typeof(SignIn));//SignIn为登录界面*/
                //已登录则打开个人资料侧滑框
            }
        }

        private void MySettingButton_Click(object sender, RoutedEventArgs e)
        {
            // MyFrame.Navigate(typeof(Setting));
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
