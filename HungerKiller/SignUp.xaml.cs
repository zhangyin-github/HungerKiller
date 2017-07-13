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

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "123")
            {
                statusText.Text = "'Password' is not allowed as a password.";
            }
            else
            {
                statusText.Text = string.Empty;
            }
        }

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Password == "123")
            {
                statusText1.Text = "'Password' is not allowed as a password.";
            }
            else
            {
                statusText1.Text = string.Empty;
            }
            if (passwordBox1.Password != passwordBox.Password)
            {
                statusText1.Text = "'Password' is not adopt.";
            }
            else
            {
                statusText1.Text = string.Empty;
            }
        }
    }
}
