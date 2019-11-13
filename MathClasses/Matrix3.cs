using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1x1, m1x2, m1x3, m2x1, mx2x2, m2x3, m3x1, m3x2, m3x3;

        public Matrix3()
        {
            m1x1 = 1; m1x2 = 0;  m1x3 = 0;
            m2x1 = 0; mx2x2 = 1; m2x3 = 0;
            m3x1 = 0; m3x2 = 0;  m3x3 = 1;
        }

    }
}