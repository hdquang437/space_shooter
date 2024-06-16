using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    public class Circle
    {
        public float X;
        public float Y;
        public float R;

        public Circle(float x, float y, float r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public bool IntersectsWith(Circle target)
        {
            float vectorX = X - target.X;
            float vectorY = Y - target.Y;
            double d = Math.Sqrt(vectorX * vectorX + vectorY * vectorY);
            return (d < R + target.R);
        }
    }
}
