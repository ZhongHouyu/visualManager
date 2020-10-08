using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ReshapePicture(string picture) 
        {

        
        }

    }
}
