namespace Galactic_Guardian
{
    partial class MainMenu
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
            labelTitle = new Label();
            buttonQuit = new Button();
            buttonStart = new Button();
            topScoreButton = new Button();
            instructions_button = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Fira Code Medium", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(46, 81);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(892, 99);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Galactic Guardian";
            // 
            // buttonQuit
            // 
            buttonQuit.BackColor = Color.Black;
            buttonQuit.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuit.ForeColor = Color.White;
            buttonQuit.Location = new Point(299, 637);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(392, 59);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Black;
            buttonStart.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(299, 315);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(392, 59);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // topScoreButton
            // 
            topScoreButton.BackColor = Color.Black;
            topScoreButton.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            topScoreButton.ForeColor = Color.White;
            topScoreButton.Location = new Point(299, 557);
            topScoreButton.Name = "topScoreButton";
            topScoreButton.Size = new Size(392, 59);
            topScoreButton.TabIndex = 3;
            topScoreButton.Text = "Top score";
            topScoreButton.UseVisualStyleBackColor = false;
            topScoreButton.Click += topScoreButton_click;
            // 
            // instructions_button
            // 
            instructions_button.BackColor = Color.Black;
            instructions_button.Font = new Font("Fira Code", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            instructions_button.ForeColor = Color.White;
            instructions_button.Location = new Point(299, 472);
            instructions_button.Name = "instructions_button";
            instructions_button.Size = new Size(392, 59);
            instructions_button.TabIndex = 4;
            instructions_button.Text = "Instruction";
            instructions_button.UseVisualStyleBackColor = false;
            instructions_button.Click += instructions_button_click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.menu_background;
            ClientSize = new Size(982, 763);
            Controls.Add(instructions_button);
            Controls.Add(topScoreButton);
            Controls.Add(buttonStart);
            Controls.Add(buttonQuit);
            Controls.Add(labelTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galactic Guardian";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonQuit;
        private Button buttonStart;
        private Button topScoreButton;
        private Button instructions_button;
    }
}