using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_Bio : Game_Bullet
    {
        public Bullet_Bio(Game_Object owner, Game_Sprite sprite, float x, float y, float speed = 5)
         : base(owner, sprite, x, y, speed)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _collideDamage = 15;
            die_ani_sprite = "bio_bullet";
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Process_Action()
        {
            Move_Up();
            base.Process_Action();
        }
    }
}
