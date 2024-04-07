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
        protected int _x = 0;
        protected int _y = 0;
        protected int _MoveSpeed = 1;
        protected int _Width = 0;
        protected int _Height = 0;
        protected bool _IgnoreWall = false;
        protected bool _die_ani = true;
        protected bool _die = false;
        protected int _r;
        // Sprite
        protected Game_Sprite _sprite;
        protected int _index = 0;
        protected int _frame_CD = 0;
        protected int _frame_CD_timer = 0;
        #endregion

        #region Properties
        public int x
        { get { return _x; } set { _x = value; } }
        public int y
        { get { return _y; } set { _y = value; } }
        public int MoveSpeed
        { get { return _MoveSpeed; } }
        public int Width
        { get { return _Width; } }
        public int Height
        { get { return _Height; } }
        public bool die
        {
            get { return _die; }
            set { _die = value; }
        }
        public Rectangle Hitbox
        {
            get { return new Rectangle(_x, _y, Width, Height); }
        }
        public Circle Cir_Hitbox
        {
            get { return new Circle(_x + Width / 2, _y + Height / 2, _r); }
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
        private void fix_stuck()
        {
            Rectangle test_stuck = Get_Collided_Wall(Hitbox);
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

        static public Rectangle Get_Collided_Wall(Rectangle test)
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
            return new Rectangle();
        }

        // Return Empty Rectangle if can move
        // Return Best move Rectangle
        public Rectangle test_move(int pos_x, int pos_y)
        {
            int base_moveX = pos_x - Hitbox.X;
            int base_moveY = pos_y - Hitbox.Y;
            int moveX = base_moveX;
            int moveY = base_moveY;
            Rectangle checkBox = new Rectangle(pos_x, pos_y, Hitbox.Width, Hitbox.Height);
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
                    double scale = Math.Abs(base_moveX / base_moveY);
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
            Rectangle BestMove = test_move(x, y - MoveSpeed);
            x = BestMove.X;
            y = BestMove.Y;
        }

        public void Move_Down()
        {
            Rectangle BestMove = test_move(x, y + MoveSpeed);
            x = BestMove.X;
            y = BestMove.Y;
        }

        public void Move_Left()
        {
            Rectangle BestMove = test_move(x - MoveSpeed, y);
            x = BestMove.X;
            y = BestMove.Y;
        }

        public void Move_Right()
        {
            Rectangle BestMove = test_move(x + MoveSpeed, y);
            x = BestMove.X;
            y = BestMove.Y;
        }

        public void Move_Vector(int vec_x, int vec_y)
        {
            double rad = Math.Atan(vec_y * 1.0 / vec_x);
            int moveY = (int)(MoveSpeed * Math.Cos(rad));
            int moveX = (int)(MoveSpeed * Math.Sin(rad));
            Rectangle BestMove = test_move(x + moveX, y + moveY);
            x = BestMove.X;
            y = BestMove.Y;
        }

        public void ToCenterPoint(int X, int Y)
        {
            x = X - _Width/2;
            y = Y - _Height/2;
        }
        #endregion

        #region Graphic Method
        virtual public void Draw_Sprite(Graphics g)
        {
            if (!_die)
                _sprite.Render(g, _x, _y, _index);
        }
        #endregion

        #region Update Data Method
        public virtual void Update_Data()
        {
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
