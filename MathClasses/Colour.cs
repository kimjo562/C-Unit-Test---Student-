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

        public Colour()
        {
            colour = 0;
        }

        public Colour(byte r, byte g, byte b, byte a)
        {
            colour = (UInt32)r << 24;
            colour += (UInt32)g << 16;
            colour += (UInt32)b << 8;
            colour += a;
        }

        public byte GetAlpha()
        {
            UInt32 color = colour << 24;
            return (byte)(color >> 24);
        }

        public byte GetRed()
        {
            return (byte)(colour >> 24);
        }

        public byte GetGreen()
        {
            UInt32 color = colour << 8;
            return (byte)(colour >> 16);
        }

        public byte GetBlue()
        {
            UInt32 color = colour << 16;
            return (byte)(colour >> 8);
        }

        public void SetRed(byte red)
        {
            colour = colour << 8;
            colour += (UInt32)red << 24;
        }

        public void SetGreen(byte green)
        {
            colour = colour << 8;
            colour += (UInt32)green << 16;
        }

        public void SetBlue(byte blue)
        {
            colour = colour << 16;
            colour += (UInt32)blue << 8;
        }

        public void SetAlpha(byte alphaSet)
        {
            colour = colour >> 8;
            colour = colour << 8;
            colour += (UInt32)alphaSet;
        }
    }
}
