using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Weapon
{
    public class Weapon_Flamethrower : Game_Weapon
    {
        public override Type realType { get; } = typeof(Weapon_Flamethrower);
        //public override WeaponType weaponType { get; set; } = WeaponType.WeaponFlamethrower;

        public Weapon_Flamethrower(int ownerID, float OffsetX = 0, float OffsetY = 0)
        : base(ownerID, OffsetX, OffsetY)
        {
            attack_cd = 10;
            maxAmmo = 100;
            ammo = maxAmmo;
            ammo_CD = 0;
            primaryColor = ColorTranslator.FromHtml("#e63a00");
            secondaryColor = ColorTranslator.FromHtml("#ff794d");
            refillable = false;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_FlameBullet(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X, center.Y + offsetY);
            AudioManager.PlaySE(SE.ShootFlamethrower);
        }
    }
}
