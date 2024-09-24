using System;
using System.Drawing;

namespace Bounce
{
	public class Ball
	{
		// all balls use the same color and can share the same pen
		static Pen Pen = new Pen(Color.Cyan);

		Position Position;
		public Vector Speed;

		public float Radius;

		static Random Random = new Random();

		public Ball(float x, float y, float radius)
		{
			Position = new Position(x,y);
			var xd = Random.Next(1, 6);
			var yd = Random.Next(1, 6);
			if (Random.Next(0, 2) == 0) xd = -xd;
			if (Random.Next(0, 2) == 0) yd = -yd;

			Speed = new Vector(xd,yd);
			Radius = radius;
		}

		public void Draw(Graphics g)
		{
			g.DrawEllipse(Pen,Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
		}

		public void Move()
		{
			Position.X += Speed.X;
			Position.Y += Speed.Y;
		}

        public Position GetPosition()
        {
			return Position;
        }

        public Vector GetVector()
        {
			return Speed;
        }

    }
}
