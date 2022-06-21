using System;

namespace Casting
{
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        public int GetRed()
        {
            return red;
        }

        public int GetBlue;
    }
}