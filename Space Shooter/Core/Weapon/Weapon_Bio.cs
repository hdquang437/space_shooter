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
    public class Weapon_Bio : Game_Weapon
    {
        //public override WeaponType weaponType { get; set; } = WeaponType.WeaponBio;
        public Weapon_Bio(int ownerID, float OffsetX = 0, float OffsetY = 0)
        : base(ownerID, OffsetX, OffsetY)
        {
            attack_cd = 20;
            maxAmmo = 50;
            ammo = maxAmmo;
            ammo_CD = 0;
            primaryColor = ColorTranslator.FromHtml("#4dffca");
            secondaryColor = ColorTranslator.FromHtml("#00b37d");
            refillable = false;
        }

        //[JsonConstructor]
        //public Weapon_Bio(WeaponType weaponType, int ownerId, float offsetX, float offsetY, int attack_cd, int attack_cd_timer, int maxAmmo,
        //int ammo, int ammo_cd, int ammo_cd_timer, bool refillable, Color primaryColor, Color secondaryColor)
        //: base(weaponType, ownerId, offsetX, offsetY, attack_cd, attack_cd_timer, maxAmmo, ammo, ammo_cd, ammo_cd_timer,
        //  refillable, primaryColor, secondaryColor)
        //        { }

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
