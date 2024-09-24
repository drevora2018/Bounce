using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    interface ICollideable
    {
        void IsCollided(Obstacle obstacles, Ball ball);
        void Draw(Pen pen, PaintEventArgs e);
    }
}
