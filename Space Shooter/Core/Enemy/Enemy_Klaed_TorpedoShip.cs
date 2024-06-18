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
    public class Enemy_Klaed_TorpedoShip : Game_Enemy
    {
        public override Type realType { get; } = typeof(Enemy_Klaed_TorpedoShip);

        [JsonProperty] private int actionTimer = 10;
        [JsonProperty] private int actionCD = 0;
        [JsonProperty] private int changeDirectionTimes = 20;
        [JsonProperty] private float velocityX = 0;
        [JsonProperty] private float velocityY = 1;
        [JsonProperty] private Game_EnemyWeapon weaponL;
        [JsonProperty] private Game_EnemyWeapon weaponR;
        public Enemy_Klaed_TorpedoShip(Game_Sprite sprite, float x, float y, float speed, Mode mode)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_torpedoship"];
                _sprite = sprite;
            }
            spriteID = "klaed_torpedoship";
            _hp = 30;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.2f;
            this.mode = mode;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 100;
        }

        [JsonConstructor]
        public Enemy_Klaed_TorpedoShip(Game_Sprite sprite, float x, float y, float speed, Mode mode,
            int actionTimer, int actionCD, int changeDirectionTimes, float velocityX, float velocityY, int hp)
        : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["klaed_torpedoship"];
                _sprite = sprite;
            }
            spriteID = "klaed_torpedoship";
            _hp = hp;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.2f;
            this.mode = mode;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 100;
            this.actionTimer = actionTimer;
            this.actionCD = actionCD;
            this.changeDirectionTimes = changeDirectionTimes;
            this.velocityX = velocityX;
            this.velocityY = velocityY;
        }

        public override void LoadWeapon()
        {
            weaponL = Factory.Create_EnemyWeapon_HomingRifle(this, -25, 0);
            weaponR = Factory.Create_EnemyWeapon_HomingRifle(this, 25, 0);
        }

        public override void Process_Action()
        {
            if (mode == Mode.following)
            {
                if (actionCD > 0)
                {
                    actionCD--;
                }
                else
                {
                    if (GameDataManager.player != null && changeDirectionTimes > 0)
                    {
                        PointF des = Utilities.GetVector(Center, GameDataManager.player.Center);
                        velocityX = des.X;
                        velocityY = des.Y;
                        changeDirectionTimes--;
                    }
                    actionCD = actionTimer;
                }
            }
            Move_Vector(velocityX, velocityY);
            weaponL.Shoot();
            weaponR.Shoot();
            base.Process_Action();
        }

        public override void Update()
        {
            Fix_Weapon();
            weaponL.Update();
            weaponR.Update();
            Process_Action();
            base.Update();
            Update_Data();
        }

        public override void Fix_Weapon()
        {
            base.Fix_Weapon();
            if (weaponL != null && weaponL.GetType() != weaponL.realType)
            {
                weaponL = (Game_EnemyWeapon)weaponL.DeserializingPackup();
            }
            if (weaponR != null && weaponR.GetType() != weaponR.realType)
            {
                weaponR = (Game_EnemyWeapon)weaponR.DeserializingPackup();
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
                Game_Animation ani = Factory.Create_ani_Explosion("enemy1", x, y);
                ani.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE(SE.Explosion1);
            }
        }

        public override void SelfSerializing()
        {
            weaponL?.SelfSerializing();
            weaponR?.SelfSerializing();
            base.SelfSerializing();
        }
    }
}
