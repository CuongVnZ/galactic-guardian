using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    public class EnemyController
    {
        private GalacticGuardian GameScreen { get; set; }
        private System.Windows.Forms.Timer Timer { get; set; } = new System.Windows.Forms.Timer();

        private int EnemySpeed { get; set; } = 1;

        public EnemyController(GalacticGuardian game)
        {
            GameScreen = game;

            Timer.Interval = 15000;
            Timer.Start();
            Timer.Tick += new EventHandler(GameTick);
        }

        public void MoveEnemy()
        {
            foreach(Control x in GameScreen.Controls)
            {
                // UFOs catch the player
                if(x is Enemy)
                {
                    Enemy enemy = (Enemy)x;
                    if (enemy.Left > GameScreen.Player.Left) enemy.Left -= EnemySpeed; 
                    if (enemy.Left < GameScreen.Player.Left) enemy.Left += EnemySpeed; 
                    if (enemy.Top > GameScreen.Player.Top) enemy.Top -= EnemySpeed; 
                    if (enemy.Top < GameScreen.Player.Top) enemy.Top += EnemySpeed; 
                }
            }
        }
        
        private void GameTick(object sender, EventArgs e)
        {
            EnemySpeed++;
        }
    }
}
