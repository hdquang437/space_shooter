using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core.Enemy
{
    struct MeteorMinion
    {
        public int size;
        public int velocityX;
        public int velocityY;
        public int speed;
        public MeteorMinion(int size, int velocityX, int velocityY, int speed)
        {
            this.size = size;
            this.velocityX = velocityX;
            this.velocityY = velocityY;
            this.speed = speed;
        }
    }

    internal class Enemy_Meteor : Game_SpawnableEnemy<MeteorMinion>
    {
        public const int SIZE_1 = 40;
        public const int SIZE_2 = 80;
        public const int SIZE_3 = 150;
        public const int SIZE_4 = 320;
        public const int SIZE_5 = 540;

        private int velocityX;
        private int velocityY;
        private int size;

        public Enemy_Meteor(Game_Sprite sprite, int x, int y, int size, int vX = 0, int vY = 1, int speed = 5)
            : base(sprite, x, y)
        {
            this.velocityX = vX;
            this.velocityY = vY;
            this.size = size;
            this._MoveSpeed = speed;
            _frame_CD = 12;
            _collideDamage = 100;
            switch (size)
            {
                case 1:
                    _hp = 1;
                    break;
                case 2:
                    _hp = 2;
                    GenerateRandomMinions(1, 1, 3, 5);
                    break;
                case 3:
                    _hp = 5;
                    GenerateRandomMinions(2, 2, 1, 2);
                    GenerateRandomMinions(1, 2, 2, 2);
                    GenerateRandomMinions(1, 1, 2, 3);
                    break;
                case 4:
                    _hp = 10;
                    GenerateRandomMinions(3, 3, 1, 2);
                    GenerateRandomMinions(2, 3, 1, 2);
                    GenerateRandomMinions(1, 2, 3, 5);
                    break;
                case 5:
                    _hp = 20;
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
                int spd = random.Next(_MoveSpeed, _MoveSpeed + 5 - size);
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
                int offset = 20;
                Factory.Create_ani_Break("size" + size, x - offset, y - offset);
                AudioManager.PlaySE("Break.wav");
                // Spawn small meteors
                
                int centerX = x + Width / 2;
                int centerY = y + Height / 2;

                foreach (MeteorMinion minion in minions)
                {
                    Enemy_Meteor child = Factory.Create_Meteor(minion.size, centerX, centerY, minion.velocityX, minion.velocityY, minion.speed);
                    child.ToCenterPoint(centerX, centerY);
                }
            }
        }
    }
}
