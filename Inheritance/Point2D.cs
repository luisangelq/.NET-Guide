using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Point2D
    {
        private int X;
        private int Y;

        public void SetX(int value)
        {
            if (value <= 100)
            {
                X = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public void SetY(int value)
        {
            if (value >= 50 && value <= 100)
            {
                Y = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
