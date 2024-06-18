using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_Rocket : Game_Bullet
    {
        public override Type realType { get; } = typeof(Bullet_Rocket);

        [JsonProperty] private bool triggered = false;
        [JsonProperty] private int remainTime = 10;
        [JsonProperty] private List<Game_CollidableObject> collidedList = new List<Game_CollidableObject>();

        public Bullet_Rocket(int ownerID, Game_Sprite sprite, float x, float y)
        : base(ownerID, sprite, x, y, 5)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["rocket"];
                _sprite = sprite;
            }
            spriteID = "rocket";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 100;
            die_ani_sprite = "rocket_bullet";
        }

        [JsonConstructor]
        public Bullet_Rocket(int ownerID, Game_Sprite sprite, float x, float y, bool triggered, int remainTimes,
            List<Game_CollidableObject> collidedList)
        : base(ownerID, sprite, x, y, 5)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["rocket"];
                _sprite = sprite;
            }
            spriteID = "rocket";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 100;
            die_ani_sprite = "rocket_bullet";
            this.triggered = triggered;
            this.remainTime = remainTimes;
            this.collidedList = collidedList;
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
                    _sprite = Game_Sprite.Empty;
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
