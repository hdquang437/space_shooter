using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Manager
{
    internal static class Utilities
    {
        static public PointF GetVector(PointF src, PointF des)
        {
            return new PointF(des.X - src.X, des.Y - src.Y);
        }
    }
}
