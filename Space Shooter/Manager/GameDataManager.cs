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
using System.Windows.Forms;
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
        static public int score = 0;
        static private int stage = 1;
        static private int time = 0;

        static public int Stage { get { return stage; } }
        //static public int highest_score;
        static public GameDifficulty Difficulty = GameDifficulty.Easy;

        static private SortedDictionary<string, StageData> StagesDict = new SortedDictionary<string, StageData>();
        static private SortedDictionary<int, List<Game_Object>> stageObjects = new SortedDictionary<int, List<Game_Object>>();

        #region Stage Control
        static public bool init = false;
        static public int NoteStageEndTimeRemain = 0;
        static public int NoteStageStartTimeRemain = 0;
        static public int GameOverTimeRemain = 0;
        static public string NoteStageEnd = "";
        static public string NoteStageStart = "";
        static public string NotePlayerDie = "";
        static public bool GameEnd = false;
        static public bool StageEnd = false;
        static public bool StopGame = false;
        static public int WaitToNextStage = 0;
        #endregion

        #region Update
        static public void Update()
        {
            if (!init)
            {
                return;
            }
            // Player died
            else if (player == null)
            {
                if (NotePlayerDie == "")
                {
                    NotePlayerDie = "GAME OVER";
                    GameOverTimeRemain = 300;
                }
                else if (GameOverTimeRemain > 0)
                {
                    GameOverTimeRemain--;
                } 
                else
                {
                    StopGame = true;
                }
            }

            if (IsStageClear() && player != null)
            {
                SetupStage();
                return;
            }
            
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
                stageObjects.Remove(time);
            }
        }

        static public void SetupStage()
        {
            if (!StageEnd)
            {
                WaitToNextStage = 450;
                
                if (stage == LAST_STAGE)
                {
                    NoteStageEnd = "VICTORY";
                    NoteStageEndTimeRemain = 400;
                    NoteStageStart = "";
                    NoteStageStartTimeRemain = 0;
                    GameEnd = true;
                }
                else
                {
                    NoteStageEndTimeRemain = 200;
                    NoteStageStartTimeRemain = 200;
                    NoteStageEnd = stage == 0 ? "ARE YOU READY?" : "STAGE CLEAR";
                    stage++;
                    NoteStageStart = "STAGE " + stage;
                }
                StageEnd = true;
            }
            else if (WaitToNextStage > 0)
            {
                WaitToNextStage--;
                if (NoteStageEndTimeRemain > 0)
                {
                    NoteStageEndTimeRemain--;
                }
                else if (NoteStageStartTimeRemain > 0)
                {
                    NoteStageStartTimeRemain--;
                } 
            }
            else
            {
                if (!GameEnd)
                {
                    StageEnd = false;
                    time = 0;
                    LoadStage(Difficulty, stage);
                }
                else
                {
                    // Exit the game
                    StopGame = true;
                }
            }
        }
        #endregion

        static public void Reset()
        {
            enemies.Clear();
            bullets.Clear();
            animations.Clear();
            player = Factory.Create_PlayerSpaceship(0, 0);
            score = 0;
            stage = 0;
            stageObjects.Clear();
            GameEnd = false;
            StageEnd = false;
            StopGame = false;
            NotePlayerDie = "";
            init = true;
        }

        static public bool IsStageClear()
        {
            return stageObjects.Count == 0 && enemies.Count == 0;
        }

        static public void NextStage()
        {
            stage++;
            time = 0;
        }

        static public void GainScore(int reward)
        {
            double modifier = 1;
            switch (Difficulty)
            {
                case GameDifficulty.Easy:
                    modifier = 1;
                    break;
                case GameDifficulty.Normal:
                    modifier = 1.5;
                    break;
                case GameDifficulty.Hard:
                    modifier = 2;
                    break;
            }
            score += (int)Math.Round(reward * modifier);
        }

        #region Getter
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

        static public List<Game_Object> AllDrawableObjects
        {
            get
            {
                List<Game_Object> list = new List<Game_Object>
                {
                    player
                };
                list.AddRange(bullets);
                list.AddRange(enemies);
                list.AddRange(animations);
                return list.OrderBy(obj => obj?.z).ToList();
            }
        }
        #endregion

        static public void LoadAllStages()
        {
            for (int i = 0; i < 3; i++)
            {
                bool exit = false;
                int stage = 0;
                while (!exit)
                {
                    stage++;
                    switch (i)
                    {
                        case 0:
                            {
                                StageData? data = LoadStageDataFromDisk("easy", stage);
                                if (data == null)
                                {
                                    exit = true;
                                }
                                else
                                {
                                    StagesDict.Add("easy" + stage, (StageData)data);
                                }
                                break;
                            }
                        case 1:
                            {
                                StageData? data = LoadStageDataFromDisk("normal", stage);
                                if (data == null)
                                {
                                    exit = true;
                                }
                                else
                                {
                                    StagesDict.Add("normal" + stage, (StageData)data);
                                }
                                break;
                            }
                        case 2:
                            {
                                StageData? data = LoadStageDataFromDisk("hard", stage);
                                if (data == null)
                                {
                                    exit = true;
                                }
                                else
                                {
                                    StagesDict.Add("hard" + stage, (StageData)data);
                                }
                                break;
                            }
                    }
                }
            }
        }

        static public StageData? LoadStageDataFromDisk(string difficulty, int stage)
        {
            StageData stageData = new StageData(new SortedDictionary<int, List<Game_Object>>());
            StreamReader sr = null;
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                sr = new StreamReader("data\\stage\\" + difficulty + "\\stage" + stage + ".txt");
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
                    int key = int.Parse(parse[0]);
                    float x = float.Parse(parse[2]);
                    float y = float.Parse(parse[3]);

                    Game_Object obj = null;
                    switch (parse[1])
                    {
                        // METEOR
                        case ObjectID.METEOR_1:
                            obj = Factory.Create_Meteor(1, x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_2:
                            obj = Factory.Create_Meteor(2, x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_3:
                            obj = Factory.Create_Meteor(3, x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_4:
                            obj = Factory.Create_Meteor(4, x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;
                        case ObjectID.METEOR_5:
                            obj = Factory.Create_Meteor(5, x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;

                        // ITEM
                        case ObjectID.ITEM_S:
                            obj = Factory.Create_Item_Shotgun(x, y, false);
                            break;
                        case ObjectID.ITEM_B:
                            obj = Factory.Create_Item_Bio(x, y, false);
                            break;
                        case ObjectID.ITEM_R:
                            obj = Factory.Create_Item_Rocket(x, y, false);
                            break;
                        case ObjectID.ITEM_G:
                            obj = Factory.Create_Item_Gatling(x, y, false);
                            break;
                        case ObjectID.ITEM_P:
                            obj = Factory.Create_Item_Piercing(x, y, false);
                            break;
                        case ObjectID.ITEM_F:
                            obj = Factory.Create_Item_Flamethrower(x, y, false);
                            break;
                        case ObjectID.ITEM_HEAL:
                            obj = Factory.Create_Item_Heal(x, y, false);
                            break;

                        // ENEMY
                        case ObjectID.KLAED_BATTLECRUISER:
                            obj = Factory.Create_Klaed_Battlecruiser(x, y, float.Parse(parse[4]), false);
                            break;
                        case ObjectID.KLAED_BOMBER:
                            obj = Factory.Create_Klaed_Bomber(x, y, float.Parse(parse[4]), false);
                            break;
                        case ObjectID.KLAED_DREADNOUGHT:
                            obj = Factory.Create_Klaed_Dreadnought(x, y, float.Parse(parse[4]), false);
                            break;
                        case ObjectID.KLAED_FIGHTER:
                            obj = Factory.Create_Klaed_Fighter(x, y, float.Parse(parse[4]), Utilities.ParseMode(parse[5]), false);
                            break;
                        case ObjectID.KLAED_FRIGATE:
                            obj = Factory.Create_Klaed_Frigate(x, y, float.Parse(parse[4]), Utilities.ParseMode(parse[5]), false);
                            break;
                        case ObjectID.KLAED_SCOUT:
                            obj = Factory.Create_Klaed_Scout(x, y, float.Parse(parse[4]), Utilities.ParseMode(parse[5]), false);
                            break;
                        case ObjectID.KLAED_SUPPORTSHIP:
                            obj = Factory.Create_Klaed_SupportShip(x, y, float.Parse(parse[4]), float.Parse(parse[5]), float.Parse(parse[6]), false);
                            break;
                        case ObjectID.KLAED_TORPEDOSHIP:
                            obj = Factory.Create_Klaed_TorpedoShip(x, y, float.Parse(parse[4]), Utilities.ParseMode(parse[5]), false);
                            break;

                        default:
                            Console.WriteLine("Unknown ID in line " + lineCount);
                            line = sr.ReadLine();
                            continue;
                    }
                    if (stageData.StageObjects.ContainsKey(key))
                    {
                        stageData.StageObjects[key].Add(obj);
                    }
                    else
                    {
                        stageData.StageObjects.Add(key, new List<Game_Object>());
                        stageData.StageObjects[key].Add(obj);
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
            finally
            {
                //close the file
                sr?.Close();
                Console.ReadLine();
            }
            return stageData;
        }

        static public bool LoadStage(GameDifficulty difficulty, int stage)
        {
            string difficultyStr = "";
            switch (difficulty)
            {
                case GameDifficulty.Easy:
                    difficultyStr = "easy";
                    break;
                case GameDifficulty.Normal:
                    difficultyStr = "normal";
                    break;
                case GameDifficulty.Hard:
                    difficultyStr = "hard";
                    break;
            }

            if (StagesDict.ContainsKey(difficultyStr + stage))
            {
                stageObjects = Utilities.CloneStageObjects(StagesDict[difficultyStr + stage].StageObjects);
                return true;
            }
            return false;
        }
    }

    struct StageData
    {
        public SortedDictionary<int, List<Game_Object>> StageObjects;

        public StageData(SortedDictionary<int, List<Game_Object>> stageObjects)
        {
            StageObjects = stageObjects;
        }
    }

    public enum GameDifficulty
    {
        Easy,
        Normal,
        Hard
    }
    public enum Ship
    {
        Default,
        Emissary,
        Beholder
    }
}
