using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_Guardian
{
    public class GameObject : PictureBox
    {
        public Form GameScreen { get; set; }

        public GameObject(Form gameScreen)
        {
            GameScreen = gameScreen;
        }

    }
}
