using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    internal class Enemy_Klaed_SupportShip : Game_Enemy
    {
        private float velocityX = 0;
        private float velocityY = 1;

        public Enemy_Klaed_SupportShip(Game_Sprite sprite, float x, float y, float vx = 0, float vy = 1, float speed = 4)
            : base(sprite, x, y)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = sprite.Width * 0.35f;
            _hp = 20;
            velocityX = vx;
            velocityY = vy;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 50;
        }

        public override void Process_Action()
        {
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
                
                // drop loot
                Game_Enemy loot = Factory.Create_Random_Loot(center.X, center.Y);
                loot.ToCenterPoint(center.X, center.Y);
            }
        }
    }
}
