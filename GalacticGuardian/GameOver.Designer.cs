namespace Galactic_Guardian
{
    partial class GameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonMainMenu = new Button();
            buttonQuit = new Button();
            labelTitle = new Label();
            labelScore = new Label();
            labelPlayer = new Label();
            SuspendLayout();
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.BackColor = Color.Black;
            buttonMainMenu.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMainMenu.ForeColor = Color.White;
            buttonMainMenu.Location = new Point(716, 843);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(215, 59);
            buttonMainMenu.TabIndex = 5;
            buttonMainMenu.Text = "Return Menu";
            buttonMainMenu.UseVisualStyleBackColor = false;
            buttonMainMenu.Click += buttonMainMenu_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.BackColor = Color.Black;
            buttonQuit.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuit.ForeColor = Color.White;
            buttonQuit.Location = new Point(54, 843);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(211, 59);
            buttonQuit.TabIndex = 4;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Fira Code Medium", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(57, 89);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(892, 99);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Galactic Guardian";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Fira Code", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(675, 325);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(186, 41);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score: X";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.BackColor = Color.Transparent;
            labelPlayer.Font = new Font("Fira Code", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayer.ForeColor = Color.White;
            labelPlayer.Location = new Point(80, 325);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(207, 41);
            labelPlayer.TabIndex = 7;
            labelPlayer.Text = "Player: X";
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.game_bg;
            ClientSize = new Size(982, 952);
            Controls.Add(labelPlayer);
            Controls.Add(labelScore);
            Controls.Add(buttonMainMenu);
            Controls.Add(buttonQuit);
            Controls.Add(labelTitle);
            Name = "GameOver";
            ShowIcon = false;
            Text = "GameOver";
            FormClosing += GameOver_FormClosing;
            Load += GameOver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenu;
        private Button buttonQuit;
        private Label labelTitle;
        private Label labelScore;
        private Label labelPlayer;
    }
}