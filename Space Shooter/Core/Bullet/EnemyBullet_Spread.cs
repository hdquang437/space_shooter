using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class EnemyBullet_Spread : Game_Bullet
    {
        public override Type realType { get; } = typeof(EnemyBullet_Spread);

        [JsonProperty] float vX;
        [JsonProperty] float vY;
        public EnemyBullet_Spread(int ownerID, Game_Sprite sprite, float x, float y)
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
            _collideDamage = 5;

            die_ani_sprite = "enemy_bullet";

            int minSpeed = 4;
            int maxSpeed = 10;
            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    minSpeed = 4;
                    maxSpeed = 10;
                    break;
                case GameDifficulty.Normal:
                    minSpeed = 5;
                    maxSpeed = 11;
                    break;
                case GameDifficulty.Hard:
                    minSpeed = 6;
                    maxSpeed = 12;
                    break;
            }

            Random random;
            random = new Random(Guid.NewGuid().GetHashCode());
            vX = random.Next(-40, 41) * 1f;
            random = new Random(Guid.NewGuid().GetHashCode());
            vY = random.Next(100, 200) * 1f;
            random = new Random(Guid.NewGuid().GetHashCode());
            _MoveSpeed = random.Next(minSpeed, maxSpeed);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Process_Action()
        {
            Move_Vector(vX, vY);
            base.Process_Action();
        }
    }
}
