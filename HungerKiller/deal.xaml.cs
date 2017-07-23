using HungerKiller.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
      //  public System.Threading.Timer ti;
        public deal()
        {
            this.InitializeComponent();
        }


   /*   public void TimeS()
        {
            TimeSpan delay = TimeSpan.FromMinutes(1);

            ThreadPoolTimer DelayTimer = ThreadPoolTimer.CreateTimer(
                (source) =>
                {

        Dispatcher.RunAsync(
                        CoreDispatcherPriority.High,
                        () =>
                        {
                            stdDish1.Stop();
            });

                }, delay);
        }
     */   
     /*   public void time()
        {
         ti = new Timer(new TimerCallback(timercall),this,800,0);
         }

        public void timercall(object obj)
        {
          ti.Dispose();
            stdDish1.Stop();
        /*Random rd = new Random();
        seed = rd.Next(1,9);
            switch (seed)
            {
                case 1:
                    DishOne.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 2:
                    DishTwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 3:
                    DishTree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 4:
                    DishFour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 5:
                    DishFive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 6:
                    DishSix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 7:
                    DishSeven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
                case 8:
                    DishEight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                    break;
            }*/
     
     
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
                CardChooseButtonsix.Content = "凉菜";
                CardChooseButtonsix.FontSize = 32;
                count = count | 0x20;
                CardChooseButtonsix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

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
                CardChooseButtonseven.Content = "热菜";
                CardChooseButtonseven.FontSize = 32;
                count = count | 0x40;
                CardChooseButtonseven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }
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
                CardChooseButtoneight.Content = "汤多";
                CardChooseButtoneight.FontSize = 32;
                count = count | 0x80;
                CardChooseButtoneight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
            }
        }

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

        private void ButtonOneTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonOneTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonone.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonone.Content = "肉菜";
            CardChooseButtonone.FontSize = 32;
            countt = countt | 0x01;
            CardChooseButtonone.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonTwoTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTwoTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontwo.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontwo.Content = "素菜";
            CardChooseButtontwo.FontSize = 32;
            countt = countt | 0x02;
            CardChooseButtontwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonThreeTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonThreeTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonthree.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonthree.Content = "咸口";
            CardChooseButtonthree.FontSize = 32;
            countt = countt | 0x04;
            CardChooseButtonthree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonFourTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFourTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtontfour.FontFamily = new FontFamily("华文行楷");
            CardChooseButtontfour.Content = "甜口";
            CardChooseButtontfour.FontSize = 32;
            countt = countt | 0x08;
            CardChooseButtontfour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonFiveTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonFiveTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonfive.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonfive.Content = "辣口";
            CardChooseButtonfive.FontSize = 32;
            countt = countt | 0x10;
            CardChooseButtonfive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonSixTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSixTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonsix.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonsix.Content = "凉菜";
            CardChooseButtonsix.FontSize = 32;
            countt = countt | 0x20;
            CardChooseButtonsix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonSevenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonSevenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonseven.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonseven.Content = "热菜";
            CardChooseButtonseven.FontSize = 32;
            countt = countt | 0x40;
            CardChooseButtonseven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonEightTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonEightTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtoneight.FontFamily = new FontFamily("华文行楷");
            CardChooseButtoneight.Content = "汤多";
            CardChooseButtoneight.FontSize = 32;
            countt = countt | 0x80;
            CardChooseButtoneight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonNineTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonNineTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonnine.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonnine.Content = "米食";
            CardChooseButtonnine.FontSize = 32;
            countt = countt | 0x100;
            CardChooseButtonnine.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void ButtonTenTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonTenTwo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CardChooseButtonten.FontFamily = new FontFamily("华文行楷");
            CardChooseButtonten.Content = "面食";
            CardChooseButtonten.FontSize = 32;
            countt = countt | 0x200;
            CardChooseButtonten.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Green);
        }

        private void UpdateTurntable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            /* if (a == 0)
             {
                 DishOne.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishTwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishTree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishFour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishFive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishSix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishSeven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 DishEight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.White);
                 stdDish1.Begin();
                 a = 1;
             }*/
            if (a == 0)
            {
                sewq = 0;
                var rd = new Random();
                seed = rd.Next(2000, 3000)+sewq;
                stdDish1.Begin();
                TimeSpan delay = TimeSpan.FromMilliseconds(seed);
                ThreadPoolTimer DelayTimer = ThreadPoolTimer.CreateTimer((source) =>
                      {
                          Dispatcher.RunAsync(
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
                ThreadPoolTimer DelayTimer = ThreadPoolTimer.CreateTimer((source) =>
                {
                    Dispatcher.RunAsync(
           CoreDispatcherPriority.High,
           () =>
           {
               stdDish1.Pause();
           });
                }, delay);
            }
            TimeSpan sed = TimeSpan.FromMilliseconds(seed);
            ThreadPoolTimer dehaha = ThreadPoolTimer.CreateTimer((source) =>
              {
                   Dispatcher.RunAsync(
                      CoreDispatcherPriority.High,
                      () =>
                      {
                          int x =(seed+sewq) %1600;
                          int y = x / 200;
                          sewq = x;
                          if (y == 0)
                          {
                              DishName.Text = "菜品1";
                          }
                          else if (y == 1)
                          {
                              DishName.Text = "菜品2";
                          }
                          else if (y == 2)
                          {
                              DishName.Text = "菜品3";
                          }
                          else if (y == 3)
                          {
                              DishName.Text = "菜品4";
                          }
                          else if (y == 4)
                          {
                              DishName.Text = "菜品5";
                          }
                          else if (y == 5)
                          {
                              DishName.Text = "菜品6";
                          }
                          else if (y == 6)
                          {
                              DishName.Text = "菜品7";
                          }
                          else if (y == 7)
                          {
                              DishName.Text = "菜品8";
                          }
                      });
              }, sed);
            
            
            
                  
            /*int a = 0;
                if (DishEight.Background != DishOne.Background && DishOne.Background == DishFour.Background)
                {
                    a = 1;
                }*/
             /*   else if (a == 1)
                {
                    stdDish1.Stop();
                    Random rd = new Random();
                    seed = rd.Next(1, 9);
                    switch (seed)
                    {
                        case 1:
                            DishOne.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 2:
                            DishTwo.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 3:
                            DishTree.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 4:
                            DishFour.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 5:
                            DishFive.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 6:
                            DishSix.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 7:
                            DishSeven.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                        case 8:
                            DishEight.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Black);
                            break;
                    }
                a = 0;
                }*/
        }

        private void FinalOkButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DealManager dealmanager = new DealManager();
            List<turn> turntab = new List<turn>();
            dealmanager.DealCountAndCountt(count, countt);
        }
    }
}
