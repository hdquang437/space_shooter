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
    internal class Game_Bullet : Game_CollidableObject
    {
        private Game_Object owner;

        public Game_Object Owner {  get { return owner; } }

        public Game_Bullet(Game_Object owner, Game_Sprite sprite, int x, int y, int speed = 1)
            : base (sprite, x, y)
        {
            this.owner = owner;
            _MoveSpeed = speed;
            _frame_CD = 5;
            _IgnoreWall = true;
            _collideDamage = 1;
            _collidable = true;
            _hp = 1;
        }

        public bool IsPlayerBullet()
        {
            return owner != null && owner is Game_Player;
        }

        public override void Update()
        {
            Process_Action();
            base.Update();
            Update_Data();
        }

        override public void Process_Action()
        {
            Test_move_over_screen();
            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            base.CollidedWith(src);
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                Point center = Center;
                Game_Animation animation = Factory.Create_ani_Explosion("default_bullet", x, y);
                animation.ToCenterPoint(Center.X, Center.Y);
                AudioManager.PlaySE("Explosion1.wav");
            }
        }
    }
}
