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
                editbox.Document.Selection.InsertImage(400, 300, 0, Windows.UI.Text.VerticalCharacterAlignment.Baseline, "图像", stream);
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
    }
}
