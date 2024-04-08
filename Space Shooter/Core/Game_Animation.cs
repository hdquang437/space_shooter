using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Animation : Game_Object
    {
        int _size = 256;

        //Rectangle Box
        //{
        //    get { return new Rectangle(_x, _y, _size, _size); }
        //}

        public Game_Animation(Game_Sprite sprite, int x, int y)
        {
            _die = false;
            _index = 0;
            _frame_CD = 4;
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
