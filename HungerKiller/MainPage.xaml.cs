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
            if(Setting_1.Visibility==Visibility.Visible)
            {                
                if(UserName_1.Width<=67)
                {
                    IfUserNameSoLong.Visibility = Visibility.Collapsed;
                }
                else
                {
                    IfUserNameSoLong.Visibility = Visibility.Visible;
                }
            }
        }
     

        private void BaseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            if (HamburgerButton.IsSelected)
            {
                ManegerListBox.SelectedIndex = SettingListBox_2.SelectedIndex = -1;
                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
                IfSplitViewOpen();
            }
            else if (Homepage.IsSelected)
            {
                ManegerListBox.SelectedIndex = SettingListBox_2.SelectedIndex = -1;
                MyFrame.Navigate(typeof(homepage));
                IfSplitViewOpen();
            }
            else if (Deal.IsSelected)
            {
                ManegerListBox.SelectedIndex = SettingListBox_2.SelectedIndex = -1;
                MyFrame.Navigate(typeof(deal));
                IfSplitViewOpen();
            }
        }

        private void ManegerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            if (Maneger.IsSelected)
            {
                BaseListBox.SelectedIndex = SettingListBox_2.SelectedIndex = -1;
                MyFrame.Navigate(typeof(Maneger));
                IfSplitViewOpen();
            }
        }

        /*  SplitView 关闭时点击用户头像、或者设置按钮，这是个ListBoxSelectionChanged事件*/
        /*竖版的用户登录入口及设置按钮*/
        private void SettingListBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            if(MyUserHeaderImage_2.IsSelected)
            {
                ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;

                UserName_Click(sender,e);

                //判断已经登录？ 否，则打开登录页面
                /*MyFrame.Navigate(typeof(SignIn));//SignIn为登录界面*/
                //已登录则打开个人资料侧滑框
            }
            else if(MySettingButton_2.IsSelected)
            {
                ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;
                MySettingSplitView.IsPaneOpen = !MySettingSplitView.IsPaneOpen;
                SelfInfoSplitView.IsPaneOpen = false;
            }
        }
        /// <summary>
        /// 设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySettingButton_Click(object sender, RoutedEventArgs e)
        {
            MySettingSplitView.IsPaneOpen = !MySettingSplitView.IsPaneOpen;
            SelfInfoSplitView.IsPaneOpen = false;
        }

        /// <summary>
        /// 点击用户名或头像位置，若已登录可以打开个人信息页面，否则打开登录页面
        /// SplitView 打开时点击用户头像，这是个button_click事件
        /// 横版的用户登录入口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserName_Click(object sender, RoutedEventArgs e)
        {
            ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;
            //if(未登录)
            Sign_In jump = new Sign_In();
            jump.ShowAsync();
            /*
             else
             {
                
                MySettingSplitView.IsPaneOpen = false;
                SelfInfoSplitView.IsPaneOpen = !SelfInfoSplitView.IsPaneOpen;
            }
             */
        }
        private void UserName_1_Click(object sender, RoutedEventArgs e)
        {
            ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;
            SelfInfoSplitView.IsPaneOpen = !SelfInfoSplitView.IsPaneOpen;
            MySettingSplitView.IsPaneOpen = false;
        }

        //以下是右侧侧滑框内函数



        //以下是右侧侧滑框内函数

        /// <summary>
        /// 账号、设备安全
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountSecuritySetting_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 消息与隐私设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessagePrivacySetting_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 清除缓存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCacheSetting_Click(object sender, RoutedEventArgs e)
        {
           
        }


    }
}
