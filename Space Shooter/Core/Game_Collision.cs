using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Collision
    {
        static public void Scan(Game_CollidableObject src, List<Game_CollidableObject> targets)
        {
            if (!src.Collidable || !src.NeedScan)
            {
                return;
            }
            foreach (Game_CollidableObject target in targets)
            {
                if (target == null)
                    return;
                if (target.Collidable && src.Cir_Hitbox.IntersectsWith(target.Cir_Hitbox))
                {
                    src.Colliding(target);
                    target.CollidedWith(src);
                }
            }
        }
    }
}
