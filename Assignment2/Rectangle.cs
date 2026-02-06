using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        // private fields
        private int length;
        private int width;

        private const int MAX_VALUE = 3500;

        // getter and setter methods
        public int GetLength() { 
            return length;
        }

        public int SetLength(int length) {
           if (0>=length||length>MAX_VALUE)
                return -1;
              this.length = length;
                return this.length;
        }
        public int GetWidth(){
            return width;
        }
        public int SetWidth(int width) {
            if (0 >= width || width > MAX_VALUE)
                return -1;
            this.width = width;
            return this.width;
        }

        public int GetPerimeter() {
            return 2 * (length + width);
        }

        public int GetArea() { 
            return length * width;
        }
        // constructors
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

    }
}
