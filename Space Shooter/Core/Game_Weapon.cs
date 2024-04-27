using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Media.Media3D;
using System.Drawing.Text;

namespace Space_Shooter.Core
{
    internal class Game_Weapon
    {
        protected int attack_cd = 0;
        protected int attack_cd_timer = 0;

        protected int maxAmmo = 1;
        protected int ammo = 1;
        protected int ammo_CD = 10;
        protected int ammo_CD_timer = 0;
        protected bool refillable = false;

        protected float offsetX;
        protected float offsetY;

        protected Color primaryColor;
        protected Color secondaryColor;

        public Color PrimaryColor { get { return primaryColor; } }
        public Color SecondaryColor { get { return secondaryColor; } }

        public int MaxAmmo
        {
            get { return maxAmmo; }
        }
        public int Ammo
        {
            get { return ammo; }
        }

        protected Game_CollidableObject owner;

        public Game_Weapon(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0) {
            owner = Owner;
            offsetX = OffsetX;
            offsetY = OffsetY;
            ammo_CD_timer = ammo_CD;
        }

        virtual public void Shoot()
        {
            if (attack_cd_timer == 0 && ammo > 0)
            {
                CreateBullet();
                ammo--;
                attack_cd_timer = attack_cd;
            }
        }

        virtual protected void CreateBullet()
        {
        }

        public void Update()
        {
            if (attack_cd_timer > 0)
            {
                attack_cd_timer--;
            }

            if (!refillable || ammo >= maxAmmo)
            {
                return;
            }

            if (ammo_CD_timer > 0)
            {
                ammo_CD_timer--;
            }
            else
            {
                ammo_CD_timer = ammo_CD;
                ammo++;
            }
        }
    }
}
