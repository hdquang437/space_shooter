using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public override Type realType { get; } = typeof(Game_Player);

        [JsonIgnore]
        public Game_Weapon Weapon {
            get { return secondaryWep != null ? secondaryWep : primaryWep; }
        }

        [JsonProperty] Game_Weapon primaryWep;
        [JsonProperty] Game_Weapon secondaryWep;

        [JsonProperty] int changeWepDelay = 0;
        readonly int maxChangeWepDelay = 80;
        readonly int baseSpeed = 4;
        readonly int boostSpeed = 10;

        readonly int _maxHP = 100;

        [JsonIgnore]
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
        [JsonIgnore]
        public int MaxHP {  get { return _maxHP; } }
        [JsonIgnore]
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
        [JsonIgnore]
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
        [JsonIgnore]
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
        [JsonIgnore]
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
            if (sprite == null)
            {
                Game_Player tmp = Factory.Create_PlayerSpaceship(0, 0, GameDataManager.playerShipType);
                sprite = tmp._sprite;
                _sprite = sprite;
            }           
            _Width = sprite.Width;
            _Height = sprite.Height;
            _collidable = true;
            _collideDamage = 50;
            _r = sprite.Width / 4;
            _MoveSpeed = 4;
            _frame_CD = 10;
            _hp = _maxHP;
        }

        public void LoadDefaultWeapon()
        {
            primaryWep = Factory.Create_PlayerWeapon_Default(this);
            secondaryWep = null;
        }

        public override void Update()
        {
            base.Update();
            Fix_Weapon();
            primaryWep?.Update();
            secondaryWep?.Update();
            Process_Action();
            List<Game_CollidableObject> enemyTeam = GameDataManager.EnemyTeam_CollidableObjects;
            Game_Collision.Scan(this, enemyTeam);
            Update_Data();
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

        public void Fix_Weapon()
        {
            if (primaryWep != null && primaryWep.GetType() != primaryWep.realType)
            {
                primaryWep = primaryWep.DeserializingPackup();
            }
            if (secondaryWep != null && secondaryWep.GetType() != secondaryWep.realType)
            {
                secondaryWep = secondaryWep.DeserializingPackup();
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

        public override void SelfSerializing()
        {
            if (primaryWep != null)
            {
                primaryWep.SelfSerializing();
            }
            if (secondaryWep != null)
            {
                secondaryWep.SelfSerializing();
            }
            base.SelfSerializing();
        }
    }
}
