namespace Assignment_2
{
    public class Rectangle
    {
        // private fields
        private int length;
        private int width;

        private const int MAX_VALUE = 3500;

        // getter and setter methods
        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            if (length is <= 0 or > MAX_VALUE)
                return -1;
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            if (width is <= 0 or > MAX_VALUE)
                return -1;
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
        // constructors
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = SetLength(length) == -1 ? 1 : length;

            this.width = SetWidth(width) == -1 ? 1 : width;
        }

    }
}
