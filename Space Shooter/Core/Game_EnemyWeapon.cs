using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_EnemyWeapon : Game_Weapon
    {

        public Game_EnemyWeapon(Game_CollidableObject Owner, float OffsetX = 0, float OffsetY = 0)
            : base(Owner, OffsetX, OffsetY)
        {
            refillable = true;
        }

        override public void Update()
        {
            if (attack_cd_timer > 0)
            {
                attack_cd_timer--;
            }

            if (ammo >= MaxAmmo)
            {
                return;
            }

            // reload when out of ammo
            if (ammo_CD_timer > 0)
            {
                ammo_CD_timer--;
            }
            else
            {
                ammo_CD_timer = ammo_CD;
                ammo = maxAmmo;
            }
        }
    }
}
