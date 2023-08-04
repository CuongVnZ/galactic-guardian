using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    class LazerRed : Bullet
    {
        public LazerRed(GameObject gameObject) : base(gameObject) { }

        public override void CreateObject()
        {
            if (Direction == Direction.LEFT) Image = Properties.Resources.redLazerLeft;
            if (Direction == Direction.RIGHT) Image = Properties.Resources.redLazerRight;
            if (Direction == Direction.UP) Image = Properties.Resources.redLazerUp;
            if (Direction == Direction.DOWN) Image = Properties.Resources.redLazerDown;

            base.CreateObject();
        }
    }
}
