using Newtonsoft.Json;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Weapon;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Space_Shooter.Core
{
    public class Game_Bullet : Game_CollidableObject
    {
        public override Type realType { get; } = typeof(Game_Bullet);

        protected Game_Object owner;
        [JsonProperty] int ownerID;
        [JsonProperty] protected string die_ani_sprite = "default_bullet";
        [JsonProperty] protected string die_ani_audio = SE.Explosion1;

        [JsonIgnore]
        public Game_Object Owner {  get { return owner; } }

        public Game_Bullet(int ownerID, Game_Sprite sprite, float x, float y, float speed = 1)
            : base (sprite, x, y)
        {
            _z = 6;
            this.ownerID = ownerID;
            _MoveSpeed = speed;
            _frame_CD = 5;
            _IgnoreWall = true;
            _collideDamage = 1;
            _collidable = true;
            _hp = 1;
        }

        [JsonConstructor]
        public Game_Bullet(Type realType, int ownerID, Game_Sprite sprite, float x, float y, float speed = 1)
        : base(sprite, x, y)
        {
            this.realType = realType;
        }

        public bool IsPlayerBullet()
        {
            return _team == 0;
        }

        public override void Update()
        {
            if (owner == null)
            {
                owner = (Game_CollidableObject)GameDataManager.Instance.FindObjectByID(ownerID);
            }
            Process_Action();
            base.Update();
            Update_Data();
        }

        override public void Process_Action()
        {
            Test_move_over_screen();
            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            if (src is Game_CollidableObject && !(src is Game_Bullet) && !src.IgnoreBullet && _team != src.Team)
            {
                if (!src.Immortal)
                {
                    src.HP -= _collideDamage;
                }
                if (!_immortal)
                {
                    _hp -= src.CollideDamage;
                }
            }
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                Game_Animation animation = Factory.Create_ani_Explosion(die_ani_sprite, x, y);
                animation.ToCenterPoint(Center.X, Center.Y);
                AudioManager.PlaySE(die_ani_audio);
            }
        }

        public override void SelfSerializing()
        {
            base.SelfSerializing();
        }

        public Game_Bullet DeserializingPackup()
        {
            if (realType == typeof(Bullet_DefaultBullet))
            {
                return JsonConvert.DeserializeObject<Bullet_DefaultBullet>(json);
            }
            else if (realType == typeof(Bullet_Bio))
            {
                return JsonConvert.DeserializeObject<Bullet_Bio>(json);
            }
            else if (realType == typeof(Bullet_Flame))
            {
                return JsonConvert.DeserializeObject<Bullet_Flame>(json);
            }
            else if (realType == typeof(Bullet_Gatling))
            {
                return JsonConvert.DeserializeObject<Bullet_Gatling>(json);
            }
            else if (realType == typeof(Bullet_Piercing))
            {
                return JsonConvert.DeserializeObject<Bullet_Piercing>(json);
            }
            else if (realType == typeof(Bullet_Rocket))
            {
                return JsonConvert.DeserializeObject<Bullet_Rocket>(json);
            }
            else if (realType == typeof(Bullet_Shotgun))
            {
                return JsonConvert.DeserializeObject<Bullet_Shotgun>(json);
            }
            else if (realType == typeof(EnemyBullet_Homing))
            {
                return JsonConvert.DeserializeObject<EnemyBullet_Homing>(json);
            }
            else if (realType == typeof(EnemyBullet_Sniping))
            {
                return JsonConvert.DeserializeObject<EnemyBullet_Sniping>(json);
            }
            else if (realType == typeof(EnemyBullet_Spread))
            {
                return JsonConvert.DeserializeObject<EnemyBullet_Spread>(json);
            }
            else if (realType == typeof(EnemyBullet_Straight))
            {
                return JsonConvert.DeserializeObject<EnemyBullet_Straight>(json);
            }
            return this;
        }
    }
}
