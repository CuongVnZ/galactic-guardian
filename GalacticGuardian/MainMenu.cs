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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public SoundPlayer SoundPlayer { get; set; }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            SoundPlayer = new SoundPlayer(Properties.Resources.quitButton);
            SoundPlayer.Play();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Show new dialog ask for player name input
            string playerName = "";
            while (string.IsNullOrEmpty(playerName))
            {
                playerName = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Player Name", "");
            }

            Program.GameScreen = new GalacticGuardian(playerName);
            SoundPlayer = new SoundPlayer(Properties.Resources.start);

            SoundPlayer.Play();
            Program.GameScreen.Show();
            this.Hide();
        }

        private void instructions_button_click(object sender, EventArgs e)
        {
            Program.Instruction.ShowDialog();
        }

        private void topScoreButton_click(object sender, EventArgs e)
        {
            Program.Ranking.ShowDialog();
        }
    }
}
