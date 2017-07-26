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

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            if ((passwordBox.Password == "123456") && (username.Text == "admin"))
            {
                args.Cancel = true;
                statusText6.Text = "用户名或密码错误";

            }
            if ((passwordBox.Password.Length==0) || (username.Text.Length == 0))
            {
                args.Cancel = true;
                statusText6.Text = "东西都不写全还想登录？？？";

            }
            else
            {
                if(mima_rem.IsChecked.HasValue && mima_rem.IsChecked.Value)
                {
                    Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    //OneUser oneUser = new OneUser() { name = username.Text, password = passwordBox.Password };
                    localSettings.Values["UserStoredPassword"] = passwordBox.Password;
                    localSettings.Values["UserStoredUsername"] = username.Text;
                }
                tiao1.jm1 = true;
            }

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



        /* private void Button_Click(object sender, RoutedEventArgs e)
         {
             Sign_In a = new Sign_In();
             a.Hide();

         }*/
    }
}
