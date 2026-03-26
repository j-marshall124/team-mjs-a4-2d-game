using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Player
    {
        public Vector2 playerPosition = new Vector2(400, 200);
        public float playerRadius = 25;
        public float detectRadius = 50;

        public void PlayerMove()
        {
            // Setup
            Draw.FillColor = Color.LightGray;
            Draw.Circle(playerPosition, playerRadius);

            // Movement
            if (Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                playerPosition.X -= 5;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                playerPosition.X += 5;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                playerPosition.Y -= 5;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                playerPosition.Y += 5;
            }

            // Window Collision
            if (playerPosition.Y - playerRadius < 0)
            {
                playerPosition.Y = 25;
            }
            if (playerPosition.Y + playerRadius > 750)
            {
                playerPosition.Y = 725;
            }
            if (playerPosition.X - playerRadius < 0)
            {
                playerPosition.X = 25;
            }
            if (playerPosition.X + playerRadius > 1250)
            {
                playerPosition.X = 1225;
            }
        }
    }

}
