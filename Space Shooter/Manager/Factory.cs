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
    internal class Factory
    {

        #region Damageable entities
        public static Game_Player Create_PlayerSpaceship(float x, float y)
        {
            return new Game_Player(SpriteManager.Sprites["player1"], x, y);
        }



        public static Enemy_Meteor Create_Meteor(int size, float x, float y, float vx = 0, float vy = 1, float speed = 6, bool AddToData = true)
        {
            Enemy_Meteor obj = new Enemy_Meteor(SpriteManager.Sprites["meteor_size" + size], x, y, size, vx, vy, speed);
            if (AddToData)
                GameDataManager.enemies.Add(obj);
            return obj;
        }
        #endregion


        #region Bullets
        public static Bullet_DefaultBullet Create_DefaultBullet(Game_Object owner, float x, float y)
        {
            Bullet_DefaultBullet bullet = new Bullet_DefaultBullet(owner, SpriteManager.Sprites["default_bullet"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Bullet_Shotgun Create_ShotgunBullet(Game_Object owner, float x, float y)
        {
            Bullet_Shotgun bullet = new Bullet_Shotgun(owner, SpriteManager.Sprites["shotgun"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        #endregion

        #region Animation

        ///<summary>
        ///Type is the animation id without explo_ prefix
        ///</summary>
        public static Game_Animation Create_ani_Explosion(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["explo_" + type], x, y);
            GameDataManager.animations.Add(ani);
            ani.ToCenterPoint(x, y);
            return ani;
        }

        public static Game_Animation Create_ani_Break(string type, float x, float y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["break_" + type], x, y);
            ani.ToCenterPoint(x, y);
            GameDataManager.animations.Add(ani);
            return ani;
        }
        #endregion

        #region Weapon

        public static Weapon_Default Create_PlayerWeapon_Default(Game_CollidableObject owner)
        {
            return new Weapon_Default(owner, 0, - owner.Height / 4);
        }

        public static Weapon_Shotgun Create_PlayerWeapon_Shotgun(Game_CollidableObject owner)
        {
            return new Weapon_Shotgun(owner, 0, - owner.Height / 4);
        }
        #endregion
    }
}
