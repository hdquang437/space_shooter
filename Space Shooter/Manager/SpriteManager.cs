using Space_Shooter.Core;
using Space_Shooter.Core.Bullet;
using Space_Shooter.Core.Enemy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Space_Shooter.Manager
{
    internal class SpriteManager
    {
        private static Dictionary<string, Game_Sprite> sprites = new Dictionary<string, Game_Sprite>();

        public static Dictionary<string, Game_Sprite> Sprites
        {
            get { return sprites; }
        }

        public static void Initialize()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("data\\sprites.txt");
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
                    if (parse.Length != 6 && parse.Length != 7)
                    {
                        Console.WriteLine("Data error at line " + lineCount + ":\n" + line);
                        line = sr.ReadLine();
                        continue;
                    }
                    string key = parse[0];
                    Bitmap bitmap = new Bitmap("img\\" + parse[1]);
                    int max_FrameX = Int32.Parse(parse[2]); 
                    int max_FrameY = Int32.Parse(parse[3]);
                    int frameWidth = Int32.Parse(parse[4]);
                    int frameHeight = Int32.Parse(parse[5]);
                    int frameCount = -1;
                    if (parse.Length >= 7)
                    {
                       frameCount = Int32.Parse(parse[6]);
                    }
                    Game_Sprite sprite = new Game_Sprite(bitmap, max_FrameX, max_FrameY, frameWidth, frameHeight, frameCount);
                    sprites.Add(key, sprite);

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
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
        }

        public Game_Sprite getSprite(string id)
        {
            return sprites[id];
        }
    }
}
