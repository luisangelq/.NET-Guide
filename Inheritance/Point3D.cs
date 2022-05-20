using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Point3D : Point2D
    {
        private int z { get; set; }

        public int GetZ()
        {
            return z;
        }

        public void SetZ(int value)
        {
            z = value;
        }

    }
}
