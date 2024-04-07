using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Circle
    {
        public int X;
        public int Y;
        public int R;

        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public bool IntersectsWith(Circle target)
        {
            int vectorX = X - target.X;
            int vectorY = Y - target.Y;
            double d = Math.Sqrt(vectorX * vectorX + vectorY * vectorY);
            return (d < R + target.R);
        }
    }
}
