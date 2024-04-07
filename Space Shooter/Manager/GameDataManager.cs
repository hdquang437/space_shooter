using Space_Shooter.Core;
using Space_Shooter.Core.Enemy;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Space_Shooter.Manager
{
    internal class GameDataManager
    {
        public const int LAST_STAGE = 10;
        static public List<Game_Enemy> enemies = new List<Game_Enemy>();
        static public List<Game_Bullet> bullets = new List<Game_Bullet>();
        static public List<Game_Animation> animations = new List<Game_Animation>();
        static public Game_Player player;
        static public int score;
        static private int stage = 1;
        static private int time = 0;

        static public int Stage { get { return stage; } }
        //static public int highest_score;

        static private Dictionary<int, List<Game_Object>> stageObjects = new Dictionary<int, List<Game_Object>>();

        static public void Update()
        {
            time++;
            if (!stageObjects.ContainsKey(time))
            {
                return;
            }
            List<Game_Object> list = stageObjects[time];
            if (list != null && list.Count != 0)
            {
                foreach (Game_Object obj in list)
                {
                    if (obj is Game_Enemy enemy)
                    {
                        enemies.Add(enemy);
                    }
                }
                stageObjects[time] = null;
            }
        }

        static public void reset()
        {
            enemies.Clear();
            bullets.Clear();
            animations.Clear();
            player = Factory.Create_PlayerSpaceship(0, 0);
            score = 0;
            stage = 1;
            stageObjects.Clear();
        }

        static public bool IsStageClear()
        {
            return stageObjects.Count == 0;
        }

        static public void NextStage()
        {
            stage++;
            time = 0;
        }

        static public void GainScore(int reward)
        {
            score += reward;
        }

        static public List<Game_CollidableObject> EnemyTeam_CollidableObjects
        {
            get
            {
                List<Game_CollidableObject> list = new List<Game_CollidableObject>();
                list.AddRange(enemies);
                list.AddRange(bullets.FindAll(x => !x.IsPlayerBullet()));
                return list;
            }
        }

        static public List<Game_CollidableObject> PlayerTeam_CollidableObjects
        {
            get
            {
                List<Game_CollidableObject> list = new List<Game_CollidableObject>();
                list.Add(player);
                list.AddRange(bullets.FindAll(x => x.IsPlayerBullet()));
                return list;
            }
        }

        static public bool LoadStage(string difficulty, int stage)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("data\\stage\\" + difficulty + "\\stage" + stage + ".txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                int lineCount = 0;
                while (line != null)
                {
                    lineCount++;
                    if (line.StartsWith("#") || String.IsNullOrWhiteSpace(line))
                    {
                        line = sr.ReadLine();
                        continue;
                    }
                    string[] parse = line.Split('\t');
                    if (parse.Length < 4)
                    {
                        Console.WriteLine("Data error at line " + lineCount + ":\n" + line);
                        line = sr.ReadLine();
                        continue;
                    }
                    int key = Int32.Parse(parse[0]);
                    int x = Int32.Parse(parse[2]);
                    int y = Int32.Parse(parse[3]);

                    Game_Object obj = null;
                    switch (parse[1])
                    {
                        case ObjectID.METEOR_1:
                            obj = Factory.Create_Meteor(1, x, y, Int32.Parse(parse[4]),Int32.Parse(parse[5]), Int32.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_2:
                            obj = Factory.Create_Meteor(2, x, y, Int32.Parse(parse[4]), Int32.Parse(parse[5]), Int32.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_3:
                            obj = Factory.Create_Meteor(3, x, y, Int32.Parse(parse[4]), Int32.Parse(parse[5]), Int32.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_4:
                            obj = Factory.Create_Meteor(4, x, y, Int32.Parse(parse[4]), Int32.Parse(parse[5]), Int32.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_5:
                            obj = Factory.Create_Meteor(5, x, y, Int32.Parse(parse[4]), Int32.Parse(parse[5]), Int32.Parse(parse[6]), false);
                            break;
                        default:
                            Console.WriteLine("Unknown ID in line " + lineCount);
                            continue;
                            break;
                    }
                    if (stageObjects.ContainsKey(key))
                    {
                        stageObjects[key].Add(obj);
                    }
                    else
                    {
                        stageObjects.Add(key, new List<Game_Object>());
                        stageObjects[key].Add(obj);
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
            stageObjects.OrderBy(x => x.Key);
            return true;
        }
    }
}
