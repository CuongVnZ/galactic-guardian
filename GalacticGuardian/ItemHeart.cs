using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    class ItemHeart : Item
    {
        public ItemHeart(Form gameScreen) : base(gameScreen) { }

        public override void CreateObject()
        {
            Image = Properties.Resources.heart;
            base.CreateObject();
        }

        public override void AddEffect(Player p)
        {
            p.Health = Math.Min(p.Health + 20, 100);
        }
    }
}
