using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    class HorizontalLine : Obstacle
    {
        public HorizontalLine(int x, int y, int width)
        {
            posX = x;
            posY = y;
            Width = width;
            Height = 1;
        }

        public override void Draw(Pen pen, PaintEventArgs e)
        {
            pen.Color = Color.Green;
            var rect = new Rectangle(posX, posY, Width, Height);
            e.Graphics.DrawRectangle(pen, rect);
        }

        public override void IsCollided(Obstacle obstacles, Ball ball)
        {
            if (col.DrawHitBoxAndCalculateCol(obstacles, ball) == true)
            {
                ball.Speed.Y *= -1f;
            }
        }

    }
}
