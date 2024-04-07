using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Core
{
    internal class Game_Enemy : Game_CollidableObject
    {
        protected int _reward = 1;
        public int Reward { get { return _reward; } }

        public Game_Enemy(Game_Sprite sprite, int x, int y)
            : base(sprite, x, y)
        {
            _IgnoreWall = true;
            _collidable = true;
            _team = 1;
        }

        public override void Update()
        {
            base.Update();
            Process_Action();
            List<Game_CollidableObject> playerTeam = GameDataManager.PlayerTeam_CollidableObjects;
            Game_Collision.Scan(this, playerTeam);
            Update_Data();
        }

        override public void Process_Action()
        {
            // delete enemy when it moves over the screen.
            Test_move_over_screen();
            base.Process_Action();
        }

        override public void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            base.CollidedWith(src);
        }

        public override void Colliding(Game_CollidableObject target)
        {
            if (_die)
            {
                return;
            }
            base.Colliding(target);
            if (!_immortal && target is Game_Bullet bullet && bullet.IsPlayerBullet())
            {
                _hp -= target.CollideDamage;
            }
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            //if (_die_ani)
            //{
            //    if (Game_Database.player != null)
            //    {
            //        Game_Database.score += _reward;
            //    }
            //    int offset = Width * 3 / 4;
            //    Game_Animation dieAni = new Game_Animation(SpaceshipGame.Properties.Resources.ani_Break, x - offset, y - offset, Width + offset * 2);
            //    Spaceship.PlaySE("Break.wav");
            //    // Spawn small meteors
            //    if (_minion > 0)
            //    {
            //        Random rand;
            //        for (int i = 0; i < _minion + 2; i++)
            //        {
            //            rand = new Random(Guid.NewGuid().GetHashCode());
            //            int moveX = rand.Next(-100, 101);
            //            rand = new Random(Guid.NewGuid().GetHashCode());
            //            int moveY = rand.Next(10, 101);
            //            Game_Enemy new_enemy = new Game_Enemy(x, y, _Width * 3 / 4, _minion, moveX, moveY);
            //            minions.Add(new_enemy);
            //        }
            //    }
            //}
            //else
            //{
            //    if (Game_Database.player != null)
            //    {
            //        Game_Database.score += Math.Max(_reward / 2, 1);
            //    }
            //}
        }
    }
}
