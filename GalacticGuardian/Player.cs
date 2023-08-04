using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    public class Player : GameObject
    {
        public int Health { get; set; }
        public int Score { get; set; }
        public int Speed { get; set; }

        public string DisplayName { get; set; }

        public Direction PlayerDirection { get; set; }

        public Player(Form gameScreen, string name) : base(gameScreen)
        {
            Health = 100;
            Speed = 10;
            Score = 0;
            PlayerDirection = Direction.UP;
            DisplayName = name;

            BackColor = Color.Transparent;
            Image = Properties.Resources.shipUp;
            Location = new Point(449, 728);
            Name = "playerObject";
            Size = new Size(99, 75);
            SizeMode = PictureBoxSizeMode.AutoSize;
            TabIndex = 3;
            TabStop = false;

            GameScreen.Controls.Add(this);
            BringToFront();
        }

        public void ShootLazer()
        {
            Bullet lazer = new LazerBlue(this);
            lazer.Direction = PlayerDirection;
            lazer.Left = Left + (Width / 2);
            lazer.Top = Top + (Height / 2);
            lazer.CreateObject();
        }

    }
}
