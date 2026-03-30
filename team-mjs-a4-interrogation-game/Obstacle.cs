using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Obstacle
    {
        public Vector2 squarePos = new Vector2(500, 600);
        public float squareSize = 50;
        public float collisionRadius = 60;

        public void Collectable()
        {
            Draw.Square(squarePos, squareSize);
        }

    }
}
