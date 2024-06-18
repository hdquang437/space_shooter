using Newtonsoft.Json;
using Space_Shooter.Core.Weapon;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    public class Game_EnemyWeapon : Game_Weapon
    {
        public override Type realType { get; } = typeof(Game_EnemyWeapon);

        public Game_EnemyWeapon(int ownerID, float OffsetX = 0, float OffsetY = 0)
            : base(ownerID, OffsetX, OffsetY)
        {
            refillable = true;
        }

        [JsonConstructor]
        public Game_EnemyWeapon(Type realType, int ownerId, float offsetX, float offsetY, int attack_cd, int attack_cd_timer, int maxAmmo,
        int ammo, int ammo_cd, int ammo_cd_timer, bool refillable, Color primaryColor, Color secondaryColor)
        {
            this.realType = realType;
            this.ownerID = ownerId;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
            this.attack_cd = attack_cd;
            this.attack_cd_timer = attack_cd_timer;
            this.maxAmmo = maxAmmo;
            this.ammo = ammo;
            this.ammo_CD = ammo_cd;
            this.ammo_CD_timer = ammo_cd_timer;
            this.refillable = refillable;
            this.primaryColor = primaryColor;
            this.secondaryColor = secondaryColor;
        }

        override public void Update()
        {
            if (owner == null)
            {
                owner = (Game_CollidableObject)GameDataManager.Instance.FindObjectByID(ownerID);
            }
            if (attack_cd_timer > 0)
            {
                attack_cd_timer--;
            }

            if (ammo > 0)
            {
                ammo_CD_timer = ammo_CD;
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
