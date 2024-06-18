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
using Newtonsoft.Json;
using Space_Shooter.Core.Weapon;
using System.CodeDom;

namespace Space_Shooter.Core
{
    public class Game_Weapon
    {
        public virtual Type realType { get; } = typeof(Game_Weapon);

        public string json = "";
        //public virtual WeaponType weaponType { get; set; }

        [JsonProperty] protected int ownerID;
        [JsonProperty] protected int attack_cd = 0;
        [JsonProperty] protected int attack_cd_timer = 0;

        [JsonProperty] protected int maxAmmo = 1;
        [JsonProperty] protected int ammo = 1;
        [JsonProperty] protected int ammo_CD = 10;
        [JsonProperty] protected int ammo_CD_timer = 0;
        [JsonProperty] protected bool refillable = false;

        [JsonProperty] protected float offsetX;
        [JsonProperty] protected float offsetY;

        [JsonProperty] protected Color primaryColor;
        [JsonProperty] protected Color secondaryColor;

        [JsonIgnore]
        public Color PrimaryColor { get { return primaryColor; } }
        [JsonIgnore]
        public Color SecondaryColor { get { return secondaryColor; } }

        [JsonIgnore]
        public int MaxAmmo
        {
            get { return maxAmmo; }
        }
        [JsonIgnore]
        public int Ammo
        {
            get { return ammo; }
        }

        [JsonIgnore] protected Game_CollidableObject owner;

        public Game_Weapon(int ownerID, float OffsetX = 0, float OffsetY = 0) {
            offsetX = OffsetX;
            offsetY = OffsetY;
            ammo_CD_timer = ammo_CD;
            this.ownerID = ownerID;
        }

        public Game_Weapon() { }

        [JsonConstructor]
        public Game_Weapon(Type realType, int ownerId, float offsetX, float offsetY, int attack_cd, int attack_cd_timer, int maxAmmo,
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

        //virtual public void UpdateOwner()
        //{
        //    if (owner == null)
        //    {
        //        owner = (Game_CollidableObject)GameDataManager.Instance.FindObjectByID(ownerID);
        //    }
        //}

        virtual public void Update()
        {
            if (owner == null)
            {
                owner = (Game_CollidableObject)GameDataManager.Instance.FindObjectByID(ownerID);
            }
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

        public void SelfSerializing()
        {
            json = JsonConvert.SerializeObject(this);
        }

        public Game_Weapon DeserializingPackup()
        {
            if (realType == typeof(Weapon_Default))
            {
                return JsonConvert.DeserializeObject<Weapon_Default>(json);
            }
            else if (realType == typeof(Weapon_Bio))
            {
                return JsonConvert.DeserializeObject<Weapon_Bio>(json);
            }
            else if (realType == typeof(Weapon_Flamethrower))
            {
                return JsonConvert.DeserializeObject<Weapon_Flamethrower>(json);
            }
            else if (realType == typeof(Weapon_Gatling))
            {
                return JsonConvert.DeserializeObject<Weapon_Gatling>(json);
            }
            else if (realType == typeof(Weapon_Piercing))
            {
                return JsonConvert.DeserializeObject<Weapon_Piercing>(json);
            }
            else if (realType == typeof(Weapon_Rocket))
            {
                return JsonConvert.DeserializeObject<Weapon_Rocket>(json);
            }
            else if (realType == typeof(Weapon_Shotgun))
            {
                return JsonConvert.DeserializeObject<Weapon_Shotgun>(json);
            }
            else if (realType == typeof(EnemyWeapon_Homing))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_Homing>(json);
            }
            else if (realType == typeof(EnemyWeapon_Homing))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_Homing>(json);
            }
            else if (realType == typeof(EnemyWeapon_HomingRifle))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_HomingRifle>(json);
            }
            else if (realType == typeof(EnemyWeapon_Rifle))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_Rifle>(json);
            }
            else if (realType == typeof(EnemyWeapon_Single))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_Single>(json);
            }
            else if (realType == typeof(EnemyWeapon_Sniper))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_Sniper>(json);
            }
            else if (realType == typeof(EnemyWeapon_SniperRifle))
            {
                return JsonConvert.DeserializeObject<EnemyWeapon_SniperRifle>(json);
            }
            return this;
        }
    }
}
