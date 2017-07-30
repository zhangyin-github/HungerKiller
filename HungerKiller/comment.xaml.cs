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
using System.Net.Http;
using Windows.UI.Popups;

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

        private async void release_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dates = DateTime.Now.ToString("yyyy-MM-dd");
                string times = DateTime.Now.ToString("hh:mm:ss");
                string stfd = "username=" + OneUser.name + "&";
                stfd += "dishname=" + Dish_Name_1.Text + "&";
                stfd += "concent=" + plbox.Text + "&";
                stfd += "date=" + dates + "&";
                stfd += "time=" + times;
                System.Net.Http.HttpClient clientts = new System.Net.Http.HttpClient();
                System.Net.Http.StringContent content = new StringContent(stfd, System.Text.Encoding.UTF8,"application/x-www-form-urlencoded");
                System.Net.Http.HttpResponseMessage response = await clientts.PostAsync("http://localhost:8080/HungerKillerBacked/Addcomment.jsp", content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArrayssssss = resdata.Split('"');
                if (SArrayssssss[3] == "1")
                {
                    var dialog = new MessageDialog("评论成功", "评论提示");
                    dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                    dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                    dialog.DefaultCommandIndex = 0;
                    dialog.CancelCommandIndex = 1;
                    var result = await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("评论失败", "评论提示");
                    dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                    dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                    dialog.DefaultCommandIndex = 0;
                    dialog.CancelCommandIndex = 1;
                    var result = await dialog.ShowAsync();
                }
            }
            catch
            {
                var dialog = new MessageDialog("评论失败", "评论提示");
                dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                dialog.DefaultCommandIndex = 0;
                dialog.CancelCommandIndex = 1;
                var result = await dialog.ShowAsync();
            }
        }

        private void Dish_Pictures_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            GetAllcomment gets = new GetAllcomment();
            gets.getall(Dish_Name_1.Text);
        }
    }

    

}
