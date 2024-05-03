using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Collision
    {
        static public void Scan(Game_CollidableObject src, List<Game_CollidableObject> targets)
        {
            if (src.Collidable && src.NeedScan)
            {
                foreach (Game_CollidableObject target in targets)
                {
                    if (target == null)
                        return;
                    if (target.Collidable && DynamicStatic_Circle_CollisionDetection(src, target))
                    {
                        src.Colliding(target);
                        target.CollidedWith(src);
                    }
                }
            }
        }

        /// <summary>
        ///  Return true if the collision has happened.
        /// </summary>
        /// <param name="dynamicObj"></param>
        /// <param name="staticObj"></param>
        /// <returns></returns>
        static public bool DynamicStatic_Circle_CollisionDetection
            (Game_CollidableObject dynamicObj, Game_CollidableObject staticObj)
        {
            // Check if the two objects collide at the start

            if (dynamicObj.Cir_Hitbox.IntersectsWith(staticObj.Cir_Hitbox))
            {
                return true;
            }

            // Check the angle between the dynamicObj velocity and the connect line of the center of two objects
            // If it bigger than 90 degree, the collision never happen. (dynamicObj move farther, not closer)

            float centerLineX = staticObj.x - dynamicObj.x;
            float centerLineY = staticObj.y - dynamicObj.y;
            double angle = (dynamicObj.Vx * centerLineX + dynamicObj.Vy * centerLineY)
                        / (Math.Sqrt(dynamicObj.Vx * dynamicObj.Vx + dynamicObj.Vy * dynamicObj.Vy)
                            * Math.Sqrt(centerLineX * centerLineX + centerLineY + centerLineY));
            angle = Math.Acos(angle);
            if (angle >= Math.PI / 2)
            {
                return false;
            }

            // Use Heron to get the closest distance when the dynamicObj moving

            PointF des = new PointF(dynamicObj.x + dynamicObj.Vx, dynamicObj.y + dynamicObj.Vy);
            float desToStaticX = staticObj.x - des.X;
            float desToStaticY = staticObj.y - des.Y;
            double a = Math.Sqrt(centerLineX * centerLineX + centerLineY * centerLineY);
            double b = Math.Sqrt(desToStaticX * desToStaticX + desToStaticY * desToStaticY);
            double c = Math.Sqrt(dynamicObj.Vx * dynamicObj.Vx + dynamicObj.Vy * dynamicObj.Vy);
            double p = (a + b + c) / 2;

            double h = 2 * (Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / c;

            if (h <= dynamicObj.Cir_Hitbox.R + staticObj.Cir_Hitbox.R)
            {
                return true;
            }

            return false;
        }
    }
}
