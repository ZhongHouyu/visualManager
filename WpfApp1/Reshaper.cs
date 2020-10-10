using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tensorflow ;
using OpenCvSharp;
using Numpy;
using System.Windows.Media;
using System.Drawing;

namespace WpfApp1
{
    class Reshaper
    {   
        
        private int new_width, new_lenth;

        public Reshaper(int width,int lenth)
        {
            this.new_lenth = lenth;
            this.new_width = width;
        }
        public int getWidth()
        {
            return this.new_width;
        }
        public int getLenth()
        {
            return this.new_lenth;
        }
        public ImageSource ReshapePicture(string picture,int width,int lenth) 
        {
            string str2 = System.IO.Directory.GetCurrentDirectory();
            string p = str2 + "\\data.txt";
            //记录
            FileInfo fileInfo = new FileInfo(p);
            FileStream fs = new FileStream(fileInfo.Name, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(width);
            sw.Write('\n');
            sw.Write(lenth);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
            //修改图片大小
            var img_origin = Cv2.ImRead(picture, ImreadModes.Color);
            //Mat img_origin = new Mat(picture, ImreadModes.Color);
            Mat dst = new Mat();
            OpenCvSharp.Size size = new OpenCvSharp.Size(lenth, width);
            Cv2.Resize(img_origin, dst, size); 
            Bitmap bitmap = new Bitmap(dst.Cols, dst.Rows, (int)dst.Step(),System.Drawing.Imaging.PixelFormat.Format32bppArgb, dst.Data);
            bitmap.Save(str2 + "data.bmp");
            ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            ImageSource imageSource = (ImageSource)imageSourceConverter.ConvertFrom(bitmap);
            //ImageSource imageSource = (ImageSource)
            return imageSource;




        }

    }
}
