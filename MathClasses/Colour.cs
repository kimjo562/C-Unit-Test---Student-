using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour(int alpha, int red, int green, int blue) : base ()
        {
            colour = 0;
        }

        public Colour() : this(0, 0, 0, 0)
        {

        }

        public byte GetAlpha()
        {
            return 0;
        }

        public byte GetRed()
        {
            return 0;
        }

        public byte GetGreen()
        {
            return 0;
        }

        public byte GetBlue()
        {
            return 0;
        }

        public void SetRed(int red)
        {

        }

        public void SetGreen(int green)
        {

        }

        public void SetBlue(int blue)
        {

        }

        public void SetAlpha(int alphaSet)
        {

        }
    }
}
