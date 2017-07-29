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

// “内容对话框”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上进行了说明

namespace HungerKiller
{
    public sealed partial class Sign_In : ContentDialog
    {
        public Sign_In()
        {
            this.InitializeComponent();
        }

        private async void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            /* if ((passwordBox.Password == "123456") && (username.Text == "admin"))
             {
                 args.Cancel = true;
                 statusText6.Text = "用户名或密码错误";

             }
             if ((passwordBox.Password.Length == 0) || (username.Text.Length == 0))
             {
                 args.Cancel = true;
                 statusText6.Text = "东西都不写全还想登录？？？";

             }
             else
             {
                 OneUser.name = username.Text;
                 OneUser.password = passwordBox.Password;
                 Signinn sin = new Signinn();
                 await sin.siginin(OneUser.name, OneUser.password);

                 if (User.category==3)
                 {





                     if (autosignin.IsChecked.Value == true)
                     {
                         mima_rem.IsChecked = true;
                         string checksignin = "true";
                         Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                         Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                         localSettings.Values["UserStoredautosignin"] = checksignin;
                     }
                     else
                     {
                         string checksignin2 = "false";
                         Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                         Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                         localSettings.Values["UserStoredautosignin"] = checksignin2;
                     }
                     if (mima_rem.IsChecked.HasValue && mima_rem.IsChecked.Value)
                     {
                         Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                         Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                         //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                         localSettings.Values["UserStoredPassword"] = passwordBox.Password;
                         localSettings.Values["UserStoredUsername"] = username.Text;
                     }
                     else
                     {
                         Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                         Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                         //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                         localSettings.Values["UserStoredPassword"] = null;
                         localSettings.Values["UserStoredUsername"] = null;
                     }
                     User.sign_or_not = true;
                     tiao1.jm1 = true;
                 }
                 else {
                     args.Cancel = true;
                     statusText6.Text = "东西都不写全还想登录？？？";
                 }
             }*/

        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            tiao.jm = true;
        }

        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            object UserStored = localSettings.Values["UserStoredPassword"];
            if (UserStored != null)
            {
                //OneUser oneUser = UserStored as OneUser;
                //username.Text = oneUser.name;
                passwordBox.Password = UserStored as string;

            }
            object UserStored1 = localSettings.Values["UserStoredUsername"];
            if (UserStored1 != null)
            {
                //OneUser oneUser = UserStored as OneUser;
                //username.Text = oneUser.name;
                username.Text = UserStored1 as string;

            }

        }

        public void checkson()
        {
            if (autosignin.IsChecked.Value == true)
            {
                mima_rem.IsChecked = true;
                string checksignin = "true";
                Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                localSettings.Values["UserStoredautosignin"] = checksignin;
            }
            else
            {
                string checksignin2 = "false";
                Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                localSettings.Values["UserStoredautosignin"] = checksignin2;
            }
            if (mima_rem.IsChecked.HasValue && mima_rem.IsChecked.Value)
            {
                Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                localSettings.Values["UserStoredPassword"] = passwordBox.Password;
                localSettings.Values["UserStoredUsername"] = username.Text;
            }
            else
            {
                Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                localSettings.Values["UserStoredPassword"] = null;
                localSettings.Values["UserStoredUsername"] = null;
            }
            User.sign_or_not = true;
            statusText6.Text = "登录成功，点击关闭回到主页";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((passwordBox.Password.Length == 0) || (username.Text.Length == 0))
            {
                //args.Cancel = true;
                statusText6.Text = "东西都不写全还想登录？？？";

            }
            else
            {
                OneUser.name = username.Text;
                OneUser.password = passwordBox.Password;
                Signinn sin = new Signinn();
                await sin.siginin(OneUser.name, OneUser.password);

                if (User.category == 4)
                {
                    checkson();
                    /*if (autosignin.IsChecked.Value == true)
                    {
                        mima_rem.IsChecked = true;
                        string checksignin = "true";
                        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                        localSettings.Values["UserStoredautosignin"] = checksignin;
                    }
                    else
                    {
                        string checksignin2 = "false";
                        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                        localSettings.Values["UserStoredautosignin"] = checksignin2;
                    }
                    if (mima_rem.IsChecked.HasValue && mima_rem.IsChecked.Value)
                    {
                        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                        //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                        localSettings.Values["UserStoredPassword"] = passwordBox.Password;
                        localSettings.Values["UserStoredUsername"] = username.Text;
                    }
                    else
                    {
                        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                        Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                        //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                        localSettings.Values["UserStoredPassword"] = null;
                        localSettings.Values["UserStoredUsername"] = null;
                    }
                    User.sign_or_not = true;
                    statusText6.Text = "登录成功，点击关闭回到主页";
                    //tiao1.jm1 = true;
                }
                else
                {
                    //args.Cancel = true;
                    statusText6.Text = "东西都不写全还想登录？？？";
                }*/
                }
                else if (User.category == 3)
                {
                    checkson();
                }
                else if (User.category == 2)
                {
                    statusText6.Text = "您的账号已在别处登录";
                }
                else if (User.category == 1)
                {
                    statusText6.Text = "用户名或密码错误";
                }
                else 
                {
                    statusText6.Text = "服务器连接失败，请检查网络后重试";
                }
            }


        }
    }
}
