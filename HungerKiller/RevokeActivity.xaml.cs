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
using Windows.UI.Popups;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class RevokeActivity : Page
    {
        public RevokeActivity()
        {
            this.InitializeComponent();
            Genggai = HuodongchexiaoManager.RevokeActivity();
        }
        private List<Huodongchexiao> Genggai;

        private void RevokeListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void RevokeCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private async  void BottomButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("你确定要撤销所选项，撤销后将难以恢复 ！", "撤销提示");

            dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

            //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            //获取返回值
            var result = await dialog.ShowAsync();
        }

        private async  void SingleTrashButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("你确定要撤销此活动吗，撤销后将难以恢复 ！", "撤销提示");

            dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

            //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

            //获取返回值
            var result = await dialog.ShowAsync();
        }
    }
}
