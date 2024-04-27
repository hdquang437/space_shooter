using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    internal class Bullet_Shotgun : Game_Bullet
    {
        float vX;
        float vY;

        public Bullet_Shotgun(Game_Object owner, Game_Sprite sprite, float x, float y)
            : base(owner, sprite, x, y, 5)
        {
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width * 0.3f;
            _team = 0;
            _collideDamage = 5;
            die_ani_sprite = "shotgun_bullet";

            Random random;
            random = new Random(Guid.NewGuid().GetHashCode());
            vX = random.Next(-40, 41) * 1f;
            random = new Random(Guid.NewGuid().GetHashCode());
            vY = random.Next(-200, -100) * 1f;
            random = new Random(Guid.NewGuid().GetHashCode());
            _MoveSpeed = random.Next(4,10);
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Process_Action()
        {
            Move_Vector(vX, vY);
            base.Process_Action();
        }
    }
}
