﻿using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Weapon
{
    public class EnemyWeapon_Homing : Game_EnemyWeapon
    {
        public EnemyWeapon_Homing(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0)
        : base(Owner, OffsetX, OffsetY)
        {
            attack_cd = 60;
            maxAmmo = 3;
            ammo = maxAmmo;
            ammo_CD = 180;
        }

        protected override void CreateBullet()
        {
            PointF center = owner.Center;
            Game_CollidableObject obj = Factory.Create_EnemyBullet_Homing(owner, owner.x, owner.y + offsetY);
            obj.ToCenterPoint(center.X + offsetX, center.Y + offsetY);
            //AudioManager.PlaySE(SE.Laser1);
        }
    }
}
