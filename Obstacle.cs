using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    abstract class Obstacle : ICollideable
    {
        internal int posX, posY, Width, Height;
        internal CollisionDetector col = new CollisionDetector();

        public abstract void Draw(Pen pen, PaintEventArgs e);
        public abstract void IsCollided(Obstacle obstacles, Ball ball);
        
    }
}
