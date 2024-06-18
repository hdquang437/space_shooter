using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_Bio : Game_Bullet
    {
        public override Type realType { get; } = typeof(Bullet_Bio);

        public Bullet_Bio(int ownerID, Game_Sprite sprite, float x, float y, float speed = 5)
         : base(ownerID, sprite, x, y, speed)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["bio"];
                _sprite = sprite;
            }
            spriteID = "bio";
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
