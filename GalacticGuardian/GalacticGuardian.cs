using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic_Guardian
{
    public partial class GalacticGuardian : Form
    {

        public Spawner Spawner { get; }
        public SoundPlayer SoundPlayer { get; set; }

        public Player Player { get; set; }
        private bool _moveL, _moveR, _moveU, _moveD;

        private CollisionController CollisionController { get; }
        private EnemyController EnemyController { get; }

        public bool IsGameOver { get; set; } = false;


        public GalacticGuardian(string playerName)
        {
            InitializeComponent();

            Player = new Player(this, playerName);


            Spawner = new Spawner(this);
            CollisionController = new CollisionController(this);
            EnemyController = new EnemyController(this);


            SoundPlayer = new SoundPlayer(Properties.Resources.shoot);

            playerLabel.Text = "Player: " + Player.DisplayName;
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveL = true;
                Player.PlayerDirection = Direction.LEFT;
                Player.Image = Properties.Resources.shipLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveR = true;
                Player.PlayerDirection = Direction.RIGHT;
                Player.Image = Properties.Resources.shipRight;
            }
            if (e.KeyCode == Keys.Up)
            {
                _moveU = true;
                Player.PlayerDirection = Direction.UP;
                Player.Image = Properties.Resources.shipUp;
            }
            if (e.KeyCode == Keys.Down)
            {
                _moveD = true;
                Player.PlayerDirection = Direction.DOWN;
                Player.Image = Properties.Resources.shipDown;
            }

            Player.BackColor = Color.Transparent;
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) _moveL = false;
            if (e.KeyCode == Keys.Right) _moveR = false;
            if (e.KeyCode == Keys.Up) _moveU = false;
            if (e.KeyCode == Keys.Down) _moveD = false;

            if (e.KeyCode == Keys.Space)
            {
                SoundPlayer.Play();
                Player.ShootLazer();
            }
        }

        private void GameTick(object sender, EventArgs e)
        {
            Player.BringToFront();
            CheckPlayerAlive();
            labelScore.Text = "SCORE: " + Player.Score;

            MovePlayer();

            CollisionController.CheckCollision();

            EnemyController.MoveEnemy();
        }

        private void MovePlayer()
        {
            if (_moveL && Player.Left > Player.Speed)
                Player.Left -= Player.Speed;
            if (_moveR && Player.Left + Player.Width <= ClientSize.Width - Player.Speed)
                Player.Left += Player.Speed;
            if (_moveU && Player.Top > Player.Speed)
                Player.Top -= Player.Speed;
            if (_moveD && Player.Top + Player.Height < ClientSize.Height - Player.Speed - 110)
                Player.Top += Player.Speed;
        }

        private void CheckPlayerAlive()
        {
            if (Player.Health > 1) healthBar.Value = Player.Health;
            else
            {
                timer.Stop();
                Program.GameOver = new GameOver(Player);
                Program.GameOver.Show();

                IsGameOver = true;

                Close();
            }
        }

        private void GalacticGuardian_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsGameOver) Program.MainMenu.Close();
        }

        private void GalacticGuardian_Load(object sender, EventArgs e)
        {
            player.Dispose();
        }
    }
}
