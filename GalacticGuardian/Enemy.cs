using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    public abstract class Enemy : GameObject, IObject
    {

        public System.Windows.Forms.Timer ShootTimer { get; } = new System.Windows.Forms.Timer();
        public Random RandomNum { get; } = new Random();

        public Bullet BulletUp { get; set; }
        public Bullet BulletDown { get; set; }
        public Bullet BulletLeft { get; set; }
        public Bullet BulletRight { get; set; }

        public Enemy(Form gameScreen) : base(gameScreen) { }

        public virtual void CreateObject()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            Left = RandomNum.Next(-100, 1100);
            Top = RandomNum.Next(-100, 0);
            BringToFront();

            GameScreen.Controls.Add(this);

            ShootTimer.Interval = 1500;
            ShootTimer.Tick += new EventHandler(ShootTick);
            ShootTimer.Start();
        }

        public virtual void ShootTick(object sender, EventArgs e)
        {
            if (!GameScreen.Controls.Contains(this))
            {
                ShootTimer.Stop();
                Dispose();
            }
            else
            {
                BulletLeft.Direction = Direction.LEFT;
                BulletLeft.CreateObject();

                BulletRight.Direction = Direction.RIGHT;
                BulletRight.CreateObject();

                BulletUp.Direction = Direction.UP;
                BulletUp.CreateObject();

                BulletDown.Direction = Direction.DOWN;
                BulletDown.CreateObject();
            }
        }

    }
}
