using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class deal : Page
    {
        public int count= 0;
        public int countt = 0;
        public int  seed=0;
        public  int a = 0;
        public int sewq;
        public deal()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// 点击卡片1左侧按钮的处理办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void CardChooseButtonone_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonOneTwo .Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonOneTwo.FontSize = 40;
                CardChooseButtonone.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonone.Content = "\xE812";
                CardChooseButtonone.FontSize = 40;
            }
            else if (ButtonOneTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonone.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonone.Content = "肉菜";
                CardChooseButtonone.FontSize = 32;
                count = count | 0x01;
                CardChooseButtonone.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }
        /// <summary>
        /// 点击卡片2左侧按钮的处理办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtontwo_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonTwoTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonTwoTwo.FontSize = 40;
                CardChooseButtontwo.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtontwo.Content = "\xE812";
                CardChooseButtontwo.FontSize = 40;
            }
            else if (ButtonTwoTwo .Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontwo.FontFamily = new FontFamily("华文行楷");
                CardChooseButtontwo.Content = "素菜";
                CardChooseButtontwo.FontSize = 32;
                count = count | 0x02;
                CardChooseButtontwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片3左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonthree_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonThreeTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonThreeTwo.FontSize = 40;
                CardChooseButtonthree.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonthree.Content = "\xE812";
                CardChooseButtonthree.FontSize = 40;
            }
            else if (ButtonThreeTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonthree.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonthree.Content = "咸口";
                CardChooseButtonthree.FontSize = 32;
                count = count | 0x04;
                CardChooseButtonthree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片4左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtontfour_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonFourTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonFourTwo.FontSize = 40;
                CardChooseButtontfour.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtontfour.Content = "\xE812";
                CardChooseButtontfour.FontSize = 40;
            }
            else if (ButtonFourTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtontfour.FontFamily = new FontFamily("华文行楷");
                CardChooseButtontfour.Content = "甜口";
                CardChooseButtontfour.FontSize = 32;
                count = count | 0x08;
                CardChooseButtontfour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片5左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonfive_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonFiveTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonFiveTwo.FontSize = 40;
                CardChooseButtonfive.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonfive.Content = "\xE812";
                CardChooseButtonfive.FontSize = 40;
            }
            else if (ButtonFiveTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonfive.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonfive.Content = "辣口";
                CardChooseButtonfive.FontSize = 32;
                count = count | 0x10;
                CardChooseButtonfive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片6左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonsix_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonSixTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSixTwo.FontSize = 40;
                CardChooseButtonsix.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonsix.Content = "\xE812";
                CardChooseButtonsix.FontSize = 40;
            }
            else if (ButtonSixTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonsix.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonsix.Content = "酸口";
                CardChooseButtonsix.FontSize = 32;
                count = count | 0x20;
                CardChooseButtonsix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片7左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonseven_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonSevenTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonSevenTwo.FontSize = 40;
                CardChooseButtonseven.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonseven.Content = "\xE812";
                CardChooseButtonseven.FontSize = 40;
            }
            else if (ButtonSevenTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonseven.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonseven.Content = "凉菜";
                CardChooseButtonseven.FontSize = 32;
                count = count | 0x40;
                CardChooseButtonseven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }
        /// <summary>
        /// 点击卡片8左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtoneight_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonEightTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonEightTwo.FontSize = 40;
                CardChooseButtoneight.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtoneight.Content = "\xE812";
                CardChooseButtoneight.FontSize = 40;
            }
            else if (ButtonEightTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtoneight.FontFamily = new FontFamily("华文行楷");
                CardChooseButtoneight.Content = "热菜";
                CardChooseButtoneight.FontSize = 32;
                count = count | 0x80;
                CardChooseButtoneight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片9左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonnine_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonNineTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonNineTwo.FontSize = 40;
                CardChooseButtonnine.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonnine.Content = "\xE812";
                CardChooseButtonnine.FontSize = 40;
            }
            else if (ButtonNineTwo .Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonnine.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonnine.Content = "米食";
                CardChooseButtonnine.FontSize = 32;
                count = count | 0x100;
                CardChooseButtonnine.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片10左侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardChooseButtonten_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonTenTwo.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ButtonTenTwo.FontSize = 40;
                CardChooseButtonten.FontFamily = new FontFamily("Segoe MDL2 Assets");
                CardChooseButtonten.Content = "\xE812";
                CardChooseButtonten.FontSize = 40;
            }
            else if (ButtonTenTwo.Visibility != Windows.UI.Xaml.Visibility.Collapsed)
            {
                ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CardChooseButtonten.FontFamily = new FontFamily("华文行楷");
                CardChooseButtonten.Content = "面食";
                CardChooseButtonten.FontSize = 32;
                count = count | 0x200;
                CardChooseButtonten.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

        /// <summary>
        /// 点击卡片1右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOneTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonone.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonone.Content = "肉菜";
            CardChooseButtonone.FontSize = 32;
            countt = countt | 0x01;
            CardChooseButtonone.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        /// <summary>
        /// 点击卡片2右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTwoTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontwo.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontwo.Content = "素菜";
            CardChooseButtontwo.FontSize = 32;
            countt = countt | 0x02;
            CardChooseButtontwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片3右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonThreeTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonthree.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonthree.Content = "咸口";
            CardChooseButtonthree.FontSize = 32;
            countt = countt | 0x04;
            CardChooseButtonthree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片4右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFourTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontfour.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontfour.Content = "甜口";
            CardChooseButtontfour.FontSize = 32;
            countt = countt | 0x08;
            CardChooseButtontfour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片5右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFiveTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonfive.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonfive.Content = "辣口";
            CardChooseButtonfive.FontSize = 32;
            countt = countt | 0x10;
            CardChooseButtonfive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片6右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSixTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonsix.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonsix.Content = "酸口";
            CardChooseButtonsix.FontSize = 32;
            countt = countt | 0x20;
            CardChooseButtonsix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片7右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSevenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonseven.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonseven.Content = "凉菜";
            CardChooseButtonseven.FontSize = 32;
            countt = countt | 0x40;
            CardChooseButtonseven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片8右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEightTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtoneight.FontFamily = new FontFamily("华文行楷");
            CardChooseButtoneight.Content = "热菜";
            CardChooseButtoneight.FontSize = 32;
            countt = countt | 0x80;
            CardChooseButtoneight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击卡片9右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNineTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonnine.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonnine.Content = "米食";
            CardChooseButtonnine.FontSize = 32;
            countt = countt | 0x100;
            CardChooseButtonnine.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        /// <summary>
        /// 点击卡片10右侧按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonten.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonten.Content = "面食";
            CardChooseButtonten.FontSize = 32;
            countt = countt | 0x200;
            CardChooseButtonten.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }
        /// <summary>
        /// 点击转盘上的更新按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateTurntable_Click(object sender, RoutedEventArgs e)
        {
            //Randomm df= new Randomm();
            //int[] dishneworder = new int[8];
            //dishneworder = await df.differSamenessRandomNum(8, 0, hahaha.getinstance().getDish().Count);
            int x = hahaha.getinstance().getDish().Count();
            var url = "http://localhost:8080/HungerKillerBacked/HungerKiller/";
            DishOneText.Text = hahaha.getinstance().getDish()[x-1].Key;
            DishOneImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-1].Value,UriKind.RelativeOrAbsolute));
            DishTwoText.Text = hahaha.getinstance().getDish()[x-2].Key;
            DishTwoImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-2].Value,UriKind.RelativeOrAbsolute));
            DishThreeText.Text = hahaha.getinstance().getDish()[x-3].Key;
            DishThreeImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-3].Value,UriKind.RelativeOrAbsolute));
            DishFourText.Text = hahaha.getinstance().getDish()[x-4].Key;
            DishFourIamge.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-4].Value,UriKind.RelativeOrAbsolute));
            DishFiveText.Text = hahaha.getinstance().getDish()[x-5].Key;
            DishFiveImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-5].Value,UriKind.RelativeOrAbsolute));
            DishSixText.Text = hahaha.getinstance().getDish()[x-6].Key;
            DishSixImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-6].Value,UriKind.RelativeOrAbsolute));
            DishSevenText.Text = hahaha.getinstance().getDish()[x-7].Key;
            DishSevenImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-7].Value,UriKind.RelativeOrAbsolute));
            DishEightText.Text = hahaha.getinstance().getDish()[x-8].Key;
            DishEightImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[x-8].Value,UriKind.RelativeOrAbsolute));
        }

        /// <summary>
        /// 点击转盘上的开始选择按钮的解决方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                sewq = 0;
                var rd = new Random();
                seed = rd.Next(2000, 3000)+sewq;
                stdDish1.Begin();
                TimeSpan delay = TimeSpan.FromMilliseconds(seed);
                ThreadPoolTimer DelayTimer = ThreadPoolTimer.CreateTimer(async (source) =>
                      {
                          await Dispatcher.RunAsync(
                 CoreDispatcherPriority.High,
                 () =>
                 {
                     stdDish1.Pause();
                 });
                      }, delay);
                a = 1;
            }
            else if (a == 1)
            {
                var rd = new Random();
                seed = rd.Next(2000, 3000);
                stdDish1.Resume();
                TimeSpan delay = TimeSpan.FromMilliseconds(seed);
                ThreadPoolTimer DelayTimer = ThreadPoolTimer.CreateTimer(async (source) =>
                {
                    await Dispatcher.RunAsync(
           CoreDispatcherPriority.High,
           () =>
           {
               stdDish1.Pause();
           });
                }, delay);
            }
            TimeSpan sed = TimeSpan.FromMilliseconds(seed);
            ThreadPoolTimer dehaha = ThreadPoolTimer.CreateTimer(async (source) =>
              {
                  await Dispatcher.RunAsync(
                     CoreDispatcherPriority.High,
                     async () =>
                     {
                         Dealturnresult de = new Model.Dealturnresult();
                         int x = (seed + sewq) % 1600;
                         int y = x / 200;
                         sewq = x;
                         bool Isok=false;
                         if (y == 0)
                         {
                              Isok=await de.dealturnresult(DishOneText.Text);
                             if (Isok)
                             {FinalImage.Source = DishOneImage.Source;}
                             else
                             {ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         else if (y == 1)
                         {
                            Isok=await de.dealturnresult(DishTwoText.Text);
                             if (Isok)
                             { FinalImage.Source = DishTwoImage.Source;}
                             else
                             { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible;}
                          
                         }
                         else if (y == 2)
                         {
                             Isok = await de.dealturnresult(DishThreeText.Text);
                             if (Isok)
                             { FinalImage.Source = DishThreeImage.Source;}
                             else
                             { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible;}
                         }
                         else if (y == 3)
                         {
                             Isok=await de.dealturnresult(DishFourText.Text);
                             if (Isok)
                             { FinalImage.Source = DishFourIamge.Source;}
                             else { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         else if (y == 4)
                         {
                             Isok=await de.dealturnresult(DishFiveText.Text);
                             if (Isok)
                             { FinalImage.Source = DishFiveImage.Source; }
                             else { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         else if (y == 5)
                         {
                             Isok=await de.dealturnresult(DishSixText.Text);
                             if (Isok)
                             { FinalImage.Source = DishSixImage.Source; }
                             else { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         else if (y == 6)
                         {
                             Isok= await de.dealturnresult(DishSevenText.Text);
                             if (Isok)
                             { FinalImage.Source = DishSevenImage.Source; }
                             else { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         else if (y == 7)
                         {
                             Isok=await de.dealturnresult(DishEightText.Text);
                             if (Isok)
                             { FinalImage.Source = DishEightImage.Source; }
                             else { ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Visible; }
                         }
                         if (Isok)
                         {
                             ERRORtextblock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                             DishName.Text = dealturninformation.getdealff().getDishinformation()[0].dishnamee;
                             DishScore.Text = dealturninformation.getdealff().getDishinformation()[0].dishscoree;
                             DishIngre.Text = dealturninformation.getdealff().getDishinformation()[0].dishclasss;
                             DishFloor.Text = dealturninformation.getdealff().getDishinformation()[0].dishfloors;
                             DishWindow.Text = dealturninformation.getdealff().getDishinformation()[0].dishpositions;
                             DishAmount.Text = dealturninformation.getdealff().getDishinformation()[0].dishmount;
                         }
                     });
              }, sed);
        }
        /// <summary>
        /// 点击最后的决定按钮的解决方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FinalOkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sc = OneUser.name;
                if (OneUser.name == null)
                { sc = "佚名"; }
                System.Net.Http.HttpClient cl = new System.Net.Http.HttpClient();
                var url = "http://localhost:8080/HungerKillerBacked/FionalOk.jsp";
                string st = "dishname=" + DishName.Text + "&";
                st += "username=" +sc;
                System.Net.Http.StringContent cons = new StringContent(st, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                System.Net.Http.HttpResponseMessage response = await cl.PostAsync(url, cons);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArraysss = resdata.Split('"');
                if (SArraysss[3]=="1")
                {
                    peipei.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
                else
                {
                    ERRORtextblock.Visibility= Windows.UI.Xaml.Visibility.Visible;
                }

            }
            catch
            {

            }
        }
        /// <summary>
        /// 点击卡片下面的决策按钮的解决办法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DealManager dealmanager = new DealManager();
            List<turn> turntab = new List<turn>();
            dealmanager.DealCountAndCountt(count, countt);

            TimeSpan sed = TimeSpan.FromMilliseconds(1000);
            ThreadPoolTimer dehaha = ThreadPoolTimer.CreateTimer(async (source) =>
            {
                await Dispatcher.RunAsync(
                   CoreDispatcherPriority.High,
                   () =>
                   {
                       Randomm res = new Randomm();
                     //  int[] dishorder = await res.differSamenessRandomNum(8, 0, hahaha.getinstance().getDish().Count());
                       ChooseButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                       UpdateTurntable.Visibility = Windows.UI.Xaml.Visibility.Visible;
                       DishOneText.Text = hahaha.getinstance().getDish()[0].Key;
                       var url = "http://localhost:8080/HungerKillerBacked/HungerKiller/";
                       DishOneImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[0].Value, UriKind.Absolute));
                       DishTwoText.Text = hahaha.getinstance().getDish()[1].Key;
                       DishTwoImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[1].Value, UriKind.Absolute));
                       DishThreeText.Text = hahaha.getinstance().getDish()[2].Key;
                       DishThreeImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[2].Value, UriKind.RelativeOrAbsolute));
                       DishFourText.Text = hahaha.getinstance().getDish()[3].Key;
                       DishFourIamge.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[3].Value, UriKind.RelativeOrAbsolute));
                       DishFiveText.Text = hahaha.getinstance().getDish()[4].Key;
                       DishFiveImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[4].Value, UriKind.RelativeOrAbsolute));
                       DishSixText.Text = hahaha.getinstance().getDish()[5].Key;
                       DishSixImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[5].Value, UriKind.RelativeOrAbsolute));
                       DishSevenText.Text = hahaha.getinstance().getDish()[6].Key;
                       DishSevenImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[6].Value, UriKind.RelativeOrAbsolute));
                       DishEightText.Text = hahaha.getinstance().getDish()[7].Key;
                       DishEightImage.Source = new BitmapImage(new Uri(url + hahaha.getinstance().getDish()[7].Value, UriKind.RelativeOrAbsolute));
                   });
            }, sed);
        }
    }
    }

