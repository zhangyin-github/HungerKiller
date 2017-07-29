using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
using Windows.UI.Xaml.Media.Imaging;
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
        public string inputstring = null;
       

        private void RouCheckBox_Click(object sender, RoutedEventArgs e)
        {
            
            
                string selectedToppingsText = string.Empty;
                CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
                foreach (CheckBox c in checkboxes)
                {
                    if (c.IsChecked == true)
                    {
                        if (selectedToppingsText.Length > 1)
                        {
                            selectedToppingsText += ", ";
                        }
                        selectedToppingsText += c.Content;
                    }
                }
            ShowTextBlock.Text = selectedToppingsText;
            
        }

        private void TianCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void SuanCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void LiangCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void ReCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void XianCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void LaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void MiShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void MianShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private void SuShiCheckBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedToppingsText = string.Empty;
            CheckBox[] checkboxes = new CheckBox[] { RouCheckBox, TianCheckBox,
                                             SuanCheckBox, LiangCheckBox, ReCheckBox, XianCheckBox, LaCheckBox, MiShiCheckBox, MianShiCheckBox, SuShiCheckBox };
            foreach (CheckBox c in checkboxes)
            {
                if (c.IsChecked == true)
                {
                    if (selectedToppingsText.Length > 1)
                    {
                        selectedToppingsText += ", ";
                    }
                    selectedToppingsText += c.Content;
                }
            }
            ShowTextBlock.Text = selectedToppingsText;
        }

        private async void TianjiaTupianButton_Click(object sender, RoutedEventArgs e)
        {
            var srcImage1 = new BitmapImage();
            FileOpenPicker openPicker = new FileOpenPicker();
            //选择视图模式  
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            //openPicker.ViewMode = PickerViewMode.List;  
            //初始位置  
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            //添加文件类型  
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");


            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read))
                {
                    await srcImage1.SetSourceAsync(stream);
                    FabucaipingImage.Source = srcImage1;
                }
            }
            if (file != null)
            {
                var streamData = await file.OpenReadAsync();
                var bytes = new byte[streamData.Size];
                using (var dataReader = new DataReader(streamData))
                {
                    await dataReader.LoadAsync((uint)streamData.Size);
                    dataReader.ReadBytes(bytes);
                }
                inputstring= System.Convert.ToBase64String(bytes);
            }
        }
        private async void FabuButton_Click(object sender, RoutedEventArgs e)
        {
            string t1 = "0";
            string t2 = "0";
            string t3 = "0";
            string t4 = "0";
            string t5 = "0";
            string t6 = "0";
            string t7 = "0";
            string t8 = "0";
            string t9 = "0";
            string t10 = "0";
            if (RouCheckBox.IsChecked.Value)
            { t1 = "1"; }
            if (TianCheckBox.IsChecked.Value)
            { t2 = "1"; }
            if (SuanCheckBox.IsChecked.Value)
            { t3 = "1"; }
            if (LiangCheckBox.IsChecked.Value)
            {  t4 = "1"; }
            if (ReCheckBox.IsChecked.Value)
            { t5 = "1"; }
            if (XianCheckBox.IsChecked.Value)
            { t6 = "1"; }
            if (LaCheckBox.IsChecked.Value)
            { t7 = "1"; }
            if (MiShiCheckBox.IsChecked.Value)
            { t8 = "1"; }
            if (MianShiCheckBox.IsChecked.Value)
            { t9 = "1"; }
            if (SuShiCheckBox.IsChecked.Value)
            { t10 = "1"; }
             string chooseclass=CaiXiComboBox.SelectedValue.ToString();
             string choosefloor=FloorComboBox.SelectedValue.ToString();
             string choosedishname = CaiMingTextBox.Text;
             string choosedishingre = YuanLiaoTextBox.Text;
             string choosedishcurrent = CaiLiangTextBox.Text;
             string choosedishposition = WeizhiTextBox.Text;
             string str = "dishname=" +choosedishname+ "&";
             str += "dishinger="+choosedishingre+"&";
             str += "dishclass=" + chooseclass + "&";
             str += "dishfloor=" + choosefloor + "&";
             str += "dishposition=" + choosedishposition + "&";
             str += "dishcurrent=" + choosedishcurrent + "&";
             str += "dishmeat=" + t1 + "&";
             str += "dishsweet=" + t2 + "&";
             str += "dishacid=" + t3 + "&";
             str += "dishcold=" + t4 + "&";
             str += "dishheat=" + t5 + "&";
             str += "dishsalty=" + t6 + "&";
             str += "dishot=" + t7 + "&";
             str += "dishrice=" + t8 + "&";
             str += "dishmainshi=" + t9 + "&";
             str += "dishsushi" + t10 + "&";
            if (inputstring == null)
            {
                str += "dishimg=" +"0000";
            }
             str += "dishimg=" + System.Net.WebUtility.UrlEncode(inputstring);
            try
            {
                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                System.Net.Http.StringContent content = new StringContent(str, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
                System.Net.Http.HttpResponseMessage response = await client.PostAsync("http://localhost:8080/HungerKillerBacked/ImageTest.jsp", content);
                var resdata = await response.Content.ReadAsStringAsync();
                String[] SArraysssss = resdata.Split('"');
                if (SArraysssss[3] == "1")
                {
                    var dialog = new MessageDialog("菜品发布成功", "发布提示");
                    dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                    dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                    dialog.DefaultCommandIndex = 0;
                    dialog.CancelCommandIndex = 1;
                    var result = await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("菜品发布失败", "发布提示");
                    dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                    dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                    dialog.DefaultCommandIndex = 0;
                    dialog.CancelCommandIndex = 1;
                    var result = await dialog.ShowAsync();
                }
            }
            catch
            {
                var dialog = new MessageDialog("菜品发布失败", "发布提示");
                dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
                dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));
                dialog.DefaultCommandIndex = 0;
                dialog.CancelCommandIndex = 1;
                var result = await dialog.ShowAsync();
            }
            //var dialog = new MessageDialog("你确定发布，请检查是否编辑完整", "发布提示");
            //dialog.Commands.Add(new UICommand("确定", cmd => { }, commandId: 0));
            //dialog.Commands.Add(new UICommand("取消", cmd => { }, commandId: 1));

            //设置默认按钮，不设置的话默认的确认按钮是第一个按钮
            //dialog.DefaultCommandIndex = 0;
            //dialog.CancelCommandIndex = 1;

            //获取返回值
            //var result = await dialog.ShowAsync();
        }
    }
}
