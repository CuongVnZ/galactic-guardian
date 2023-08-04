using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    public abstract class Item : GameObject, IObject
    {
        public Item(Form gameScreen) : base(gameScreen) { }
        
        public virtual void CreateObject()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            GameScreen.Controls.Add(this);
            BringToFront();
        }

        public abstract void AddEffect(Player p);
    }
}
