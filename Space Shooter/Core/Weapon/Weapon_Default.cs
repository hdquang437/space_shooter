using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Space_Shooter.Core.Weapon
{
    public class Weapon_Default : Game_Weapon
    {
        public override Type realType { get; } = typeof(Weapon_Default);
        //public override WeaponType weaponType { get; set; } = WeaponType.WeaponDefault;
        public bool IsWeaponDefault { get; set; } = true;
        public Weapon_Default(int ownerID, float OffsetX = 0, float OffsetY = 0)
            : base(ownerID, OffsetX, OffsetY) {
            attack_cd = 10;
            maxAmmo = 10;
            ammo = 10;
            ammo_CD = 30;
            primaryColor = System.Drawing.Color.Red;
            secondaryColor = System.Drawing.Color.IndianRed;
            refillable = true;
        }

        // Parameterless constructor
        public Weapon_Default() { }

        //[JsonConstructor]
        //public Weapon_Default(WeaponType weaponType, int ownerId, float offsetX, float offsetY, int attack_cd, int attack_cd_timer, int maxAmmo,
        //int ammo, int ammo_cd, int ammo_cd_timer, bool refillable, Color primaryColor, Color secondaryColor)
        //: base(weaponType, ownerId, offsetX, offsetY, attack_cd, attack_cd_timer, maxAmmo, ammo, ammo_cd, ammo_cd_timer,
        //  refillable, primaryColor, secondaryColor)
        //{ }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_DefaultBullet(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X, center.Y + offsetY);
            AudioManager.PlaySE(SE.Laser1);
        }
    }
}
