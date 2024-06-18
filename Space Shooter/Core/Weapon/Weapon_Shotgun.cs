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
    public class Weapon_Shotgun : Game_Weapon
    {
        public override Type realType { get; } = typeof(Weapon_Shotgun);
        public Weapon_Shotgun(int ownerID, float OffsetX = 0, float OffsetY = 0)
        : base(ownerID, OffsetX, OffsetY)
        {
            attack_cd = 50;
            maxAmmo = 30;
            ammo = maxAmmo;
            ammo_CD = 0;
            primaryColor = ColorTranslator.FromHtml("#eab92e");
            secondaryColor = ColorTranslator.FromHtml("#efc85d");
            refillable = false;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            for (int i = 0; i < 12; i++)
            {
                Game_CollidableObject obj = Factory.Create_ShotgunBullet(owner, owner.x, owner.y + offsetY);
                obj.ToCenterPoint(center.X, center.Y + offsetY);
            }
            AudioManager.PlaySE(SE.ShootShotgun);
        }

    }
}
