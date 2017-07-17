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
using System.Globalization;
using System.Text.RegularExpressions;
using HungerKiller.Model;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SignUp : Page
    {
        public SignUp()
        {
            this.InitializeComponent();
        }

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Password != passwordBox.Password)
            {
                statusText3.Text = "Password is not adopt.";
            }
            else
            {
                statusText3.Text = string.Empty;
            }
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "123")
            {
                statusText2.Text = "'123' is not allowed as a password.";
            }
            else
            {
                statusText2.Text = string.Empty;
            }
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (username.Text.Length<4)
            {
                statusText1.Text = "用户名不少于4位.";
            }
            else
            {
                statusText1.Text = string.Empty;
            }
        }

        private void mail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string strIn = mail.Text;
            RegexUtilities a = new RegexUtilities();
            bool b=a.IsValidEmail(strIn);
           if (!b)
            {
                statusText4.Text = "请输入正确的邮箱格式.";
            }
            else
            {
                statusText4.Text = string.Empty;
            }
        }
    }
}
