using Space_Shooter.Control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Object
    {
            
        #region Attributes
        // Logical
        protected float _x = 0;
        protected float _y = 0;
        protected float _vx = 0;
        protected float _vy = 0;
        protected float _MoveSpeed = 1;
        protected int _Width = 0;
        protected int _Height = 0;
        protected bool _IgnoreWall = false;
        protected bool _die_ani = true;
        protected bool _die = false;
        protected float _r;
        // Sprite
        protected Game_Sprite _sprite;
        protected int _index = 0;
        protected int _frame_CD = 0;
        protected int _frame_CD_timer = 0;
        #endregion

        #region Properties
        public float x
        { get { return _x; } set { _x = value; } }
        public float y
        { get { return _y; } set { _y = value; } }
        public float Vx
        { get { return _vx; } set { _vx = value; } }
        public float Vy
        { get { return _vy; } set { _vy = value; } }
        public float MoveSpeed
        { get { return _MoveSpeed; } }
        public float Width
        { get { return _Width; } }
        public float Height
        { get { return _Height; } }
        public bool die
        {
            get { return _die; }
            set { _die = value; }
        }
        public Rectangle Hitbox
        {
            get { return new Rectangle((int)Math.Round(_x), (int)Math.Round(_y), (int)Width, (int)Height); }
        }

        public PointF Center
        {
            get { return new PointF(_x + Width / 2.0f, _y + Height / 2.0f); }
        }

        public Circle Cir_Hitbox
        {
            get { return new Circle(x + Width / 2.0f, y + Height / 2.0f, _r); }
        }
        #endregion

        #region Static Properties
        public static Rectangle MoveField = new Rectangle(0, 0, Screen_Game.REAL_SCREEN_WIDTH, Screen_Game.REAL_SCREEN_HEIGHT);

        static public Rectangle Wall_U
        {
            get { return new Rectangle(MoveField.X - 1000, MoveField.Y - 1000, MoveField.Width + 2000, 1000); }
        }

        static public Rectangle Wall_D
        {
            get { return new Rectangle(MoveField.X - 1000, MoveField.Y + MoveField.Height, MoveField.Width + 2000, 1000); }
        }

        static public Rectangle Wall_L
        {
            get { return new Rectangle(MoveField.X - 1000, MoveField.Y, 1000, MoveField.Height); }
        }

        static public Rectangle Wall_R
        {
            get { return new Rectangle(MoveField.X + MoveField.Width, MoveField.Y, 1000, MoveField.Height); }
        }
        #endregion

        #region Methods
        protected void fix_stuck()
        {
            RectangleF test_stuck = Get_Collided_Wall(Hitbox);
            if (!test_stuck.IsEmpty)
            {
                if (test_stuck == Wall_D)
                {
                    _y = Wall_D.Y - Hitbox.Height - 1;
                }
                else if (test_stuck == Wall_U)
                {
                    _y = Wall_U.Y + Wall_U.Height + 1;
                }
                else if (test_stuck == Wall_L)
                {
                    _x = Wall_L.X + Wall_L.Width + 1;
                }
                else if (test_stuck == Wall_R)
                {
                    _x = Wall_R.X - Hitbox.Width - 1;
                }
            }
        }

        static public RectangleF Get_Collided_Wall(RectangleF test)
        {
            if (test.IntersectsWith(Wall_U))
            {
                return Wall_U;
            }
            else if (test.IntersectsWith(Wall_D))
            {
                return Wall_D;
            }
            else if (test.IntersectsWith(Wall_L))
            {
                return Wall_L;
            }
            else if (test.IntersectsWith(Wall_R))
            {
                return Wall_R;
            }
            return RectangleF.Empty;
        }

        // Return Empty Rectangle if can move
        // Return Best move Rectangle
        public RectangleF test_move(float pos_x, float pos_y)
        {

            float base_moveX = pos_x - Hitbox.X;
            float base_moveY = pos_y - Hitbox.Y;
            float moveX = base_moveX;
            float moveY = base_moveY;
            RectangleF checkBox = new RectangleF(pos_x, pos_y, Hitbox.Width, Hitbox.Height);
            if (_IgnoreWall)
            {
                return checkBox;
            }
            while (!Get_Collided_Wall(checkBox).IsEmpty)
            {
                // x or y = 0
                if (moveX == 0)
                {
                    moveY -= (moveY >= 0) ? 1 : -1;
                }
                else if (moveY == 0)
                {
                    moveX -= (moveX >= 0) ? 1 : -1;
                }
                else
                {
                    // not zero
                    float scale = Math.Abs(base_moveX / base_moveY);
                    if (scale >= 1)
                    {
                        moveX -= (int)scale * (base_moveX >= 0 ? 1 : -1);
                        moveY -= base_moveY >= 0 ? 1 : -1;
                    }
                    else
                    {
                        scale = 1 / scale;
                        moveY -= (int)scale * (base_moveY >= 0 ? 1 : -1);
                        moveX -= base_moveX >= 0 ? 1 : -1;
                    }
                }
                if (moveX * base_moveX < 0)
                    moveX = 0;
                if (moveY * base_moveY < 0)
                    moveY = 0;

                checkBox.X = Hitbox.X + (int)moveX;
                checkBox.Y = Hitbox.Y + (int)moveY;

            }
            return checkBox;
        }
        #endregion

        #region Move Methods
        public void Move_Up()
        {
            //RectangleF BestMove = test_move(x, y - MoveSpeed);
            //_vx = BestMove.X - _x;
            //_vy = BestMove.Y - _y;
            _vy += -_MoveSpeed;
        }

        public void Move_Down()
        {
            //RectangleF BestMove = test_move(x, y + MoveSpeed);
            //_vx = BestMove.X - _x;
            //_vy = BestMove.Y - _y;
            _vy += _MoveSpeed;
        }

        public void Move_Left()
        {
            //RectangleF BestMove = test_move(x - MoveSpeed, y);
            //_vx = BestMove.X - _x;
            //_vy = BestMove.Y - _y;
            _vx += -_MoveSpeed;
        }

        public void Move_Right()
        {
            //RectangleF BestMove = test_move(x + MoveSpeed, y);
            //_vx = BestMove.X - _x;
            //_vy = BestMove.Y - _y;
            _vx += _MoveSpeed;
        }

        public void Move_Vector(float vec_x, float vec_y)
        {
            float hypotenuse = (float)Math.Sqrt(vec_x * vec_x + vec_y * vec_y);

            float vx = _MoveSpeed * vec_x / hypotenuse;
            float vy = _MoveSpeed * vec_y / hypotenuse;
            //RectangleF BestMove = test_move(x + vx, y + vy);
            _vx += vx;
            _vy += vy;
        }

        public void ToCenterPoint(float X, float Y)
        {
            x = X - _Width/2;
            y = Y - _Height/2;
        }

        public void UpdatePositionByVelocity()
        {
            _x += _vx;
            _y += _vy;
            ResetVelocity();
        }

        public void ResetVelocity()
        {
            _vx = 0;
            _vy = 0;
        }
        #endregion

        #region Graphic Method
        virtual public void Draw_Sprite(Graphics g)
        {
            if (!_die)
                _sprite?.Render(g, (int)_x, (int)_y, _index);
        }
        #endregion

        #region Update Data Method
        public virtual void Update_Data()
        {
            if (_sprite.TotalFrame == 1)
            {
                if (_index != 0) _index = 0;
                return;
            }
            // Update Sprite Index
            if (_frame_CD > 0 && _sprite != null)
            {
                if (_frame_CD_timer > 0)
                {
                    _frame_CD_timer--;
                }
                else
                {
                    _frame_CD_timer = _frame_CD;
                    if (_index < _sprite.TotalFrame)
                    {
                        _index++;
                    }
                    else
                    {
                        _index = 0;
                    }
                }
            }

        }

        public virtual void Process_BeforeDie()
        {

        }
        #endregion
    }
}
