using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Weapon
{
    internal class EnemyWeapon_Sniper : Game_EnemyWeapon
    {
        public EnemyWeapon_Sniper(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0)
        : base(Owner, OffsetX, OffsetY)
        {
            attack_cd = 40;
            maxAmmo = 3;
            ammo = maxAmmo;
            ammo_CD = 150;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_EnemyBullet_Sniping(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X + offsetX, center.Y + offsetY);
            //AudioManager.PlaySE(SE.Laser1);
        }
    }
}
