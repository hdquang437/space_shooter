using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Weapon
{
    public class Weapon_Piercing : Game_Weapon
    {
        public override Type realType { get; } = typeof(Weapon_Piercing);
        //public override WeaponType weaponType { get; set; } = WeaponType.WeaponPiercing;
        public Weapon_Piercing(int ownerID, float OffsetX = 0, float OffsetY = 0)
        : base(ownerID, OffsetX, OffsetY)
        {
            attack_cd = 50;
            maxAmmo = 20;
            ammo = maxAmmo;
            ammo_CD = 0;
            primaryColor = ColorTranslator.FromHtml("#a92eea");
            secondaryColor = ColorTranslator.FromHtml("#cf8bf4");
            refillable = false;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_PiercingBullet(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X, center.Y + offsetY);
            AudioManager.PlaySE(SE.ShootPiercing);
        }
    }
}
