using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Space_Shooter.Core
{
    internal class Game_Animation : Game_Object
    {
        public const int animationFrame = 4; 

        //int _size = 256;

        //Rectangle Box
        //{
        //    get { return new Rectangle(_x, _y, _size, _size); }
        //}

        public Game_Animation(Game_Sprite sprite, float x, float y)
        {
            _z = 20;
            _die = false;
            _index = 0;
            _frame_CD = animationFrame;
            _frame_CD_timer = 0;
            _x = x;
            _y = y;
            _sprite = sprite;
            _Width = sprite.Width;
            _Height = sprite.Height;
        }

        override public void Update_Data()
        {
            if (_frame_CD > 0 && _sprite != null)
            {
                if (_frame_CD_timer > 0)
                {
                    _frame_CD_timer--;
                }
                else
                {
                    _frame_CD_timer = _frame_CD;
                    if (_index < _sprite.TotalFrame - 1)
                    {
                        _index++;
                    }
                    else
                    {
                        _die = true;
                    }
                }
            }
        }

        public override void Draw_Sprite(Graphics g)
        {
            if (!_die)
                _sprite.Render(g, _x, _y, _index);
        }
    }
}
