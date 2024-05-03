using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_CollidableObject : Game_Object
    {
        protected bool _collidable = true;
        protected bool _needScan = true;
        protected int _collideDamage = 0;
        protected int _hp = 0;
        protected bool _immortal = false;

        // 0 - Player Team
        // 1 - Enemy Team
        protected int _team = 0;

        public bool Collidable { get { return _collidable && !_die; } }
        public bool NeedScan { get { return _needScan; } }
        public bool Immortal {  get { return _immortal; } }
        public int HP {
            get
            {
                return _hp >= 0 ? _hp : 0;
            }
            set
            {
                _hp = Math.Max(0, value);
            }
        }
        public int CollideDamage { get { return _collideDamage; } }
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
            RectangleF collided_wall = Get_Collided_Wall(Hitbox);
            if (!collided_wall.IsEmpty)
            {
                RectangleF test = Hitbox;
                test.Intersect(collided_wall);
                if (test == Hitbox)
                {
                    _die = true;
                    _die_ani = false;
                }
            }
        }
    }
}
