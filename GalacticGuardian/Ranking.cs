using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic_Guardian
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void UpdateTopScoresLabel()
        {
            string filePath = "scores.txt"; // change this to the path of your data file

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

            // get the top 10 scores
            var topScores = scores.OrderByDescending(x => x.Value).Take(10);

            // create a string to display the scores
            string scoreString = "";
            int rank = 1;
            foreach (var score in topScores)
            {
                scoreString += rank + ". " + score.Key + ": " + score.Value + "\n";
                rank++;
            }

            // update the label
            topScoreLabel.Text = scoreString;
        }


        private void Ranking_Load(object sender, EventArgs e)
        {
            UpdateTopScoresLabel();
        }
    }
}
