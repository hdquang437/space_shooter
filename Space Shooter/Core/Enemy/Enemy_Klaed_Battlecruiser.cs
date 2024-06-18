using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    public class Enemy_Klaed_Battlecruiser : Game_Enemy
    {
        public override Type realType { get; } = typeof(Enemy_Klaed_Battlecruiser);

        private int actionTimer = 250;
        [JsonProperty] private int actionCD = 0;
        [JsonProperty] private int spawnMinionTimes = 15;
        [JsonProperty] private bool init = false;
        [JsonProperty] private Game_EnemyWeapon weaponL1 = null;
        [JsonProperty] private Game_EnemyWeapon weaponL2 = null;
        [JsonProperty] private Game_EnemyWeapon weaponR1 = null;
        [JsonProperty] private Game_EnemyWeapon weaponR2 = null;
        [JsonProperty] private Game_EnemyWeapon weaponC = null;
        [JsonProperty] int spawnType = 0;

        public Enemy_Klaed_Battlecruiser(Game_Sprite sprite, float x, float y, float speed)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_battlecruiser"];
                _sprite = sprite;
            }
            spriteID = "klaed_battlecruiser";
            _z = 8;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.3f;
            _hp = 1000;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 2000;
        }

        [JsonConstructor]
        public Enemy_Klaed_Battlecruiser(Game_Sprite sprite, float x, float y, float speed,
            int actionTimer, int actionCD, int spawnMinionTimes, bool init, int hp)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_battlecruiser"];
                _sprite = sprite;
            }
            spriteID = "klaed_battlecruiser";
            _z = 8;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.3f;
            _hp = hp;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 2000;
            this.actionTimer = actionTimer;
            this.actionCD = actionCD;
            this.spawnMinionTimes = spawnMinionTimes;
            this.init = init;
        }

        public override void LoadWeapon()
        {
            weaponC = Factory.Create_EnemyWeapon_Sniper(this, 0, -20);
            weaponL1 = Factory.Create_EnemyWeapon_Rifle(this, -60, -20);
            weaponR1 = Factory.Create_EnemyWeapon_Rifle(this, 60, -20);
            weaponL2 = Factory.Create_EnemyWeapon_SniperRifle(this, -40, 40);
            weaponR2 = Factory.Create_EnemyWeapon_SniperRifle(this, 40, 40);
        }

        public override void Process_Action()
        {
            if (!init && _y < 100)
            {
                Move_Down();
                base.Process_Action();
                return;
            }
            else if (!init)
            {
                init = true;
            }
            else if (init && spawnMinionTimes <= 0)
            {
                Move_Up();
                base.Process_Action();
                return;
            }
            
            if (actionCD > 0)
            {
                actionCD--;
            }
            else
            {
                if (spawnMinionTimes > 0)
                {
                    Spawn_Minion();
                    spawnMinionTimes--;
                }
                actionCD = actionTimer;
            }
            
            weaponC.Shoot();
            weaponL1.Shoot();
            weaponR1.Shoot();
            weaponL2.Shoot();
            weaponR2.Shoot();
            base.Process_Action();
        }

        public override void Update()
        {
            Fix_Weapon();
            weaponC.Update();
            weaponL1.Update();
            weaponL2.Update();
            weaponR1.Update();
            weaponR2.Update();
            Process_Action();
            base.Update();
            Update_Data();
        }
        public override void Fix_Weapon()
        {
            base.Fix_Weapon();
            if (weaponC != null && weaponC.GetType() != weaponC.realType)
            {
                weaponC = (Game_EnemyWeapon)weaponC.DeserializingPackup();
            }
            if (weaponL1 != null && weaponL1.GetType() != weaponL1.realType)
            {
                weaponL1 = (Game_EnemyWeapon)weaponL1.DeserializingPackup();
            }
            if (weaponL2 != null && weaponL2.GetType() != weaponL2.realType)
            {
                weaponL2 = (Game_EnemyWeapon)weaponL2.DeserializingPackup();
            }
            if (weaponR1 != null && weaponR1.GetType() != weaponR1.realType)
            {
                weaponR1 = (Game_EnemyWeapon)weaponR1.DeserializingPackup();
            }
            if (weaponR2 != null && weaponR2.GetType() != weaponR2.realType)
            {
                weaponR2 = (Game_EnemyWeapon)weaponR2.DeserializingPackup();
            }
        }

        public override void Update_Data()
        {
            base.Update_Data();
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                PointF center = Center;
                Game_Animation ani = Factory.Create_ani_Explosion("enemy2", x, y);
                ani.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE(SE.Explosion2);
            }
        }

        public override void Colliding(Game_CollidableObject target)
        {
            base.Colliding(target);
        }

        private void Spawn_Minion()
        {
            Game_Enemy minion = null;
            float speed = 2f;
            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    break;
                case GameDifficulty.Normal:
                    speed = 2.5f;
                    break;
                case GameDifficulty.Hard:
                    speed = 3f;
                    break;
            }

            switch (spawnType)
            {
                case 0:
                    minion = Factory.Create_Klaed_Fighter(Center.X, Center.Y, speed, Mode.following);
                    spawnType = 1;
                    break;
                case 1:
                    minion = Factory.Create_Klaed_Bomber(Center.X, Center.Y, speed);
                    spawnType = 2;
                    break;
                case 2:
                    minion = Factory.Create_Klaed_Scout(Center.X, Center.Y, speed, Mode.following);
                    spawnType = 0;
                    break;
            }
            minion?.ToCenterPoint(Center.X, Center.Y);
        }

        public override void SelfSerializing()
        {
            if (weaponC != null)
            {
                weaponC.SelfSerializing();
            }
            if (weaponL1 != null)
            {
                weaponL1.SelfSerializing();
            }
            if (weaponL2 != null)
            {
                weaponL2.SelfSerializing();
            }
            if (weaponR1 != null)
            {
                weaponR1.SelfSerializing();
            }
            if (weaponR2 != null)
            {
                weaponR2.SelfSerializing();
            }
            base.SelfSerializing();
        }
    }
}
