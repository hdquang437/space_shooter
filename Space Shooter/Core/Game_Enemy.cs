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

        protected Mode mode = Mode.forward;

        public Game_Enemy(Game_Sprite sprite, float x, float y)
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
            //if (!_immortal && target is Game_Bullet bullet && bullet.IsPlayerBullet())
            //{
            //    _hp -= target.CollideDamage;
            //}
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            GameDataManager.GainScore(_reward);
        }

        public enum Mode
        {
            following,
            forward,
        }
    }
}
