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
            if (passwordBox.Password.Length<6)
            {
                statusText2.Text = "密码不少于6位.";
            }
            else
            {
                statusText2.Text = string.Empty;
            }
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (username.Text.Length < 4)
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MyCheckBox1.IsChecked == MyCheckBox2.IsChecked == MyCheckBox3.IsChecked == MyCheckBox4.IsChecked == MyCheckBox5.IsChecked==MyCheckBox6.IsChecked == false)
            {
                statusText5.Text = "选一个口味嘛";
            }
            else
            {
                statusText5.Text = string.Empty;
            }
            if (YesRadioButton.IsChecked==NoRadioButton.IsChecked)
            {
                statusText6.Text = "告诉人家推不推送嘛";
            }
            else
            {
                statusText6.Text = string.Empty;
            }
        }
    }
}
