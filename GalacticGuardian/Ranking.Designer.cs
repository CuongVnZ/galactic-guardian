namespace Galactic_Guardian
{
    partial class Ranking
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
            topScoreLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // topScoreLabel
            // 
            topScoreLabel.AutoSize = true;
            topScoreLabel.BackColor = Color.Transparent;
            topScoreLabel.Font = new Font("Fira Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            topScoreLabel.ForeColor = Color.White;
            topScoreLabel.Location = new Point(30, 159);
            topScoreLabel.Name = "topScoreLabel";
            topScoreLabel.Size = new Size(103, 29);
            topScoreLabel.TabIndex = 0;
            topScoreLabel.Text = "label1";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Fira Code", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(95, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(312, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Top 10 scorers";
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.game_bg;
            ClientSize = new Size(465, 589);
            Controls.Add(titleLabel);
            Controls.Add(topScoreLabel);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(483, 636);
            MinimumSize = new Size(483, 636);
            Name = "Ranking";
            ShowIcon = false;
            Text = "Ranking";
            Load += Ranking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topScoreLabel;
        private Label titleLabel;
    }
}