using Space_Shooter.Core;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Space_Shooter.Control
{
    public partial class Screen_Game : UserControl
    {
        public const int REAL_SCREEN_WIDTH = 1540;
        public const int REAL_SCREEN_HEIGHT = 830;

        static private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        //private int time = 0;
        int scrollY = 1;

        private Form1 parentForm;
        private Screen_Pause screenPause;
        private Screen_SaveAndLoad screenSaveAndLoad;

        Bitmap background = new Bitmap(Space_Shooter.Properties.Resources.Background, 1536, 1536);

        #region FPS caculator params

        DateTime _lastTime; // marks the beginning the measurement began
        int _framesRendered; // an increasing count
        int _fps;

        #endregion

        public Screen_Game(Form1 parent)
        {
            InitializeComponent();

            parentForm = parent;

            SpriteManager.Initialize();
            GameDataManager.LoadAllStages();

            //_timer.Start();
            _timer.Interval = 10;
            _timer.Tick += new EventHandler(TimerOnTick);

            label_screenshot.Text = "";

            screenPause = new Screen_Pause();
            screenSaveAndLoad = new Screen_SaveAndLoad();
            screenPause.parentControl = this;
            screenSaveAndLoad.parentControl = this;
            screenSaveAndLoad.mode = Screen_SaveAndLoad.Mode.Save;
            screenSaveAndLoad.Setup();

            Controls.Add(screenPause);
            Controls.Add(screenSaveAndLoad);

            screenPause.BringToFront();
            screenSaveAndLoad.BringToFront();

            screenPause.Visible = false;
            screenSaveAndLoad.Visible = false;
        }

        public void StartGame()
        {
            screenPause.Visible = false;
            screenSaveAndLoad.Visible = false;
            GameDataManager.Reset();
            GameDataManager.player.ToCenterPoint(REAL_SCREEN_WIDTH / 2, REAL_SCREEN_HEIGHT - 200);
            label_Difficulty.Text = $"Difficulty: {GameDataManager.GetDifficultyStr}";
            _timer.Start();
        }

        public void StopGame()
        {
            _timer.Stop();
            _timer.Dispose();
            parentForm.GameScreen_ToConclusion();
        }

        public void BackToMenu()
        {
            _timer.Stop();
            _timer.Dispose();
            parentForm.GameScreen_ToMainMenu();
        }

        public void OpenSave()
        {
            screenSaveAndLoad.Visible = true;
        }

        void TimerOnTick(object obj, EventArgs e)
        {
            //System.Windows.Forms.Control a = this.Parent;
            //this.Parent.Size = new Size(REAL_SCREEN_WIDTH, REAL_SCREEN_HEIGHT);
            //this.ParentForm.Size = new Size(REAL_SCREEN_WIDTH + 20, REAL_SCREEN_HEIGHT + 20);
            //this.Size = this.Parent.Size;
            if (GameDataManager.isPaused)
            {
                return;
            }

            Input.GetKeyStates();

            if (GameDataManager.triggeredScreenshot)
            {
                GameDataManager.RequestScreenshot(this);
            }

            if (GameDataManager.triggeredPause)
            {
                GameDataManager.triggeredPause = false;
                GameDataManager.isPaused = true;
                screenPause.Visible = true;
                return;
            }

            Game_Update();
            Entity_Kill_Process();
            Update_GUI();
            Refresh();
        }

        private void Screen_Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Draw_Background(g);

            foreach (Game_Object obj in GameDataManager.AllDrawableObjects)
            {
                obj?.Draw_Sprite(g);
            }
        }

        #region GameProcessor

        private void Game_Update()
        {
            FPS_Update();
            GameDataManager.cursorPosition = PointToClient(Cursor.Position);
            Debug.Print(Cursor.Position.ToString());
            GameDataManager.Update();
            Game_Player player = GameDataManager.player;
            player?.Update();

            foreach (Game_Bullet obj in GameDataManager.bullets.ToList())
            {
                obj.Update();
            }

            foreach (Game_Enemy obj in GameDataManager.enemies.ToList())
            {
                obj.Update();
            }
        
            foreach (Game_Animation obj in GameDataManager.animations.ToList())
            {
                obj.Update_Data();
            }

            if (GameDataManager.StopGame)
            {
                StopGame();
            }
        }

        void Entity_Kill_Process()
        {
            //List<Game_Enemy> died_enemies = new List<Game_Enemy>();
            //List<Game_Bullet> died_bullets = new List<Game_Bullet>();

            foreach (Game_Enemy obj in GameDataManager.enemies.GetRange(0, GameDataManager.enemies.Count).Where(x => x.die))
            {
                //died_enemies.Add(obj);
                obj.Process_BeforeDie();
            }
            foreach (Game_Bullet obj in GameDataManager.bullets.GetRange(0, GameDataManager.bullets.Count).Where(x => x.die))
            {
                //died_bullets.Add(obj);
                obj.Process_BeforeDie();
            }
            if (GameDataManager.player != null && GameDataManager.player.die)
            {
                GameDataManager.player.Process_BeforeDie();
                GameDataManager.player = null;
            }
            GameDataManager.enemies.RemoveAll(obj => obj.die);
            GameDataManager.bullets.RemoveAll(obj => obj.die);
            GameDataManager.animations.RemoveAll(obj => obj.die);
        }

        void Draw_Background(Graphics g)
        {
            if (background.Width != (int)g.ClipBounds.Width && Math.Abs(background.Width - g.ClipBounds.Width) < 2000)
            {
                background = new Bitmap(Space_Shooter.Properties.Resources.Background, (int)g.ClipBounds.Width, (int)g.ClipBounds.Width);
            }
            if (scrollY < background.Height)
            {
                scrollY++;
            }
            else
            {
                scrollY = 1;
            }
            
            g.DrawImage(background, 0, 0, new Rectangle(0, background.Height - scrollY - 1, background.Width, scrollY), GraphicsUnit.Pixel);
            if (scrollY < Height)
                g.DrawImage(background, 0, scrollY, new Rectangle(0, 0, background.Width, background.Height - scrollY), GraphicsUnit.Pixel);
        }

        void Update_GUI()
        {
            Game_Player player = GameDataManager.player;
            if (player != null)
            {
                valueBar_HP.Maximum = player.MaxHP;
                valueBar_HP.Value = player.HP;
                valueBar_Ammo.Maximum = player.MaxAmmo;
                valueBar_Ammo.Value = player.Ammo;
                valueBar_Ammo.ForeColor = player.WepPrimaryColor;
                valueBar_Ammo.BackColor = player.WepSecondaryColor;
            }
            else
            {
                valueBar_HP.Maximum = 1;
                valueBar_HP.Value = 0;
                valueBar_Ammo.Maximum = 1;
                valueBar_Ammo.Value = 0;
            }

            if (GameDataManager.GameOverTimeRemain > 0)
            {
                labelMessage.Text = GameDataManager.NotePlayerDie;
            }
            else if (GameDataManager.NoteStageEndTimeRemain > 0)
            {
                labelMessage.Text = GameDataManager.NoteStageEnd;
            }
            else if (GameDataManager.NoteStageStartTimeRemain > 0)
            {
                labelMessage.Text = GameDataManager.NoteStageStart;
            }
            else
            {
                labelMessage.Text = "";
            }
            labelScore.Text = GameDataManager.score.ToString();
            label_Playtime.Text = $"Play time: {GameDataManager.PlayTimeStr}";
            label_screenshot.Text = GameDataManager.screenshotText;
        }

        #endregion

        #region FPS Caculator methods
        
        private void FPS_Update()
        {
            _framesRendered++;

            if ((DateTime.Now - _lastTime).TotalSeconds >= 1)
            {
                // one second has elapsed 

                _fps = _framesRendered;
                _framesRendered = 0;
                _lastTime = DateTime.Now;
            }
            label_FPS.Text = _fps.ToString() + " fps";
        }

        #endregion

        private void Screen_Game_MouseDown(object sender, MouseEventArgs e)
        {
            Input.IsMouseDown = true;
        }

        private void Screen_Game_MouseUp(object sender, MouseEventArgs e)
        {
            Input.IsMouseDown = false;
        }
    }
}
