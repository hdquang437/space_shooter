using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    internal class Game_Item : Game_Enemy
    {
        string buffType;

        public Game_Item(Game_Sprite sprite, float x, float y, string buffType)
            : base(sprite, x, y)
        {
            _hp = 1;
            _collideDamage = 0;
            this.buffType = buffType;
            _ignoreBullet = true;
            _MoveSpeed = 4;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            _reward = 100;
        }

        public override void Process_Action()
        {
            Move_Down();
            base.Process_Action();
        }

        override public void CollidedWith(Game_CollidableObject src)
        {
            if (_die)
            {
                return;
            }
            base.CollidedWith(src);
            if (src is Game_Player player && !src.die)
            {
                giveBuff(player);
                _die = true;
            }
        }

        private void giveBuff(Game_Player src)
        {
            AudioManager.PlaySE(SE.Up1);
            switch (buffType)
            {
                case ItemID.WeaponShotgun:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Shotgun(src));
                        break;
                    }
                case ItemID.WeaponPiercingGun:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Piercing(src));
                        break;
                    }
                case ItemID.WeaponBioSprayer:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Bio(src));
                        break;
                    }
                case ItemID.WeaponRocket:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Rocket(src));
                        break;
                    }
                case ItemID.WeaponFlamethrower:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Flamethrower(src));
                        break;
                    }
                case ItemID.WeaponGatlingGun:
                    {
                        src.GetWeapon(Factory.Create_PlayerWeapon_Gatling(src));
                        break;
                    }
                case ItemID.ItemCoin:
                    {
                        // Unimplemented
                        break;
                    }
                case ItemID.ItemHealPack:
                    {
                        src.HP += 50;
                        break;
                    }
            }
        }
    }

    internal abstract class ItemID
    {
        #region Weapon
        public const string WeaponShotgun = "wep_shotgun";
        public const string WeaponGatlingGun = "wep_gatling";
        public const string WeaponBioSprayer = "wep_bio";
        public const string WeaponPiercingGun = "wep_piercing";
        public const string WeaponRocket = "wep_rocket";
        public const string WeaponFlamethrower = "wep_flamethrower";
        #endregion

        #region bonus
        public const string ItemCoin = "item_coin";
        public const string ItemHealPack = "item_heal";
        #endregion
    }
}
