namespace Galactic_Guardian
{
    partial class GalacticGuardian
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
            components = new System.ComponentModel.Container();
            labelScore = new Label();
            labelHealth = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Fira Code", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(663, 879);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(151, 33);
            labelScore.TabIndex = 0;
            labelScore.Text = "SCORE: 0";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.BackColor = Color.Transparent;
            labelHealth.Font = new Font("Fira Code", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelHealth.ForeColor = Color.White;
            labelHealth.Location = new Point(850, 879);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(117, 33);
            labelHealth.TabIndex = 1;
            labelHealth.Text = "HEALTH";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(669, 911);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(288, 29);
            healthBar.TabIndex = 2;
            healthBar.Value = 100;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.shipUp;
            player.Location = new Point(449, 728);
            player.Name = "player";
            player.Size = new Size(100, 91);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 3;
            player.TabStop = false;
            player.Tag = "player";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += GameTick;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.BackColor = Color.Transparent;
            playerLabel.Font = new Font("Fira Code", 16F, FontStyle.Regular, GraphicsUnit.Point);
            playerLabel.ForeColor = Color.White;
            playerLabel.Location = new Point(14, 904);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(134, 33);
            playerLabel.TabIndex = 4;
            playerLabel.Text = "Player:";
            // 
            // GalacticGuardian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Black;
            ClientSize = new Size(982, 952);
            Controls.Add(playerLabel);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(labelHealth);
            Controls.Add(labelScore);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GalacticGuardian";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galactic Guardian";
            FormClosing += GalacticGuardian_FormClosing;
            Load += GalacticGuardian_Load;
            KeyDown += IsKeyDown;
            KeyUp += IsKeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelScore;
        private Label labelHealth;
        private ProgressBar healthBar;
        private System.Windows.Forms.Timer timer;
        public PictureBox player;
        private Label playerLabel;
    }
}