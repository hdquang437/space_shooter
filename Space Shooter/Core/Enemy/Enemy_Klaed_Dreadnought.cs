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
    public class Enemy_Klaed_Dreadnought : Game_Enemy
    {
        public override Type realType { get; } = typeof(Enemy_Klaed_Dreadnought);

        [JsonProperty] private int actionTimer = 400;
        [JsonProperty] private int actionCD = 0;
        [JsonProperty] private int spawnMinionTimes = 10;
        [JsonProperty] private bool init = false;
        [JsonProperty] private Game_EnemyWeapon weapon1 = null;
        [JsonProperty] private Game_EnemyWeapon weapon2 = null;
        public Enemy_Klaed_Dreadnought(Game_Sprite sprite, float x, float y, float speed)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_dreadnought"];
                _sprite = sprite;
            }
            spriteID = "klaed_dreadnought";
            _z = 8;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.3f;
            _hp = 1500;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 2000;
        }

        [JsonConstructor]
        public Enemy_Klaed_Dreadnought(Game_Sprite sprite, float x, float y, float speed,
            int actionTimer, int actionCD, int spawnMinionTimes, bool init, int hp)
        : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_dreadnought"];
                _sprite = sprite;
            }
            spriteID = "klaed_dreadnought";
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
            weapon1 = Factory.Create_EnemyWeapon_HomingRifle(this, 0, -30);
            weapon2 = Factory.Create_EnemyWeapon_Rifle(this, 0, -40);
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
                    //Spawn_Minion(0);
                    Spawn_Minion(1);
                    Spawn_Minion(0);
                    Spawn_Minion(-1);
                    spawnMinionTimes--;
                }
                actionCD = actionTimer;
            }
            weapon1.Shoot();
            weapon2.Shoot();
            base.Process_Action();
        }

        public override void Update()
        {
            Fix_Weapon();
            weapon1.Update();
            weapon2.Update();
            Process_Action();
            base.Update();
            Update_Data();
        }

        public override void Fix_Weapon()
        {
            base.Fix_Weapon();
            if (weapon1 != null && weapon1.GetType() != weapon1.realType)
            {
                weapon1 = (Game_EnemyWeapon)weapon1.DeserializingPackup();
            }
            if (weapon2 != null && weapon1.GetType() != weapon2.realType)
            {
                weapon2 = (Game_EnemyWeapon)weapon1.DeserializingPackup();
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

        private void Spawn_Minion(int side)
        {
            int offsetX = 0;
            switch (side)
            {
                case -1:
                    offsetX = -50;
                    break;
                case 1:
                    offsetX = 50;
                    break;
            }

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int spawnType = random.Next(0, 3);
            Game_Enemy minion = null;
            float speed = 1.5f;
            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    break;
                case GameDifficulty.Normal:
                    speed = 2f;
                    break;
                case GameDifficulty.Hard:
                    speed = 2.5f;
                    break;
            }

            random = new Random(Guid.NewGuid().GetHashCode());
            float speedModifier = 1 + random.Next(-25, 50) / 100f;
            switch (spawnType)
            {
                case 0:
                    minion = Factory.Create_Klaed_Fighter(Center.X, Center.Y, speed * speedModifier, Mode.following);
                    break;
                case 1:
                    minion = Factory.Create_Klaed_Bomber(Center.X, Center.Y, speed * speedModifier);
                    break;
                case 2:
                    minion = Factory.Create_Klaed_Scout(Center.X, Center.Y, speed * speedModifier, Mode.following);
                    break;
            }
            minion?.ToCenterPoint(Center.X + offsetX, Center.Y);
        }

        public override void SelfSerializing()
        {
            weapon1?.SelfSerializing();
            weapon2?.SelfSerializing();
            base.SelfSerializing();
        }
    }
}
