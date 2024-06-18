using Newtonsoft.Json;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    public struct MeteorMinion
    {
        public int size;
        public float velocityX;
        public float velocityY;
        public float speed;
        public MeteorMinion(int size, float velocityX, float velocityY, float speed)
        {
            this.size = size;
            this.velocityX = velocityX;
            this.velocityY = velocityY;
            this.speed = speed;
        }
    }

    public class Enemy_Meteor : Game_SpawnableEnemy<MeteorMinion>
    {
        public override Type realType { get; } = typeof(Enemy_Meteor);

        public const int SIZE_1 = 40;
        public const int SIZE_2 = 80;
        public const int SIZE_3 = 150;
        public const int SIZE_4 = 320;
        public const int SIZE_5 = 540;

        [JsonProperty] private float velocityX;
        [JsonProperty] private float velocityY;
        [JsonProperty] private int size;

        public Enemy_Meteor(Game_Sprite sprite, float x, float y, int size, float vX = 0, float vY = 1, float speed = 5)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites[$"meteor_size{size}"];
                _sprite = sprite;
            }
            spriteID = $"meteor_size{size}";
            _z = 10;
            this.velocityX = vX;
            this.velocityY = vY;
            this.size = size;
            this._MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _frame_CD = 12;
            _collideDamage = 1000;
            switch (size)
            {
                case 1:
                    _hp = 10;
                    _collideDamage = 10;
                    _reward = 5;
                    break;
                case 2:
                    _hp = 50;
                    _reward = 10;
                    GenerateRandomMinions(1, 1, 3, 5);
                    break;
                case 3:
                    _hp = 100;
                    _reward = 25;
                    GenerateRandomMinions(2, 2, 1, 2);
                    GenerateRandomMinions(1, 2, 2, 2);
                    GenerateRandomMinions(1, 1, 2, 3);
                    break;
                case 4:
                    _hp = 200;
                    _reward = 50;
                    GenerateRandomMinions(3, 3, 1, 2);
                    GenerateRandomMinions(2, 3, 1, 2);
                    GenerateRandomMinions(1, 2, 3, 5);
                    break;
                case 5:
                    _hp = 500;
                    _reward = 100;
                    GenerateRandomMinions(4, 4, 1, 2);
                    GenerateRandomMinions(3, 4, 1, 1);
                    GenerateRandomMinions(1, 3, 2, 4);
                    GenerateRandomMinions(1, 2, 3, 5);
                    break;
            }
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
        }

        [JsonConstructor]
        public Enemy_Meteor(Game_Sprite sprite, float x, float y, int size, float vX, float vY, float speed, List<MeteorMinion> minions)
            : base(sprite, x, y)
        {
            if (sprite == null)
            {
                sprite = SpriteManager.Sprites[$"meteor_size{size}"];
                _sprite = sprite;
            }
            spriteID = $"meteor_size{size}";
            _z = 10;
            this.velocityX = vX;
            this.velocityY = vY;
            this.size = size;
            this._MoveSpeed = Math.Max(speed, 0.1f); // Minimum speed is 0.1f
            _frame_CD = 12;
            _collideDamage = 1000;
            _Width = sprite.Width;
            _Height = sprite.Height;
            _r = _Width / 2;
            this._minions = minions;
            switch (size)
            {
                case 1:
                    _hp = 10;
                    _collideDamage = 10;
                    _reward = 5;
                    break;
                case 2:
                    _hp = 50;
                    _reward = 10;
                    break;
                case 3:
                    _hp = 100;
                    _reward = 25;
                    break;
                case 4:
                    _hp = 200;
                    _reward = 50;
                    break;
                case 5:
                    _hp = 500;
                    _reward = 100;
                    break;
            }
        }

        private void GenerateRandomMinions(int minSize, int maxSize, int minChildAmount, int maxChildAmount)
        {
            List<MeteorMinion> list = new List<MeteorMinion>();

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int amount = random.Next(minChildAmount, maxChildAmount); 

            for (int i = 0; i < amount; i++)
            {
                random = new Random(Guid.NewGuid().GetHashCode());
                int size = random.Next(minSize, maxSize);
                random = new Random(Guid.NewGuid().GetHashCode());
                int vX = random.Next(-100, 101);
                random = new Random(Guid.NewGuid().GetHashCode());
                int vY = random.Next(10, 101);
                random = new Random(Guid.NewGuid().GetHashCode());
                float spd = random.Next((int)(_MoveSpeed * 110), (int)(_MoveSpeed * 150)) / 100f + size * 0.2f;
                MeteorMinion minion = new MeteorMinion(size, vX, vY, spd);
                list.Add(minion);
            }
            minions.AddRange(list);
        }

        public override void Process_Action()
        {
            if (velocityX != 0 && velocityY != 1)
                Move_Vector(velocityX, velocityY);
            else
                Move_Down();
            base.Process_Action();
        }

        public override void Update()
        {
            Process_Action();
            base.Update();
            Update_Data();
        }

        public override void Colliding(Game_CollidableObject target)
        {
            base.Colliding(target);
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
                //if (Game_Database.player != null)
                //{
                //    Game_Database.score += _reward;
                //}
                PointF center = Center;

                Game_Animation breakAni = Factory.Create_ani_Break("size" + size, x, y);
                breakAni.ToCenterPoint(center.X, center.Y);
                AudioManager.PlaySE(SE.Break);
                // Spawn small meteors


                foreach (MeteorMinion minion in minions)
                {
                    Enemy_Meteor child = Factory.Create_Meteor(minion.size, center.X, center.Y, minion.velocityX, minion.velocityY, minion.speed);
                    child.ToCenterPoint(center.X, center.Y);
                }
            }
        }
    }
}
