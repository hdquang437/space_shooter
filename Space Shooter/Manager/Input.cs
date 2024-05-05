using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Space_Shooter.Manager
{
    internal struct KeyboardState
    {
        public bool up;
        public bool down;
        public bool left;
        public bool right;
        public bool shoot;
        public bool turbo;
        public KeyboardState(bool up, bool down, bool left, bool right, bool shot, bool turbo)
        {
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
            this.shoot = shot;
            this.turbo = turbo;
        }
    }

    internal class Input
    {
        public static void keyDown(object sender, KeyEventArgs e)
        {

        }

        public static void GetKeyStates()
        {
            bool up = false;
            bool down = false;
            bool left = false;
            bool right = false;
            bool shoot = false;
            bool turbo = false;

            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left))
            {
                left = true;
            }
            if (Keyboard.IsKeyDown(Key.W) || Keyboard.IsKeyDown(Key.Up))
            {
                up = true;
            }
            if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right))
            {
                right = true;
            }
            if (Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.Down))
            {
                down = true;
            }
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                turbo = true;
            }    
            if (Keyboard.IsKeyDown(Key.Space))
            {
                shoot = true;
            }
            if (GameDataManager.player != null)
            {
                GameDataManager.player.Process_KeyEvent(new KeyboardState(up, down, left, right, shoot, turbo));
            }
        }


        public static bool IsPressed(string key)
        {

            switch (key)
            {
                case "left":
                    {
                        return Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left);
                    }

                case "up":
                    {
                        return Keyboard.IsKeyDown(Key.W) || Keyboard.IsKeyDown(Key.Up);
                    }

                case "right":
                    {
                        return Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right);
                    }

                case "down":
                    {
                        return Keyboard.IsKeyDown(Key.S) || Keyboard.IsKeyDown(Key.Down);
                    }
                case "space":
                    {
                        return Keyboard.IsKeyDown(Key.Space);
                    }
                case "up_left":
                    {
                        return IsPressed("up") && IsPressed("left");
                    }
                case "up_right":
                    {
                        return IsPressed("up") && IsPressed("right");
                    }
                case "down_left":
                    {
                        return IsPressed("down") && IsPressed("left");
                    }
                case "down_right":
                    {
                        return IsPressed("down") && IsPressed("right");
                    }
                case "pause":
                    {
                        return Keyboard.IsKeyDown(Key.P);
                    }
            }
            return false;
        }

        public static bool IsReleased(string key)
        {
            switch (key)
            {
                case "left":
                    {
                        return Keyboard.IsKeyUp(Key.A) || Keyboard.IsKeyUp(Key.Left);
                    }

                case "up":
                    {
                        return Keyboard.IsKeyUp(Key.W) || Keyboard.IsKeyUp(Key.Up);
                    }

                case "right":
                    {
                        return Keyboard.IsKeyUp(Key.D) || Keyboard.IsKeyUp(Key.Right);
                    }

                case "down":
                    {
                        return Keyboard.IsKeyUp(Key.S) || Keyboard.IsKeyUp(Key.Down);
                    }

                case "space":
                    {
                        return Keyboard.IsKeyUp(Key.Space);
                    }
            }
            return false;
        }
    }
}
