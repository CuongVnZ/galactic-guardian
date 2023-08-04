using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Galactic_Guardian
{
    public class CollisionController
    {
        public GalacticGuardian GameScreen { get; set; }
        
        public CollisionController(GalacticGuardian game)
        {
            GameScreen = game;
        }
        
        public void CheckCollision()
        {
            foreach (Control x in GameScreen.Controls)
            {
                if (x is Item) ItemHit((Item) x);

                foreach (Control y in GameScreen.Controls)
                {
                    if (y is LazerBlue && x is Enemy) EnemyHit(x, y); 
                    else if (y is Player && (x is LazerRed || x is BeamBullet)) PlayerHit(x, y); 
                }
            }
        }

        public void ItemHit(Control x)
        {
            if (GameScreen.Player.Bounds.IntersectsWith(x.Bounds))
            {
                GameScreen.Controls.Remove(x);
                x.Dispose();
                Item item = (Item)x;
                item.AddEffect(GameScreen.Player);
            }
        }
        
        public void EnemyHit(Control x, Control y)
        {
            if (x.Bounds.IntersectsWith(y.Bounds))
            {
                GameScreen.Controls.Remove(x);
                x.Dispose();
                GameScreen.Controls.Remove(y);
                y.Dispose();

                GameScreen.Player.Score += 10;
            }
        }
        
        public void PlayerHit(Control lazer, Control player)
        {
            Player p = (Player)player;
            Bullet bullet = (Bullet) lazer;
            if (lazer.Bounds.IntersectsWith(p.Bounds))
            {
                GameScreen.Controls.Remove(lazer);
                bullet.Dispose();
                p.Health -= bullet.Damage;
            }
        }
    }
}
