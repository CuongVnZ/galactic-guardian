using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    class BeamBullet : Bullet
    {
        public BeamBullet(GameObject gameObject) : base(gameObject) { }

        public override void CreateObject()
        {
            Image = Properties.Resources.beamBullet;
            base.CreateObject();
        }
    }
}
