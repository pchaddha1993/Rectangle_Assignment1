using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle_Assignment1
{
    public class Rectangle
    {
        private int Rec_Length, Rec_Width;

        public Rectangle()
        {
            Rec_Length = 1;
            Rec_Width = 1;
        }

        public Rectangle(int Rec_Length, int Rec_Width)
        {
            this.Rec_Length = Rec_Length;
            this.Rec_Width = Rec_Width;
        }

        public int GetLength()
        {
            return Rec_Length;
        }
        public int SetLength(int Rec_Length)
        {
            this.Rec_Length = Rec_Length;
            return this.Rec_Length;

        }
        public int GetWidth()
        {
            return Rec_Width;
        }
        public int SetWidth(int Rec_Width)
        {
            this.Rec_Width = Rec_Width;
            return this.Rec_Width;
        }
        public int GetPerimeter()
        {
            return 2 * (Rec_Length + Rec_Width);
        }
        public int GetArea()
        {
            return Rec_Length * Rec_Width;
        }

    }
}
    