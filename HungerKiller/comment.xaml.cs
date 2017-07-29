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
using Windows.UI.Xaml.Media.Imaging;
using HungerKiller.CommentCollet;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary> 
    public sealed partial class comment : Page
    {
        public List<Comment> Comment;
        public comment()
        {
            this.InitializeComponent();
            Comment = Comment_Manager.Get_Comment();            
        }
        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
                base.OnNavigatedTo(e); 
                var news = NewsManager.GetNews((int)e.Parameter);
                // modify the info
                Dish_Name_1.Text = news.Headline;
                dish_Picture.ImageSource = new BitmapImage(new Uri(news.Image, UriKind.Absolute));
                Dishes_Classify.Text = news.Text;
                Dishes_Taste.Text = news.Subhead;
                Dishes_Material.Text = news.Dateline;
 
        }

      
        private void collect_comment_Click(object sender, RoutedEventArgs e)
        {
            collect a = new collect();
            a.ShowAsync();
        }
    }

    

}
