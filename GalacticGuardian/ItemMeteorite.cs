using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    class ItemMeteorite : Item
    {
        public ItemMeteorite(Form gameScreen) : base(gameScreen) { }

        public override void CreateObject()
        {
            Image = Properties.Resources.meteorite;
            base.CreateObject();
        }

        public override void AddEffect(Player p)
        {
            p.Health -= 10;
        }
    }
}
