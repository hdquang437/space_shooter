﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Core.Bullet
{
    internal class Bullet_DefaultBullet : Game_Bullet
    {
        public const int WIDTH = 40;
        public const int HEIGHT = 40;
        public const int EXPLOSION_SIZE = 30;

        public Bullet_DefaultBullet(Game_Object owner, Game_Sprite sprite, int x, int y, int speed = 7)
             : base(owner, sprite, x, y, speed)
        {
            _Width = WIDTH;
            _Height = HEIGHT;
            _r = _Width / 2;
            _team = 0;
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
    }
}
