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
    public sealed partial class deal : Page
    {
        public int count = 0;
        public int countt = 0;
        public deal()
        {
            this.InitializeComponent();
        }
        private void CardChooseButtonone_Click(object sender, RoutedEventArgs e)
        {
            if (T1.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonOneTwo.FontSize = 40;
                T1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonone.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonone.Content = "\xE812";
                CardChooseButtonone.FontSize = 40;
            }
            else if (T1.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonone.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonone.Content = "肉菜";
                CardChooseButtonone.FontSize = 32;
                T1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x01;
            }
        }

        private void CardChooseButtontwo_Click(object sender, RoutedEventArgs e)
        {
            if (T2.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonTwoTwo.FontSize = 40;
                T2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontwo.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtontwo.Content = "\xE812";
                CardChooseButtontwo.FontSize = 40;
            }
            else if (T2.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontwo.FontFamily = new FontFamily("华文行楷");
                CardChooseButtontwo.Content = "素菜";
                CardChooseButtontwo.FontSize = 32;
                T2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x02;
            }
        }

        private void CardChooseButtonthree_Click(object sender, RoutedEventArgs e)
        {
            if (T3.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonThreeTwo.FontSize = 40;
                T3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonthree.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonthree.Content = "\xE812";
                CardChooseButtonthree.FontSize = 40;
            }
            else if (T3.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonthree.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonthree.Content = "咸口";
                CardChooseButtonthree.FontSize = 32;
                T3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x04;
            }
        }

        private void CardChooseButtontfour_Click(object sender, RoutedEventArgs e)
        {
            if (T4.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonFourTwo.FontSize = 40;
                T4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontfour.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtontfour.Content = "\xE812";
                CardChooseButtontfour.FontSize = 40;
            }
            else if (T4.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontfour.FontFamily = new FontFamily("华文行楷");
                CardChooseButtontfour.Content = "甜口";
                CardChooseButtontfour.FontSize = 32;
                T4.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x08;
            }
        }

        private void CardChooseButtonfive_Click(object sender, RoutedEventArgs e)
        {
            if (T5.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonFiveTwo.FontSize = 40;
                T5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonfive.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonfive.Content = "\xE812";
                CardChooseButtonfive.FontSize = 40;
            }
            else if (T5.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonfive.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonfive.Content = "辣口";
                CardChooseButtonfive.FontSize = 32;
                T5.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x10;
            }
        }

        private void CardChooseButtonsix_Click(object sender, RoutedEventArgs e)
        {
            if (T6.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSixTwo.FontSize = 40;
                T6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonsix.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonsix.Content = "\xE812";
                CardChooseButtonsix.FontSize = 40;
            }
            else if (T6.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonsix.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonsix.Content = "凉菜";
                CardChooseButtonsix.FontSize = 32;
                T6.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x20;
            }
        }

        private void CardChooseButtonseven_Click(object sender, RoutedEventArgs e)
        {
            if (T7.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSevenTwo.FontSize = 40;
                T7.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonseven.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonseven.Content = "\xE812";
                CardChooseButtonseven.FontSize = 40;
            }
            else if (T7.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonseven.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonseven.Content = "热菜";
                CardChooseButtonseven.FontSize = 32;
                T7.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x40;
            }
        }
        private void CardChooseButtoneight_Click(object sender, RoutedEventArgs e)
        {
            if (T8.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonEightTwo.FontSize = 40;
                T8.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtoneight.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtoneight.Content = "\xE812";
                CardChooseButtoneight.FontSize = 40;
            }
            else if (T8.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtoneight.FontFamily = new FontFamily("华文行楷");
                CardChooseButtoneight.Content = "汤多";
                CardChooseButtoneight.FontSize = 32;
                T8.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x80;
            }
        }

        private void CardChooseButtonnine_Click(object sender, RoutedEventArgs e)
        {
            if (T9.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonNineTwo.FontSize = 40;
                T9.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonnine.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonnine.Content = "\xE812";
                CardChooseButtonnine.FontSize = 40;
            }
            else if (T9.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonnine.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonnine.Content = "米食";
                CardChooseButtonnine.FontSize = 32;
                T9.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x100;
            }
        }

        private void CardChooseButtonten_Click(object sender, RoutedEventArgs e)
        {
            if (T10.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonTenTwo.FontSize = 40;
                T10.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonten.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonten.Content = "\xE812";
                CardChooseButtonten.FontSize = 40;
            }
            else if (T10.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonten.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonten.Content = "汤多";
                CardChooseButtonten.FontSize = 32;
                T10.Visibility = Windows.UI.Xaml.Visibility.Visible;
                count = count | 0x200;
            }
        }

        private void ButtonOneTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonone.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonone.Content = "肉菜";
            CardChooseButtonone.FontSize = 32;
            T1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x01;
        }

        private void ButtonTwoTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontwo.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontwo.Content = "素菜";
            CardChooseButtontwo.FontSize = 32;
            T2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x02;
        }

        private void ButtonThreeTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonthree.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonthree.Content = "甜口";
            CardChooseButtonthree.FontSize = 32;
            T3.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x04;
        }

        private void ButtonFourTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontfour.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontfour.Content = "咸口";
            CardChooseButtontfour.FontSize = 32;
            T4.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x08;
        }

        private void ButtonFiveTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonfive.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonfive.Content = "辣口";
            CardChooseButtonfive.FontSize = 32;
            T5.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x10;
        }

        private void ButtonSixTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonsix.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonsix.Content = "凉菜";
            CardChooseButtonsix.FontSize = 32;
            T6.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x20;
        }

        private void ButtonSevenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonseven.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonseven.Content = "热菜";
            CardChooseButtonseven.FontSize = 32;
            T7.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x40;
        }

        private void ButtonEightTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtoneight.FontFamily = new FontFamily("华文行楷");
            CardChooseButtoneight.Content = "汤多";
            CardChooseButtoneight.FontSize = 32;
            T8.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x80;
        }

        private void ButtonNineTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonnine.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonnine.Content = "米食";
            CardChooseButtonnine.FontSize = 32;
            T9.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x100;
        }

        private void ButtonTenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonten.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonten.Content = "肉菜";
            CardChooseButtonten.FontSize = 32;
            T10.Visibility = Windows.UI.Xaml.Visibility.Visible;
            countt = countt | 0x200;
        }

        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            System.DateTime Currenttime = new System.DateTime();
            int se = Currenttime.Second;
            int br = se % 10;

        }
    }
}
