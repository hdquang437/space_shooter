using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Space_Shooter.Core.Weapon
{
    internal class Weapon_Default : Game_Weapon
    {
        public Weapon_Default(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0)
            : base(Owner, OffsetX, OffsetY) {
            attack_cd = 10;
            maxAmmo = 10;
            ammo = 10;
            ammo_CD = 30;
            primaryColor = System.Drawing.Color.Red;
            secondaryColor = System.Drawing.Color.IndianRed;
            refillable = true;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_DefaultBullet(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X, center.Y + offsetY);
            AudioManager.PlaySE(SE.Laser1);
        }
    }
}
