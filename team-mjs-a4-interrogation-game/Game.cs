// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Vector2 playerPosition = new Vector2(400, 200);
        float playerRadius = 25;

        public void Setup()
        {
            Window.SetSize(800, 800);
            Window.SetTitle("Interrogation Game");
            Window.TargetFPS = 60;
        }

        public void Update()
        {
            Window.ClearBackground(Color.Green);
            Player();
            Text.Draw("jordan and monty are goated", 10, 10);

        }

        public void Player()
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

            // Collision
            if (playerPosition.Y - playerRadius < 0)
            {
                playerPosition.Y = 25;
            }
            if (playerPosition.Y + playerRadius > 800)
            {
                playerPosition.Y = 775;
            }
            if (playerPosition.X - playerRadius < 0)
            {
                playerPosition.X = 25;
            }
            if (playerPosition.X + playerRadius > 800)
            {
                playerPosition.X = 775;
            }
        }
    }
}
             