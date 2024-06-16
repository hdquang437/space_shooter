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
    public class Game_Player : Game_CollidableObject
    {
        public Game_Weapon Weapon {
            get { return secondaryWep != null ? secondaryWep : primaryWep; }
        }

        Game_Weapon primaryWep;
        Game_Weapon secondaryWep;

        int changeWepDelay = 0;
        int maxChangeWepDelay = 80;
        int baseSpeed = 4;
        int boostSpeed = 10;

        int _maxHP = 100;

        override public int HP
        {
            get
            {
                return _hp >= 0 ? _hp : 0;
            }
            set
            {
                _hp = (Math.Max(0, Math.Min(_maxHP, value)));
            }
        }

        public int MaxHP {  get { return _maxHP; } }

        public int MaxAmmo
        {
            get
            {
                if (changeWepDelay > 0)
                {
                    return maxChangeWepDelay;
                }
                return Weapon != null ? Weapon.MaxAmmo : 0;
            }
        }
        public int Ammo
        {
            get
            {
                if (changeWepDelay > 0)
                {
                    return maxChangeWepDelay - changeWepDelay;
                }
                return Weapon != null ? Weapon.Ammo : 0;
            }
        }

        public Color WepPrimaryColor
        {
            get
            {
                if (changeWepDelay > 0)
                {
                    return System.Drawing.Color.Gray;
                }
                return Weapon != null ? Weapon.PrimaryColor : System.Drawing.Color.White;
            }
        }

        public Color WepSecondaryColor
        {
            get
            {
                if (changeWepDelay > 0)
                {
                    return System.Drawing.Color.DarkGray;
                }
                return Weapon != null ? Weapon.SecondaryColor : System.Drawing.Color.White;
            }
        }

        public Game_Player(Game_Sprite sprite, float posX = 0, float posY = 0)
            : base(sprite, posX, posY)
        {
            // Data
            _z = 3;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _collidable = true;
            _collideDamage = 50;
            _r = sprite.Width / 4;
            _MoveSpeed = 4;
            _frame_CD = 10;
            _hp = _maxHP;
            primaryWep = Factory.Create_PlayerWeapon_Default(this);
            secondaryWep = null;
        }

        public override void Update()
        {
            base.Update();
            Process_Action();
            List<Game_CollidableObject> enemyTeam = GameDataManager.EnemyTeam_CollidableObjects;
            Game_Collision.Scan(this, enemyTeam);
            Update_Data();
            primaryWep?.Update();
            secondaryWep?.Update();
        }

        public override void Update_Data()
        {
            base.Update_Data();
            if (secondaryWep?.Ammo == 0)
            {
                secondaryWep = null;
                changeWepDelay = maxChangeWepDelay;
            }
        }

        public void Process_KeyEvent(KeyboardState state)
        {
            switch (GameDataManager.playMode)
            {
                case PlayMode.Keyboard:
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
                        if (state.shoot && changeWepDelay == 0)
                        {
                            Weapon?.Shoot();
                        }
                        break;
                    }
                case PlayMode.Mouse:
                    {
                        MoveToPoint(GameDataManager.cursorPosition.X, GameDataManager.cursorPosition.Y);
                        if (state.shoot && changeWepDelay == 0)
                        {
                            Weapon?.Shoot();
                        }
                        break;
                    }
            }

            _MoveSpeed = state.turbo ? boostSpeed : baseSpeed;
        }

        override public void Process_Action()
        {
            fix_stuck();
            base.Process_Action();
            if (changeWepDelay > 0)
            {
                changeWepDelay--;
            }
        }

        public override void CollidedWith(Game_CollidableObject src)
        {
            base.CollidedWith(src);
        }

        public override void Process_BeforeDie()
        {
            base.Process_BeforeDie();
            if (_die_ani)
            {
                PointF center = Center;
                Game_Animation ani = Factory.Create_ani_Explosion("player", x, y);
                ani.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE(SE.Explosion2);
            }
        }

        public void GetWeapon(Game_Weapon wep)
        {
            secondaryWep = wep;
            changeWepDelay = maxChangeWepDelay;
        }
    }
}
