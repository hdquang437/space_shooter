using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    public class Enemy_Klaed_Bomber : Game_Enemy
    {
        private int actionTimer = 10;
        private int actionCD = 0;
        private int changeDirectionTimes = 20;
        private float velocityX = 0;
        private float velocityY = 1;

        public Enemy_Klaed_Bomber(Game_Sprite sprite, float x, float y, float speed)
            : base(sprite, x, y)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.4f;
            _hp = 10;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 60;
        }

        public override void Process_Action()
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
                    _MoveSpeed += 0.1f;
                    changeDirectionTimes--;
                }
                actionCD = actionTimer;
            }
            Move_Vector(velocityX, velocityY);
            base.Process_Action();
        }

        public override void Update()
        {
            Process_Action();
            base.Update();
            Update_Data();
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
    }
}
