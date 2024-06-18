using Space_Shooter.Core;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Enemy;
using Space_Shooter.Core.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Manager
{
    public class Factory
    {
        static public GameDataManager GameDataManager = GameDataManager.Instance;

        #region Damageable entities
        public static Game_Player Create_PlayerSpaceship(float x, float y, Ship type)
        {
            string sprite = "player1";
            switch (type)
            {
                case Ship.Default:
                    break;
                case Ship.Beholder:
                    sprite = "player2";
                    break;
                case Ship.Emissary:
                    sprite = "player3";
                    break;
            }
            return new Game_Player(SpriteManager.Sprites[sprite], x, y);
        }


        public static Enemy_Meteor Create_Meteor(int size, float x, float y, float vx = 0, float vy = 1, float speed = 6, bool AddToData = true)
        {
            Enemy_Meteor obj = new Enemy_Meteor(SpriteManager.Sprites["meteor_size" + size], x, y, size, vx, vy, speed);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            return obj;
        }

        public static Game_Enemy Create_Klaed_Fighter(float x, float y, float speed, Game_Enemy.Mode mode, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Fighter(SpriteManager.Sprites["klaed_fighter"], x, y, speed, mode);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }

        public static Game_Enemy Create_Klaed_Bomber(float x, float y, float speed, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Bomber(SpriteManager.Sprites["klaed_bomber"], x, y, speed);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            return obj;
        }

        public static Game_Enemy Create_Klaed_Scout(float x, float y, float speed, Game_Enemy.Mode mode, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Scout(SpriteManager.Sprites["klaed_scout"], x, y, speed, mode);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }

        public static Game_Enemy Create_Klaed_Frigate(float x, float y, float speed, Game_Enemy.Mode mode, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Frigate(SpriteManager.Sprites["klaed_frigate"], x, y, speed, mode);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }

        public static Game_Enemy Create_Klaed_TorpedoShip(float x, float y, float speed, Game_Enemy.Mode mode, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_TorpedoShip(SpriteManager.Sprites["klaed_torpedoship"], x, y, speed, mode);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }

        public static Game_Enemy Create_Klaed_SupportShip(float x, float y, float vx, float vy, float speed, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_SupportShip(SpriteManager.Sprites["klaed_supportship"], x, y, vx, vy, speed);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            return obj;
        }

        public static Game_Enemy Create_Klaed_Battlecruiser(float x, float y, float speed, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Battlecruiser(SpriteManager.Sprites["klaed_battlecruiser"], x, y, speed);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }

        public static Game_Enemy Create_Klaed_Dreadnought(float x, float y, float speed, bool AddToData = true)
        {
            Game_Enemy obj = new Enemy_Klaed_Dreadnought(SpriteManager.Sprites["klaed_dreadnought"], x, y, speed);
            if (AddToData)
                GameDataManager.AddObjects(obj);
            obj.LoadWeapon();
            return obj;
        }
        #endregion

        #region Item
        public static Game_Item Create_Random_Loot(float x, float y, bool AddToData = true)
        {
            Game_Item item = null;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int type = random.Next(0, 7);
            switch (type)
            {
                case 0:
                    item = Create_Item_Shotgun(x, y, AddToData);
                    break;
                case 1:
                    item = Create_Item_Piercing(x, y, AddToData);
                    break;
                case 2:
                    item = Create_Item_Bio(x, y, AddToData);
                    break;
                case 3:
                    item = Create_Item_Gatling(x, y, AddToData);
                    break;
                case 4:
                    item = Create_Item_Rocket(x, y, AddToData);
                    break;
                case 5:
                    item = Create_Item_Flamethrower(x, y, AddToData);
                    break;
                case 6:
                    item = Create_Item_Heal(x, y, AddToData);
                    break;
            }
            return item;
        }

        public static Game_Item Create_Item_Shotgun(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponShotgun, x, y, ItemID.WeaponShotgun);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Piercing(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponPiercingGun, x, y, ItemID.WeaponPiercingGun);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Bio(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponBioSprayer, x, y, ItemID.WeaponBioSprayer);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Gatling(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponGatlingGun, x, y, ItemID.WeaponGatlingGun);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Rocket(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponRocket, x, y, ItemID.WeaponRocket);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Flamethrower(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.WeaponFlamethrower, x, y, ItemID.WeaponFlamethrower);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Coin(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.ItemCoin, x, y, ItemID.ItemCoin);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }

        public static Game_Item Create_Item_Heal(float x, float y, bool AddToData = true)
        {
            Game_Item item = new Game_Item(ItemID.ItemHealPack, x, y, ItemID.ItemHealPack);
            if (AddToData)
                GameDataManager.AddObjects(item);
            return item;
        }
        #endregion

        #region Bullets
        public static Bullet_DefaultBullet Create_DefaultBullet(Game_Object owner, float x, float y)
        {
            Bullet_DefaultBullet bullet = new Bullet_DefaultBullet(owner.ID, SpriteManager.Sprites["default_bullet"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }
        public static Bullet_Shotgun Create_ShotgunBullet(Game_Object owner, float x, float y)
        {
            Bullet_Shotgun bullet = new Bullet_Shotgun(owner.ID, SpriteManager.Sprites["shotgun"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }
        public static Bullet_Bio Create_BioBullet(Game_Object owner, float x, float y, float speed)
        {
            Bullet_Bio bullet = new Bullet_Bio(owner.ID, SpriteManager.Sprites["bio"], x, y, speed);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Bullet_Gatling Create_GatlingBullet(Game_Object owner, float x, float y)
        {
            Bullet_Gatling bullet = new Bullet_Gatling(owner.ID, SpriteManager.Sprites["gatling"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Bullet_Piercing Create_PiercingBullet(Game_Object owner, float x, float y)
        {
            Bullet_Piercing bullet = new Bullet_Piercing(owner.ID, SpriteManager.Sprites["pierce"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Bullet_Rocket Create_RocketBullet(Game_Object owner, float x, float y)
        {
            Bullet_Rocket bullet = new Bullet_Rocket(owner.ID, SpriteManager.Sprites["rocket"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Bullet_Flame Create_FlameBullet(Game_Object owner, float x, float y)
        {
            Bullet_Flame bullet = new Bullet_Flame(owner.ID, SpriteManager.Sprites["flame"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Game_Bullet Create_EnemyBullet_Straight(Game_Object owner, float x, float y)
        {
            Game_Bullet bullet = new EnemyBullet_Straight(owner.ID, SpriteManager.Sprites["enemy_bullet"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Game_Bullet Create_EnemyBullet_Homing(Game_Object owner, float x, float y)
        {
            Game_Bullet bullet = new EnemyBullet_Homing(owner.ID, SpriteManager.Sprites["enemy_bullet"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Game_Bullet Create_EnemyBullet_Sniping(Game_Object owner, float x, float y)
        {
            Game_Bullet bullet = new EnemyBullet_Sniping(owner.ID, SpriteManager.Sprites["enemy_bullet"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }

        public static Game_Bullet Create_EnemyBullet_Spread(Game_Object owner, float x, float y)
        {
            Game_Bullet bullet = new EnemyBullet_Spread(owner.ID, SpriteManager.Sprites["enemy_bullet"], x, y);
            GameDataManager.AddObjects(bullet);
            return bullet;
        }
        #endregion

        #region Animation

        ///<summary>
        ///Type is the animation id without explo_ prefix
        ///x, y is the center point of the animation
        ///</summary>
        public static Game_Animation Create_ani_Explosion(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation("explo_" + type, x, y);
            GameDataManager.AddObjects(ani);
            ani.ToCenterPoint(x, y);
            return ani;
        }

        public static Game_Animation Create_ani_Break(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation("break_" + type, x, y);
            ani.ToCenterPoint(x, y);
            GameDataManager.AddObjects(ani);
            return ani;
        }
        #endregion

        #region Weapon

        public static Weapon_Default Create_PlayerWeapon_Default(Game_CollidableObject owner)
        {
            return new Weapon_Default(owner.ID, 0, -owner.Height / 4);
        }

        public static Weapon_Shotgun Create_PlayerWeapon_Shotgun(Game_CollidableObject owner)
        {
            return new Weapon_Shotgun(owner.ID, 0, -owner.Height / 4);
        }

        public static Weapon_Bio Create_PlayerWeapon_Bio(Game_CollidableObject owner)
        {
            return new Weapon_Bio(owner.ID, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Flamethrower Create_PlayerWeapon_Flamethrower(Game_CollidableObject owner)
        {
            return new Weapon_Flamethrower(owner.ID, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Gatling Create_PlayerWeapon_Gatling(Game_CollidableObject owner)
        {
            return new Weapon_Gatling(owner.ID, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Rocket Create_PlayerWeapon_Rocket(Game_CollidableObject owner)
        {
            return new Weapon_Rocket(owner.ID, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Weapon_Piercing Create_PlayerWeapon_Piercing(Game_CollidableObject owner)
        {
            return new Weapon_Piercing(owner.ID, owner.Width * 0.4f, -owner.Height / 4);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_Single(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_Single(owner.ID, offsetX, offsetY);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_Rifle(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_Rifle(owner.ID, offsetX, offsetY);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_Homing(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_Homing(owner.ID, offsetX, offsetY);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_HomingRifle(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_HomingRifle(owner.ID, offsetX, offsetY);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_SniperRifle(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_SniperRifle(owner.ID, offsetX, offsetY);
        }

        public static Game_EnemyWeapon Create_EnemyWeapon_Sniper(Game_CollidableObject owner, float offsetX, float offsetY)
        {
            return new EnemyWeapon_Sniper(owner.ID, offsetX, offsetY);
        }
        #endregion
    }
}
