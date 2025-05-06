using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH9_2
{
    internal class Box
    {
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

       public double Volume()
        {           
            return length * width * height;
        }

        public double Area()
        {
            return 2 * (length * width + length * height + width * height);
        }
    }
}
