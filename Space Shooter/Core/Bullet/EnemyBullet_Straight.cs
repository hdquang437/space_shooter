using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    internal class EnemyBullet_Straight : Game_Bullet
    {
        public EnemyBullet_Straight(Game_Object owner, Game_Sprite sprite, float x, float y)
        : base(owner, sprite, x, y, 7)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _collideDamage = 5;
            die_ani_sprite = "enemy_bullet";

            switch (GameDataManager.Difficulty)
            {
                case GameDifficulty.Easy:
                    _MoveSpeed = 5;
                    break;
                case GameDifficulty.Normal:
                    _MoveSpeed = 6;
                    break;
                case GameDifficulty.Hard:
                    _MoveSpeed = 7;
                    break;
            }
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Process_Action()
        {
            Move_Down();
            base.Process_Action();
        }
    }
}
