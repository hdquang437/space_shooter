using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    internal class Enemy_Klaed_TorpedoShip : Game_Enemy
    {
        private int actionTimer = 60;
        private int actionCD = 0;
        private int changeDirectionTimes = 10;
        private float velocityX = 0;
        private float velocityY = 1;
        private Game_EnemyWeapon weaponL;
        private Game_EnemyWeapon weaponR;
        public Enemy_Klaed_TorpedoShip(Game_Sprite sprite, float x, float y, float speed, Mode mode)
            : base(sprite, x, y)
        {
            _hp = 50;
            _r = 20;
            weaponL = Factory.Create_EnemyWeapon_Rifle(this, -25, 0);
            weaponR = Factory.Create_EnemyWeapon_Rifle(this, 25, 0);
            this.mode = mode;
            _MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _collideDamage = 100;
            _reward = 100;
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
            Process_Action();
            base.Update();
            Update_Data();
        }

        public override void Update_Data()
        {
            base.Update_Data();
            weaponL.Update();
            weaponR.Update();
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
