using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Galactic_Guardian
{
    class UfoGreen : Enemy
    {
        public UfoGreen(Form gameScreen) : base(gameScreen) { }

        public override void CreateObject()
        {
            base.CreateObject();
            Image = Properties.Resources.ufoGreen;
        }

        public override void ShootTick(object sender, EventArgs e)
        {
            BulletUp = new BeamBullet(this);
            BulletDown = new BeamBullet(this);
            BulletLeft = new BeamBullet(this);
            BulletRight = new BeamBullet(this);
            base.ShootTick(sender, e);
        }
    }
}
