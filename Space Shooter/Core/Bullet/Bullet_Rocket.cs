using Microsoft.SqlServer.Server;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    internal class Bullet_Rocket : Game_Bullet
    {
        private bool triggered = false;
        private int remainTime = 10;
        private List<Game_CollidableObject> collidedList = new List<Game_CollidableObject>();

        public Bullet_Rocket(Game_Object owner, Game_Sprite sprite, float x, float y)
        : base(owner, sprite, x, y, 5)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 100;
            die_ani_sprite = "rocket_bullet";
        }

        public override void Update()
        {
            base.Update();
            if (triggered)
            {
                if (remainTime > 0)
                {
                    remainTime--;
                } else
                {
                    _die = true;
                }
            }
        }

        public override void Process_Action()
        {
            if (!triggered) {
                Move_Up();
            }
            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            if (_die || src.IgnoreBullet)
            {
                return;
            }
            if (!src.Immortal && (src is Game_Enemy || src is Game_Player) && !(src is Game_Bullet) && _team != src.Team)
            {
                if (!triggered)
                {
                    triggered = true;
                    PointF center = Center;
                    _Width = 240;
                    _Height = 240;
                    ToCenterPoint(center.X, center.Y);
                    Game_Animation ani = Factory.Create_ani_Explosion(die_ani_sprite, center.X, center.Y);
                    _r = ani.Width * 0.4f;
                    _sprite = null;
                    AudioManager.PlaySE(die_ani_audio);
                }

                if (collidedList.Contains(src))
                {
                    return;
                }
                src.HP -= CollideDamage;
                collidedList.Add(src);
            }
        }
    }
}
