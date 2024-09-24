using System;

namespace Bounce
{

    class CollisionDetector
    {
        Position BallPosition;
        /*
         * This collision function is point/circle collision detector
         * This function draws the hitbox for each object (by getting the position, width and height of the obstacle)
         * while using the pythagoras theorem to calculate the hypothenuse of a triangle, and that hypothenuse is the distance between the ball and the object. 
         * we can then use if and else statements to check where on the box we're hitting (top edge, bottom edge, right or left side)
         * if we touch the box, the function returns the bool as true, and we can change the vectors of the ball to simulate collision.
         */
        public bool DrawHitBoxAndCalculateCol(Obstacle obstacle, Ball ball)
        {
            BallPosition = ball.GetPosition(); 

            var BallX = BallPosition.X;
            var BallY = BallPosition.Y;
            var TestXPos = BallX;
            var TestYPos = BallY;
            var ObstacleX = obstacle.posX;
            var ObstacleY = obstacle.posY;
            var ObstacleWidth = obstacle.Width;
            var ObstacleHeight = obstacle.Height;

            if (BallX < ObstacleX)
            {
                TestXPos = ObstacleX;
            }
            else if (BallX > ObstacleX + ObstacleWidth)
            {
                TestXPos = ObstacleX + ObstacleWidth;
            }
            if (BallY < ObstacleY)
            {
                TestYPos = ObstacleY;
            }
            else if (BallY > ObstacleY + ObstacleHeight)
            {
                TestYPos = ObstacleY + ObstacleHeight;
            }
            var distX = BallX - TestXPos; 
            var distY = BallY - TestYPos; 
            var Distance = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

            if (Distance <= ball.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
