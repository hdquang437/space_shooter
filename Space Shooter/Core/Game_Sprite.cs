using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Sprite
    {
        Bitmap _sprite = null;
        int _max_frameX = 1;
        int _max_frameY = 1;
        int _totalFrame = -1;
        int _width = 0;
        int _height = 0;
        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public int TotalFrame
        {
            get { return _totalFrame <= 0 ? _max_frameX * _max_frameY : _totalFrame; }
        }

        public Game_Sprite(Bitmap image, int frameX, int frameY, int width, int height, int maxIndex = -1)
        {
            _width = width;
            _height = height;
            _max_frameX = frameX;
            _max_frameY = frameY;
            _sprite = new Bitmap(image, width * _max_frameX, height * _max_frameY);
        }

        public void Render(Graphics g, float x, float y, int index)
        {
            index %= TotalFrame;
            int curFrameColumn = index % _max_frameX;
            int curFrameRow = index / _max_frameX;
            int height = _sprite.Height / _max_frameY;
            int width = _sprite.Width / _max_frameX;
            if (x + width < 0 || x > g.ClipBounds.Width || y + height < 0 || y > g.ClipBounds.Height)
            {
                return;
            }
            g.DrawImage(_sprite, (int)x, (int)y, new Rectangle(curFrameColumn * width, curFrameRow * height, width, height), GraphicsUnit.Pixel);
        }
    }
}
