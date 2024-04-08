using Space_Shooter.Core.Bullet;
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
    internal class Game_Player : Game_CollidableObject
    {

        int _attack_cd = 0;
        int _attack_cd_timer = 0;

        int _maxAmmo = 1;
        int _Ammo = 1;
        int _Ammo_CD = 10;
        int _Ammo_CD_timer = 0;

        int _maxHP = 10;

        public int maxHP {  get { return _maxHP; } }
        public int HP { get { return _hp >= 0 ? _hp : 0; } }

        public int maxAmmo
        {
            get { return _maxAmmo; }
        }
        public int Ammo
        {
            get { return _Ammo; }
        }

        public Game_Player(Game_Sprite sprite, int posX = 0, int posY = 0)
            : base(sprite, posX, posY)
        {
            // Data
            _Width = sprite.Width;
            _Height = sprite.Height;
            _collidable = true;
            _collideDamage = 1;
            _r = sprite.Width / 2;
            _MoveSpeed = 4;
            _attack_cd = 10;
            _maxAmmo = 10;
            _Ammo = 10;
            _Ammo_CD = 30;
            _frame_CD = 10;
            _hp = _maxHP;
        }

        public override void Update()
        {
            base.Update();
            Process_Action();
            List<Game_CollidableObject> enemyTeam = GameDataManager.EnemyTeam_CollidableObjects;
            Game_Collision.Scan(this, enemyTeam);
            Update_Data();
        }

        public override void Update_Data()
        {
            base.Update_Data();
            Process_CD();
        }

        public void Process_KeyEvent(KeyboardState state)
        {
            if (state.up)
            {
                Move_Up();
            }
            else if (state.down)
            {
                Move_Down();
            }
            if (state.left)
            {
                Move_Left();
            }
            else if (state.right)
            {
                Move_Right();
            }
            if (state.shoot && _attack_cd_timer == 0 && _Ammo > 0)
            {
                Point center = Center;
                Game_CollidableObject obj =  Factory.Create_DefaultBullet(this, x, y + Height / 4);
                obj.ToCenterPoint(center.X, center.Y + Height / 4);
                _attack_cd_timer = _attack_cd;
                _Ammo--;
                AudioManager.PlaySE("Laser1.wav");
            }
        }

        override public void Process_Action()
        {
            //if (Input.IsPressed("up"))
            //{
            //    Move_Up();
            //}
            //else if (Input.IsPressed("down"))
            //{
            //    Move_Down();
            //}
            //if (Input.IsPressed("left"))
            //{
            //    Move_Left();
            //}
            //else if (Input.IsPressed("right"))
            //{
            //    Move_Right();
            //}

            //if (Input.IsPressed("space") && _attack_cd_timer == 0 && _Ammo > 0)
            //{
            //    Factory.Create_DefaultBullet(this, x + Width / 2 - Bullet_DefaultBullet.WIDTH / 2, y - Height / 2);
            //    _attack_cd_timer = _attack_cd;
            //    _Ammo--;
            //    AudioManager.PlaySE("Laser1.wav");
            //}

            base.Process_Action();
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            base.CollidedWith(src);
            if (src is Game_Enemy)
            {

            }
        }

        private void Process_CD()
        {
            if (_attack_cd_timer > 0)
            {
                _attack_cd_timer--;
            }

            if (_Ammo_CD_timer > 0)
            {
                _Ammo_CD_timer--;
            }
            else
            {
                _Ammo_CD_timer = _Ammo_CD;
                if (_Ammo < _maxAmmo)
                {
                    _Ammo++;
                }
            }
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                Point center = Center;
                Game_Animation ani = Factory.Create_ani_Explosion("player", x, y);
                ani.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE("Explosion2.wav");
            }
        }
    }
}
