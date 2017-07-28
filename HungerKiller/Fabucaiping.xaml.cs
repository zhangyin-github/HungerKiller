using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HungerKiller
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Fabucaiping : Page
    {
        public Fabucaiping()
        {
            this.InitializeComponent();
        }

        private void BoldButton_Click(object sender, RoutedEventArgs e)
        {
            editbox.Document.Selection.CharacterFormat.Bold = Windows.UI.Text.FormatEffect.Toggle;
        }
        
        private void FontsizeButton_Click(object sender, RoutedEventArgs e)
        {
            editbox.Document.Selection.CharacterFormat.Size = (float)20;
        }

        private async void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".jpeg");

            StorageFile file = await picker.PickSingleFileAsync();
            // 打开文件流
            if (file != null)
            {
                IRandomAccessStream stream = await file.OpenReadAsync();
                // 插入图片
                editbox.Document.Selection.InsertImage(0,0,80, Windows.UI.Text.VerticalCharacterAlignment.Baseline, "图像", stream);
            }
        }

        private void EditListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(FirstItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.Size = (float)12;
            }
            if (SecondItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.Size = (float)16;
            }
            if (ThirdItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.Size = (float)24;
            }
            if (BlackItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.ForegroundColor = Colors.Black;
            }
            if (RedItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.ForegroundColor = Colors.Red;
            }
            if (BlueItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.ForegroundColor = Colors.Blue;
            }
            if (BrownItem.IsSelected)
            {
                editbox.Document.Selection.CharacterFormat.ForegroundColor = Colors.Brown;
            }
        }

        private async  void FabucaipingButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("你确定发布，请检查是否编辑完整", "发布提示");

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
