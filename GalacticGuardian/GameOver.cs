using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Galactic_Guardian
{
    public partial class GameOver : Form
    {

        private int FinalScore { get; set; }
        private string PlayerName { get; set; }

        public GameOver(Player p)
        {
            InitializeComponent();
            FinalScore = p.Score;
            PlayerName = p.DisplayName;
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.MainMenu.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.quitButton);
            soundPlayer.Play();
            System.Threading.Thread.Sleep(1000);
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + FinalScore;
            labelPlayer.Text = "Player: " + PlayerName;


            string filePath = "scores.txt";
            string playerName = PlayerName;
            int currentScore = FinalScore;

            // create a dictionary to store the scores
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // check if the file exists
            if (File.Exists(filePath))
            {
                // read the scores from the file
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int score = int.Parse(parts[1]);
                    scores[name] = score;
                }
            }

            // check if the player already has a score
            if (scores.ContainsKey(playerName))
            {
                // compare the current score to the player's highest score
                int highScore = scores[playerName];
                if (currentScore > highScore)
                {
                    // update the player's score
                    scores[playerName] = currentScore;
                }
            }
            else
            {
                // add the player's score to the dictionary
                scores[playerName] = currentScore;
            }

            // write the scores to the file
            List<string> linesToWrite = new List<string>();
            foreach (KeyValuePair<string, int> score in scores)
            {
                linesToWrite.Add(score.Key + "," + score.Value.ToString());
            }
            File.WriteAllLines(filePath, linesToWrite.ToArray());

        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainMenu.Close();
        }
    }
}
