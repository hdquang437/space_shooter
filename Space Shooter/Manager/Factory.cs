using Space_Shooter.Core;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Enemy;
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
        public static Game_Player Create_PlayerSpaceship(int x, int y)
        {
            return new Game_Player(SpriteManager.Sprites["player1"], x, y);
        }

        public static Bullet_DefaultBullet Create_DefaultBullet(Game_Object owner, int x, int y)
        {
            Bullet_DefaultBullet bullet = new Bullet_DefaultBullet(owner, SpriteManager.Sprites["default_bullet"], x, y);
            GameDataManager.bullets.Add(bullet);
            return bullet;
        }

        public static Enemy_Meteor Create_Meteor(int size, int x, int y, int vx = 0, int vy = 1, int speed = 6, bool AddToData = true)
        {
            Enemy_Meteor obj = new Enemy_Meteor(SpriteManager.Sprites["meteor_size" + size], x, y, size, vx, vy, speed);
            if (AddToData)
                GameDataManager.enemies.Add(obj);
            return obj;
        }
        #endregion

        #region Bullets
        #endregion

        #region Animation

        ///<summary>
        ///Type is the animation id without explo_ prefix
        ///</summary>
        public static Game_Animation Create_ani_Explosion(string type, int x, int y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["explo_" + type], x, y);
            GameDataManager.animations.Add(ani);
            ani.ToCenterPoint(x, y);
            return ani;
        }

        public static Game_Animation Create_ani_Break(string type, int x, int y)
        {
            Game_Animation ani = new Game_Animation(SpriteManager.Sprites["break_" + type], x, y);
            ani.ToCenterPoint(x, y);
            GameDataManager.animations.Add(ani);
            return ani;
        }
        #endregion
    }
}
