using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_addData(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "图像文件|*.jpg;*.png;*.jpeg;*.bmp;*.gif|所有文件|*.*"
            };
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop";//文件选择的默认路径
            try
            {
                if ((bool)openFileDialog.ShowDialog())
                {
                    MessageBox.Show("成功上传照片！");
                    Image1.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
                else
                {
                    MessageBox.Show("上传照片失败，请重新上传！", "提示");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("抱歉，出现错误：\n" + ee.ToString(), "提示");
            }
            
        }
        private void Button_Click_selectAlgorithm(object sender, RoutedEventArgs e)
        {
            
            //未设置大小
            //win.Content = new Page1();
            //宿主大小大于Page尺寸
            //win.Content = new Page1(300,300,500,500);
            //宿主大小小于Page尺寸
            AlgorithmSelectWindow algorithmSelectWindow = new AlgorithmSelectWindow();
            algorithmSelectWindow.Show();

        }
    }
}
