using Space_Shooter.Core.Enemy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Space_Shooter.Core
{
    public class Game_Collision
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

            // No moving = No collision
            if (dynamicObj.Vx == 0 && dynamicObj.Vy == 0)
            {
                return false;
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

            // Check if the dynamicObj is able to collide with the staticObj 
            // Draw the altitude from center of staticObj to the movement vector of dynamicObj
            // If the altitude length <= the length of connect line of two center, the collision can happen.

            // Get the altitude length (opposite side of the right triangle)
            double hypotenuse = Math.Sqrt(centerLineX * centerLineX + centerLineY * centerLineY);
            double altitude = Math.Sin(angle) * hypotenuse;

            // The distance between the farthest colliding point and the staticObj center
            // must equal to the sum of two radius
            double maxCollidingRange = dynamicObj.Cir_Hitbox.R + staticObj.Cir_Hitbox.R;

            // compare the altitude length to the max colliding range
            if (altitude > maxCollidingRange)
            {
                // Can't collide
                return false;
            }

            // Find the point that two object start colliding

            // a = The distance between the first colliding point and the center of staticObj
            // a must equal to the max colliding range

            // b = The distance between the two centers of two objects
            // b is the hypotenuse of the right triangle

            // c = The distance between the colliding point and the center of dynamicObj

            // Use Cosine Theorem to find the distance between the center of dynamicObj and the colliding point
            // a^2 = b^2 + c^2 - 2bc * cosA
            // => c = - (b cosA) + Sqrt(delta')

            double delta = (hypotenuse * Math.Cos(angle)) * (hypotenuse * Math.Cos(angle))
                            - (hypotenuse * hypotenuse - maxCollidingRange * maxCollidingRange);
            double c = -(hypotenuse * Math.Cos(angle)) + delta;

            //if (dynamicObj is Enemy_Klaed_Battlecruiser && staticObj is Game_Player)
            //{
            //    int test = 1;
            //}

            // If the dynamicObj move speed is equal or higher than c, that mean it can collide the object
            // (Due to passing the first colliding point)
            if (dynamicObj.MoveSpeed >= c)
            {
                return true;
            }

            return false;
        }
    }
}
