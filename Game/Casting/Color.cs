using System;

namespace Casting
{
    public class Color
    {
        
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        public int GetRed()
        {
            return red;
        }

        public int GetBlue()
        {
            return blue;
        }
    }
}