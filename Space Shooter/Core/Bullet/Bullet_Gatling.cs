using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_Gatling : Game_Bullet
    {
        public override Type realType { get; } = typeof(Bullet_Gatling);

        [JsonProperty] float vX;
        [JsonProperty] float vY;

        public Bullet_Gatling(int ownerID, Game_Sprite sprite, float x, float y)
            : base(ownerID, sprite, x, y, 9)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["gatling"];
                _sprite = sprite;
            }
            spriteID = "gatling";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width * 0.3f;
            _team = 0;
            _collideDamage = 4;
            die_ani_sprite = "gatling_bullet";

            Random random;
            random = new Random(Guid.NewGuid().GetHashCode());
            vX = random.Next(-50, 51) * 1f;
            random = new Random(Guid.NewGuid().GetHashCode());
            vY = random.Next(-200, -100) * 1f;
        }

        [JsonConstructor]
        public Bullet_Gatling(int ownerID, Game_Sprite sprite, float x, float y, float vx, float vy)
        : base(ownerID, sprite, x, y, 9)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["gatling"];
                _sprite = sprite;
            }
            spriteID = "gatling";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width * 0.3f;
            _team = 0;
            _collideDamage = 4;
            die_ani_sprite = "gatling_bullet";

            this.vX = vx;
            this.vY = vy;
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
