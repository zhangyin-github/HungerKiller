using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
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
            //隐藏返回按钮
            

            MyFrame.Navigate(typeof(homepage));
            Homepage.IsSelected = true;
            IfSplitViewOpen();

            

            //扩展到标题栏
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(RealTitle);
            //设置标题栏颜色
            MakeTitleBarBeautiful();
        }
        /// <summary>
        /// 设置标题栏颜色
        /// Sakura
        /// </summary>
        public void MakeTitleBarBeautiful()
        {
            
            var view = ApplicationView.GetForCurrentView();

            //active
            view.TitleBar.BackgroundColor = Color.FromArgb(255, 254, 103, 74);
            view.TitleBar.ForegroundColor = Colors.White;
            //inactive
            view.TitleBar.InactiveBackgroundColor = Color.FromArgb(255, 254, 103, 74);
            view.TitleBar.InactiveForegroundColor = Colors.White;

            //button
            view.TitleBar.ButtonBackgroundColor = Color.FromArgb(255, 254, 103, 74);
            view.TitleBar.ButtonForegroundColor = Colors.White;

            view.TitleBar.ButtonHoverBackgroundColor = Color.FromArgb(255, 255, 149, 86);
            view.TitleBar.ButtonHoverForegroundColor = Colors.White;

            view.TitleBar.ButtonPressedBackgroundColor = Color.FromArgb(255, 255, 149, 86);
            view.TitleBar.ButtonPressedForegroundColor = Colors.White;

            view.TitleBar.ButtonInactiveBackgroundColor = Color.FromArgb(255, 255, 149, 86);
            view.TitleBar.ButtonInactiveForegroundColor = Color.FromArgb(255, 254, 103, 74);            
        }

        /// <summary>
        /// 隐藏汉堡菜单内的标题栏
        /// Sakura
        /// </summary>
        public void IfSplitViewOpen()
        {
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


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            ManegerListBox.SelectedIndex = -1;
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            IfSplitViewOpen();            
        }


        /// <summary>
        /// 汉堡菜单-基本部分
        /// Sakura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            if (Homepage.IsSelected)
            {
                //隐藏返回按钮
                

                ManegerListBox.SelectedIndex = -1;
                MyFrame.Navigate(typeof(homepage));
                IfSplitViewOpen();
            }
            else if (Deal.IsSelected)
            {              
                ManegerListBox.SelectedIndex = -1;
                MyFrame.Navigate(typeof(deal));
                IfSplitViewOpen();
            }
            else if (Today.IsSelected)
            {
                ManegerListBox.SelectedIndex = -1;
                MyFrame.Navigate(typeof(Recommend));
                IfSplitViewOpen();
            }
            else if (ph.IsSelected)
            {
                ManegerListBox.SelectedIndex = -1;
                MyFrame.Navigate(typeof(Ranking));
                IfSplitViewOpen();
            }

        }
        /// <summary>
        /// 汉堡菜单-管理员部分
        /// Sakura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManegerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            if (Maneger.IsSelected)
            {
                BaseListBox.SelectedIndex = -1;
                MyFrame.Navigate(typeof(Maneger));
                IfSplitViewOpen();
            }
        }


        //汉堡菜单-用户登录、个人资料、设置入口 

        /// <summary>
        /// 用户登录、个人资料入口   
        /// 若登录，打开个人资料
        /// 未登录，打开登录页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UserName_Click(object sender, RoutedEventArgs e)
        {
            ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;
            if (User.sign_or_not==false)
            {
                Sign_In jump = new Sign_In();
                await jump.ShowAsync();
                if (tiao.jm == true)
                {
                    

                    Frame.Navigate(typeof(SignUp));
                    tiao.jm = false;
                }
                if (tiao1.jm1 == true)
                {
                    ContentDialog1 m = new ContentDialog1();
                    m.ShowAsync();
                    tiao1.jm1 = false;
                }
            }
             else
             {
                //bool asd = User.sign_or_not;
               // Frame.Navigate(typeof(MainPage));
                if (User.category == 4)
                {
                    MySettingStackPanel.Visibility = Visibility.Visible;
                }
                else
                {
                    MySettingStackPanel.Visibility = Visibility.Collapsed;
                }
                MySettingSplitView.IsPaneOpen = false;
                SelfInfoSplitView.IsPaneOpen = !SelfInfoSplitView.IsPaneOpen;
                //Frame.Navigate(this.GetType());
            }
             
        }

        /// <summary>
        /// 设置按钮
        /// Sakura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySettingButton_Click(object sender, RoutedEventArgs e)
        {
            ManegerListBox.SelectedIndex = BaseListBox.SelectedIndex = -1;
            MySettingSplitView.IsPaneOpen = !MySettingSplitView.IsPaneOpen;
            SelfInfoSplitView.IsPaneOpen = false;
        }


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



        //与登录、注销有关

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer localSettings5 = Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder1 = Windows.Storage.ApplicationData.Current.LocalFolder;
            object kongjian = localSettings5.Values["UserStoredautosignin"];
            string kongzhi = kongjian as string;
            if (kongjian == "true")
            {
                User.sign_or_not = true;
            }
            else
            {
                User.sign_or_not = false;
            }


            if (User.category == 4)
            {
                MySettingStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                MySettingStackPanel.Visibility = Visibility.Collapsed;
            }
            if (User.sign_or_not == false)
            {
                Windows.Storage.ApplicationDataContainer localSettings1 = Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder3 = Windows.Storage.ApplicationData.Current.LocalFolder;
                object UserStored3 = localSettings1.Values["UserStoredautologout"];
                zidongzhuxiao.zhuxiaoming = UserStored3 as string;

                Signinn six = new Model.Signinn();
                six.loginout(zidongzhuxiao.zhuxiaoming);
            }
            if (tiao.jm == true)
            {
                Frame.Navigate(typeof(SignUp));
            }
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            object UserStored2 = localSettings.Values["UserStoredautosignin"];
            if(UserStored2 as string == "true")
            {
                User.sign_or_not = true;
            }
            else
            {
                User.sign_or_not = false;
            }
            AllDish alllss = new Model.AllDish();
            alllss.getalldish();

            //MySettingStackPanel.Visibility = Visibility.Collapsed;
        }




        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignOutSetting_Click(object sender, RoutedEventArgs e)
        {
            if (User.sign_or_not == true)
            {
                User.sign_or_not = false;
                Signinn six1 = new Model.Signinn();
                six1.loginout(OneUser.name);
                OneUser.name = null;
                OneUser.password = null; 
                string checksignin2 = "false";
                    Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    localSettings.Values["UserStoredautosignin"] = checksignin2;
                User.category = 0;
                
                logout signout = new logout();
                signout.ShowAsync();

                SelfInfoSplitView.IsPaneOpen = false;
            }
        }

        /// <summary>
        /// 返回上一页
        /// Sakura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        
    }
}
