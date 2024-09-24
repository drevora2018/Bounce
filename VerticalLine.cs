using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    class VerticalLine : Obstacle
    { 
        public VerticalLine(int x, int y, int height)
        {
            posX = x;
            posY = y;
            Width = 1;
            Height = height;
        }

        public override void Draw(Pen pen, PaintEventArgs e)
        {
            pen.Color = Color.Yellow;
            var rect = new Rectangle(posX, posY, Width, Height);
            e.Graphics.DrawRectangle(pen, rect);
        }

        public override void IsCollided(Obstacle obstacles, Ball ball)
        {
            if (col.DrawHitBoxAndCalculateCol(obstacles, ball) == true)
            {
                ball.Speed.X *= -1f; 
            }
        }
    }
}
