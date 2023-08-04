using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Galactic_Guardian
{
    class UfoRed : Enemy
    {
        public UfoRed(Form gameScreen) : base(gameScreen) { }

        public override void CreateObject()
        {
            base.CreateObject();
            Image = Properties.Resources.ufoRed;
        }

        public override void ShootTick(object sender, EventArgs e)
        {
            BulletUp = new LazerRed(this);
            BulletDown = new LazerRed(this);
            BulletLeft = new LazerRed(this);
            BulletRight = new LazerRed(this);
            base.ShootTick(sender, e);
        }
    }
}
