using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    public class Game_CollidableObject : Game_Object
    {
        public override Type realType { get; } = typeof(Game_CollidableObject);

        protected bool _collidable = true;
        protected bool _needScan = true;
        protected int _collideDamage = 0;
        [JsonProperty] protected int _hp = 0;
        [JsonProperty] protected bool _immortal = false;
        protected bool _ignoreBullet = false;

        // 0 - Player Team
        // 1 - Enemy Team
        protected int _team = 0;

        [JsonIgnore]
        public bool Collidable { get { return _collidable && !_die; } }
        [JsonIgnore]
        public bool NeedScan { get { return _needScan; } }
        [JsonIgnore]
        public bool Immortal {  get { return _immortal; } }
        [JsonIgnore]
        public bool IgnoreBullet { get { return _ignoreBullet; } }
        [JsonIgnore]
        virtual public int HP {
            get
            {
                return _hp >= 0 ? _hp : 0;
            }
            set
            {
                _hp = (Math.Max(0, value));
            }
        }
        [JsonIgnore]
        public int CollideDamage { get { return _collideDamage; } }
        [JsonIgnore]
        public int Team { get { return _team; } }

        public Game_CollidableObject(Game_Sprite sprite , float x, float y)
            : base()
        {
            _sprite = sprite;
            _x = x;
            _y = y;
        }

        virtual public void Update()
        {

        }

        virtual public void Colliding(Game_CollidableObject target)
        {

        }

        virtual public void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            // Game bullet colliding event will be handled by Game_Bullet
            if (!_immortal && !(src is Game_Bullet) && _team != src.Team)
            {
                _hp -= src.CollideDamage;
            }
        }

        virtual public void Process_Action()
        {
            UpdatePositionByVelocity();
        }

        public override void Update_Data()
        {
            base.Update_Data();
            if (_hp <= 0)
            {
                _die = true;
                _die_ani = true;
            }
        }

        public void Test_move_over_screen()
        {
            if (IsOutsideScreen())
            {
                _die = true;
                _die_ani = false;
            }
        }

        public override void SelfSerializing()
        {
            base.SelfSerializing();
        }
    }
}
