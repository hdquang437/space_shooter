using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Shooter.Core
{
    public class Game_SpawnableEnemy<T> : Game_Enemy
    {

        public Game_SpawnableEnemy(Game_Sprite sprite, float x, float y)
        : base(sprite,x, y)
        {

        }

        [JsonProperty] protected List<T> _minions = new List<T>();
        
        [JsonIgnore]        
        public List<T> minions
        {
            get { return _minions; }
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Update_Data()
        {
            base.Update_Data();
        }

        public override void Process_Action()
        {
            base.Process_Action();
        }
    }
}
