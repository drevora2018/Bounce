using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    class SlowDownBox : Obstacle
    {
        public SlowDownBox(int x, int y, int width, int height)
        {
            posX = x;
            posY = y;
            Width = width;
            Height = height;
        }

        public override void Draw(Pen pen, PaintEventArgs e)
        {
            pen.Color = Color.Blue; 
            var rect = new Rectangle(posX, posY, Width, Height);
            e.Graphics.DrawRectangle(pen, rect);
        }

        public override void IsCollided(Obstacle obstacles, Ball ball)
        {
            if (col.DrawHitBoxAndCalculateCol(obstacles, ball) == true)
            {
                ball.Speed.Y *= 0.98f;
                ball.Speed.X *= 0.98f;
            }
        }
    }
}
