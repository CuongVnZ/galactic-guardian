using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    class LazerBlue : Bullet
    {
        public LazerBlue(GameObject gameObject) : base(gameObject) { }

        public override void CreateObject()
        {
            if (Direction == Direction.LEFT) Image = Properties.Resources.playerLazerLeft;
            if (Direction == Direction.RIGHT) Image = Properties.Resources.playerLazerRight;
            if (Direction == Direction.UP) Image = Properties.Resources.playerLazerUp;
            if (Direction == Direction.DOWN) Image = Properties.Resources.playerLazerDown;
            base.CreateObject();
        }
    }
}
