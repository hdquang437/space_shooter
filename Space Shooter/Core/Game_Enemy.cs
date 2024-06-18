using Newtonsoft.Json;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Enemy;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Core
{
    public class Game_Enemy : Game_CollidableObject
    {
        public override Type realType { get; } = typeof(Game_Enemy);

        protected int _reward = 1;
        public int Reward { get { return _reward; } }

        [JsonProperty] protected Mode mode = Mode.forward;

        public Game_Enemy(Game_Sprite sprite, float x, float y)
            : base(sprite, x, y)
        {
            _IgnoreWall = true;
            _collidable = true;
            _team = 1;
            _z = 5;
        }

        [JsonConstructor]
        public Game_Enemy(Type realType, Game_Sprite sprite, float x, float y)
            : base(sprite, x, y)
        {
            this.realType = realType;
            _IgnoreWall = true;
            _collidable = true;
            _team = 1;
            _z = 5;
        }

        public virtual void LoadWeapon()
        {

        }

        public virtual void Fix_Weapon()
        {

        }

        public override void Update()
        {
            base.Update();
            Process_Action();
            List<Game_CollidableObject> playerTeam = GameDataManager.PlayerTeam_CollidableObjects;
            Game_Collision.Scan(this, playerTeam);
            Update_Data();
        }

        override public void Process_Action()
        {
            // delete enemy when it moves over the screen.
            Test_move_over_screen();
            base.Process_Action();
        }

        override public void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            base.CollidedWith(src);
        }

        public override void Colliding(Game_CollidableObject target)
        {
            if (_die)
            {
                return;
            }
            base.Colliding(target);
            //if (!_immortal && target is Game_Bullet bullet && bullet.IsPlayerBullet())
            //{
            //    _hp -= target.CollideDamage;
            //}
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                GameDataManager.GainScore(_reward);
            }
            else
            {
                GameDataManager.GainScore((int)Math.Round(_reward * 0.5));
            }

        }

        public override void SelfSerializing()
        {
            base.SelfSerializing();
        }

        public Game_Enemy DeserializingPackup()
        {
            if (realType == typeof(Enemy_Meteor))
            {
                return JsonConvert.DeserializeObject<Enemy_Meteor>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Battlecruiser))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Battlecruiser>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Bomber))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Bomber>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Dreadnought))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Dreadnought>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Fighter))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Fighter>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Frigate))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Frigate>(json);
            }
            else if (realType == typeof(Enemy_Klaed_Scout))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_Scout>(json);
            }
            else if (realType == typeof(Enemy_Klaed_SupportShip))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_SupportShip>(json);
            }
            else if (realType == typeof(Enemy_Klaed_TorpedoShip))
            {
                return JsonConvert.DeserializeObject<Enemy_Klaed_TorpedoShip>(json);
            }
            else if (realType == typeof(Game_Item))
            {
                return JsonConvert.DeserializeObject<Game_Item>(json);
            }
            return this;
        }

        public enum Mode
        {
            following,
            forward,
        }
    }
}
