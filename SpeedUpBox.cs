using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    class SpeedUpBox : Obstacle
    {
        public SpeedUpBox(int x, int y, int width, int height)
        {
            posX = x;
            posY = y;
            Width = width;
            Height = height;
        }

        public override void Draw(Pen pen, PaintEventArgs e)
        {
            pen.Color = Color.Red;
            var rect = new Rectangle(posX, posY, Width, Height);
            e.Graphics.DrawRectangle(pen, rect);
        }

        public override void IsCollided(Obstacle obstacles, Ball ball)
        {
            if (col.DrawHitBoxAndCalculateCol(obstacles, ball) == true)
            {
                ball.Speed.X *= 1.1f;
                ball.Speed.Y *= 1.1f;   
            }
        }

    }
}
