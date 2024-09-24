using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bounce
{
    public class Engine
    {
        MainForm Form = new MainForm();
        Timer Timer = new Timer();
        List<Ball> Balls = new List<Ball>();
        Random Random = new Random();
        Obstacle[] obstacles1 = new Obstacle[] 
        {   new VerticalLine(500, 20, 300),
            new SpeedUpBox(50, 100, 100, 100),
            new SlowDownBox(50, 400, 400, 20), 
            new HorizontalLine(150, 20, 300),
            new VerticalLine(0, 100, 300),
            new HorizontalLine(100, 500, 400)
        };

        public void Run()
        {
            Form.BackColor = Color.Black;
            Form.Height = 600;
            Form.Width = 600;
            Form.Paint += Draw;
            Timer.Tick += TimerEventHandler;
            Timer.Interval = 1000 / 25;
            Timer.Start();

            Application.Run(Form);
        }

        void TimerEventHandler(Object obj, EventArgs args)
        {
            if (Random.Next(100) < 25)
            {
                var ball = new Ball(300, 300, 10);
                Balls.Add(ball);
            }

            foreach (var ball in Balls)
            {
                ball.Move();
                foreach (var x in obstacles1)
                {
                    x.IsCollided(x, ball);
                }
            }
            Form.Refresh();
        }

        void Draw(Object obj, PaintEventArgs args)
        {
            foreach (var ball in Balls)
            {
                ball.Draw(args.Graphics);
            }
            DrawField(args);
        }

        void DrawField(PaintEventArgs e)
        {
            foreach(var Obstacle in obstacles1)
            {
                Obstacle.Draw(new Pen(Color.Red), e);
            }
        } 
    }
}
