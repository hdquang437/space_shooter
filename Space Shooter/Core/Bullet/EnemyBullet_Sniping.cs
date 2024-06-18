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
    public class EnemyBullet_Sniping : Game_Bullet
    {
        public override Type realType { get; } = typeof(EnemyBullet_Sniping);

        [JsonProperty] float vX;
        [JsonProperty] float vY;

        public EnemyBullet_Sniping(int ownerID, Game_Sprite sprite, float x, float y)
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

            PointF vector = GameDataManager.player != null ? 
                Utilities.GetVector(Center, GameDataManager.player.Center)
                : new PointF(0, 1);
            vX = vector.X;
            vY = vector.Y;

            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    _MoveSpeed = 5;
                    break;
                case GameDifficulty.Normal:
                    _MoveSpeed = 6;
                    break;
                case GameDifficulty.Hard:
                    _MoveSpeed = 8;
                    break;
            }
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
