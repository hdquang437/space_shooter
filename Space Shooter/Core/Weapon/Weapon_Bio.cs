using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Weapon
{
    internal class Weapon_Bio : Game_Weapon
    {
        public Weapon_Bio(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0)
        : base(Owner, OffsetX, OffsetY)
        {
            attack_cd = 20;
            maxAmmo = 50;
            ammo = maxAmmo;
            ammo_CD = 0;
            primaryColor = ColorTranslator.FromHtml("#eab92e");
            secondaryColor = ColorTranslator.FromHtml("#efc85d");
            refillable = false;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            for (int i = 0; i < 5; i++)
            {
                Game_CollidableObject obj = Factory.Create_BioBullet(owner, owner.x, owner.y + offsetY, 7 - Math.Abs(i - 2));
                obj.ToCenterPoint(center.X + offsetX * (i - 2), center.Y + offsetY);
            }
            AudioManager.PlaySE(SE.ShootBio);
        }

    }
}
