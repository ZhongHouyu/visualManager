using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tensorflow;

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
        public void ReshapePicture(string picture,int width,int lenth) 
        {
            string str2 = System.IO.Directory.GetCurrentDirectory();
            string p = "D://data//test//data.txt";
            FileStream fs = new FileStream(p, FileMode.Create);
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
            

        }

    }
}
