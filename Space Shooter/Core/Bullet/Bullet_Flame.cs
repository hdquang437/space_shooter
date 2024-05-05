using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    internal class Bullet_Flame : Game_Bullet
    {
        private int remainTime = 100;
        private int triggerInterval = 4;
        private int triggerCD = 0;

        public Bullet_Flame(Game_Object owner, Game_Sprite sprite, float x, float y)
        : base(owner, sprite, x, y, 4)
        {
            remainTime = sprite.TotalFrame * Game_Animation.animationFrame;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 5;
            _die_ani = false;
            //die_ani_sprite = "flame_bullet";
        }

        public override void Update()
        {
            base.Update();
            if (remainTime > 0)
            {
                remainTime--;
            }
            else
            {
                _die = true;
            }
            if (triggerCD > 0)
            {
                triggerCD--;
            }
        }

        public override void Process_Action()
        {
            Move_Up();
            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            if (_die || triggerCD > 0 || src.IgnoreBullet)
            {
                return;
            }
            if (!src.Immortal && (src is Game_Enemy || src is Game_Player) && !(src is Game_Bullet) && _team != src.Team)
            {
                triggerCD = triggerInterval;
                src.HP -= CollideDamage;
                //AudioManager.PlaySE(die_ani_audio);
            }
        }
    }
}
