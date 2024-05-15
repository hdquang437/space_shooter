using Space_Shooter.Core;
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
    
        static public Game_Enemy.Mode ParseMode(string modeStr)
        {
            switch (modeStr)
            {
                case "following":
                    return Game_Enemy.Mode.following;
                case "forward":
                    return Game_Enemy.Mode.forward;
                default:
                    return Game_Enemy.Mode.forward;
            }
        }
    }
}
