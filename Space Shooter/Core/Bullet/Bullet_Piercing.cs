using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Bullet
{
    public class Bullet_Piercing : Game_Bullet
    {
        public override Type realType { get; } = typeof(Bullet_Piercing);

        [JsonProperty] private List<Game_CollidableObject> collidedList = new List<Game_CollidableObject>();

        public Bullet_Piercing(int ownerID, Game_Sprite sprite, float x, float y)
        : base(ownerID, sprite, x, y, 15)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["pierce"];
                _sprite = sprite;
            }
            spriteID = "pierce";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 80;
            die_ani_sprite = "piercing_bullet";
        }

        [JsonConstructor]
        public Bullet_Piercing(int ownerID, Game_Sprite sprite, float x, float y,
            List<Game_CollidableObject> collidedList)
        : base(ownerID, sprite, x, y, 15)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites["pierce"];
                _sprite = sprite;
            }
            spriteID = "pierce";
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _team = 0;
            _immortal = true;
            _collideDamage = 80;
            die_ani_sprite = "piercing_bullet";
            this.collidedList = collidedList;
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

        public override void CollidedWith(Game_CollidableObject src)
        {
            if (_die || src.IgnoreBullet)
            {
                return;
            }
            if (!src.Immortal && (src is Game_Enemy || src is Game_Player) && !(src is Game_Bullet) && _team != src.Team)
            {
                if (collidedList.Contains(src)){
                    return;
                }
                src.HP -= CollideDamage;
                collidedList.Add(src);
                Game_Animation animation = Factory.Create_ani_Explosion(die_ani_sprite, x, y);
                animation.ToCenterPoint(Center.X, Center.Y);
                AudioManager.PlaySE(die_ani_audio);
            }
        }
    }
}
