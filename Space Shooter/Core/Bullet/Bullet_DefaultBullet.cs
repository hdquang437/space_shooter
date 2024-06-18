using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_DefaultBullet : Game_Bullet
    {
        public const int EXPLOSION_SIZE = 30;

        public override Type realType { get; } = typeof(Bullet_DefaultBullet);
        public Bullet_DefaultBullet(int ownerID, Game_Sprite sprite, float x, float y, float speed = 7)
             : base(ownerID, sprite, x, y, speed)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["default_bullet"];
                _sprite = sprite;
            }
            spriteID = "default_bullet";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _collideDamage = 12;
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
