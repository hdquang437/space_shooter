using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class EnemyBullet_Homing : Game_Bullet
    {
        public override Type realType { get; } = typeof(EnemyBullet_Homing);

        [JsonProperty] int changeDirectionTimes = 0;
        [JsonProperty] float vX = 0;
        [JsonProperty] float vY = 1;
        int actionTimer = 5;
        [JsonProperty] int actionCD = 0;

        public EnemyBullet_Homing(int ownerID, Game_Sprite sprite, float x, float y)
        : base(ownerID, sprite, x, y, 7)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["enemy_bullet"];
                _sprite = sprite;
            }
            spriteID = "enemy_bullet";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 1;
            _collideDamage = 20;

            die_ani_sprite = "enemy_bullet";

            Random random = new Random(Guid.NewGuid().GetHashCode());
            float speedVariance = 1 + random.Next(-25, 26) / 100f;

            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    _MoveSpeed = 4;
                    changeDirectionTimes = 6;                    
                    break;
                case GameDifficulty.Normal:
                    _MoveSpeed = 5;
                    changeDirectionTimes = 12;
                    actionTimer = 10;
                    break;
                case GameDifficulty.Hard:
                    _MoveSpeed = 6;
                    changeDirectionTimes = 16;
                    actionTimer = 8;
                    break;
            }
            _MoveSpeed *= speedVariance;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Process_Action()
        {
            if (changeDirectionTimes > 0)
                if (actionCD > 0)
                {
                    actionCD--;
                }
                else
                {
                    if (GameDataManager.player != null && changeDirectionTimes > 0)
                    {
                        PointF des = Utilities.GetVector(Center, GameDataManager.player.Center);
                        vX = des.X;
                        vY = des.Y;
                        changeDirectionTimes--;
                    }
                    actionCD = actionTimer;
                }
            Move_Vector(vX, vY);
            base.Process_Action();
        }
    }
}
