using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Galactic_Guardian
{
    public class Spawner
    {
        public GalacticGuardian GameScreen { get; set; }

        public Random RandomNum { get; set; }

        public Timer SpawnTimer { get; set; }

        private Item item;
        private Enemy enemy;
        
        public Spawner(GalacticGuardian game)
        {
            GameScreen = game;

            RandomNum = new Random();

            SpawnTimer = new Timer();
            SpawnTimer.Interval = 1000;
            SpawnTimer.Tick += new EventHandler(SpawnTick);
            SpawnTimer.Start();
        }

        private void SpawnTick(object sender, EventArgs e)
        {
            if (RandomNum.Next(0, 1000) < 200) SpawnItem(1);
            if (RandomNum.Next(0, 1000) > 800) SpawnItem(2); 
            if (RandomNum.Next(0, 700) < 250) SpawnEnemy(1); 
            if (RandomNum.Next(0, 700) > 450) SpawnEnemy(2); 
        }

        private void SpawnEnemy(int x)
        {
            if (x == 1)
                enemy = new UfoRed(GameScreen);
            else
                enemy = new UfoGreen(GameScreen);

            enemy.CreateObject();
        }
        
        private void SpawnItem(int x)
        {
            if (x == 1)  item = new ItemHeart(GameScreen);
            else item = new ItemMeteorite(GameScreen);

            // * 2 to make sure that it will not be located on HUD or outside of the screenƯ
            item.Left = RandomNum.Next(20, GameScreen.ClientSize.Width - item.Width * 2);
            item.Top = RandomNum.Next(20, GameScreen.ClientSize.Height - item.Height * 2);

            item.CreateObject();
        }

    }
}
