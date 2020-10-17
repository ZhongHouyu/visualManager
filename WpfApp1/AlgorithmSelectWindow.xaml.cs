using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// AlgorithmSelectWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AlgorithmSelectWindow : System.Windows.Window
    {
        public AlgorithmSelectWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            reshape_grid.Visibility = System.Windows.Visibility.Visible;



        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MINIST_grid.Visibility = System.Windows.Visibility.Visible;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MINIST_Tester mINIST_Tester = new MINIST_Tester();
            //double[] score = mINIST_Tester.MNIST_test();

            //MessageBox.Show($"loss:{score[0]},acc:{score[1]}");
            MessageBox.Show("test start");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal c = decimal.Parse(width.Text);
            int w = (int)c;
            c = decimal.Parse(lenth.Text);
            int l = (int)c;
            string picture = (this.Owner as MainWindow).Image1.Source.ToString();

            //Reshaper reshaper = new Reshaper(w,l);
            //ImageSource dst = reshaper.ReshapePicture(picture, w, l);
            

            (this.Owner as MainWindow).image_show.Visibility = Visibility.Visible;
            (this.Owner as MainWindow).image_show.Source = (this.Owner as MainWindow).Image1.Source;

            this.Close();

        }

    }
}
