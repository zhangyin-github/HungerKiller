using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class homepage : Page
    {
        public homepage()
        {
            this.InitializeComponent();
            this.LeftFlipView.ItemsSource = this.CenterFlipView.ItemsSource = this.RightFlipView.ItemsSource = new ObservableCollection<BitmapImage>()
            {
                new BitmapImage(new System.Uri("ms-appx:///Assets/1.jpg",System.UriKind.RelativeOrAbsolute)),
                new BitmapImage(new System.Uri("ms-appx:///Assets/2.jpg",System.UriKind.RelativeOrAbsolute)),
                new BitmapImage(new System.Uri("ms-appx:///Assets/3.jpg",System.UriKind.RelativeOrAbsolute))
            };
            this.CenterFlipView.SelectedIndex = 0;
            this.LeftFlipView.SelectedIndex = this.LeftFlipView.Items.Count - 1;
            this.RightFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex + 1;

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DispatcherTimer timer1 = new DispatcherTimer();
            DispatcherTimer timer2 = new DispatcherTimer();
            DispatcherTimer timer3 = new DispatcherTimer();
            timer1.Interval = timer2.Interval = timer3.Interval = new System.TimeSpan(0, 0, 3);
            timer1.Tick += (sender, args) =>
            {
                this.CenterFlipView.SelectedIndex = this.CenterFlipView.SelectedIndex < this.CenterFlipView.Items.Count - 1 ? ++this.CenterFlipView.SelectedIndex : 0;
            };
            timer2.Tick += (sender, args) =>
            {
                this.LeftFlipView.SelectedIndex = this.LeftFlipView.SelectedIndex < this.LeftFlipView.Items.Count - 1 ? ++this.LeftFlipView.SelectedIndex : 0;
            };
            timer3.Tick += (sender, args) =>
            {
                this.RightFlipView.SelectedIndex = this.RightFlipView.SelectedIndex < this.RightFlipView.Items.Count - 1 ? ++this.RightFlipView.SelectedIndex : 0;
            };
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

    }
}
