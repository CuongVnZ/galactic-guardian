using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Galactic_Guardian
{
    public abstract class Bullet : GameObject, IObject
    {
        public Direction Direction { get; set; }
        public int Speed { get; set; } = 20;
        public int Damage { get; set; } = 10;

        public System.Windows.Forms.Timer BulletTimer { get; set; } = new System.Windows.Forms.Timer();

        public Bullet(GameObject gameObject) : base(gameObject.GameScreen)
        {
            Left = gameObject.Left + gameObject.Width / 2;
            Top = gameObject.Top + gameObject.Height / 2;
        }

        public virtual void CreateObject()
        {
            BackColor = Color.Transparent;
            BringToFront();

            GameScreen.Controls.Add(this);

            BulletTimer.Interval = Speed;
            BulletTimer.Tick += new EventHandler(BulletTick);
            BulletTimer.Start();
        }

        private void BulletTick(object sender, EventArgs e)
        {
            if (Direction == Direction.LEFT) Left -= Speed;
            if (Direction == Direction.RIGHT) Left += Speed;
            if (Direction == Direction.UP) Top -= Speed;
            if (Direction == Direction.DOWN) Top += Speed;

            if (
                Right < 0
                || Left > 1000
                || Top > 999
                || Bottom < 0)
            {
                GameScreen.Controls.Remove(this);

                BulletTimer.Stop();
                BulletTimer.Dispose();
                BulletTimer = null;
                
                Dispose();
            }
        }
    }
}
