using Space_Shooter.AccountManagement.Model;
using Space_Shooter.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Manager
{
    public static class Utilities
    {
        static public PointF GetVector(PointF src, PointF des)
        {
            return new PointF(des.X - src.X, des.Y - src.Y);
        }

        static public Game_Enemy.Mode ParseMode(string modeStr)
        {
            switch (modeStr)
            {
                case "following":
                    return Game_Enemy.Mode.following;
                case "forward":
                    return Game_Enemy.Mode.forward;
                default:
                    return Game_Enemy.Mode.forward;
            }
        }

        static public SortedDictionary<int, List<Game_Object>> CloneStageObjects(SortedDictionary<int, List<Game_Object>> src)
        {
            SortedDictionary<int, List<Game_Object>> clone = new SortedDictionary<int, List<Game_Object>>();

            foreach (KeyValuePair<int, List<Game_Object>> entry in src)
            {
                clone.Add(entry.Key, entry.Value);
            }

            return clone;
        }

        static public int CompareUserResult(User user1, User user2, string difficulty)
        {
            if (user1.highestScore[difficulty] != user2.highestScore[difficulty])
            {
                return user1.highestScore[difficulty] - user2.highestScore[difficulty];
            }
            else
            {
                if (user1.playTime[difficulty] > 0 && user2.playTime[difficulty] < 0)
                {
                    return 1;
                }
                if (user1.playTime[difficulty] < 0 && user2.playTime[difficulty] > 0)
                {
                    return -1;
                }
                if (user1.playTime[difficulty] < 0 && user2.playTime[difficulty] < 0)
                {
                    return user2.name.CompareTo(user1.name);
                }
                return user2.playTime[difficulty] - user1.playTime[difficulty];
            }
        }

        static public bool IsHighScore(User user, string difficulty)
        {
            GameDataManager gameDataManager = GameDataManager.Instance;
            if (gameDataManager.score > user.highestScore[difficulty]
            || (gameDataManager.score == user.highestScore[difficulty]
                && gameDataManager.PlayTime < user.playTime[difficulty] || user.playTime[difficulty] < 0))
            {
                return true;
            }
            return false;
        }
    }
}
