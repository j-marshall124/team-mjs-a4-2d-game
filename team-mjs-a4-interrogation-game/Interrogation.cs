using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Interrogation
    {
        Scene scenes;
        Vector2 yesCircle = new Vector2(200, 200);
        float radius = 50;
        Vector2 noCircle = new Vector2(1080, 200);

        public Interrogation(Scene scenes)
        {
            this.scenes = scenes;
        }

        // INTRO SCENE //
        public void Intro()
        {
            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Question
            Text.Color = Color.White;
            Text.Draw("Good afternoon, Jordan..\n" +
                "I'm Monty, a detective with Hamilton Police.\n" +
                "I've brought you in for questioning about a crime \n" +
                "that was commited two weeks ago \n" +
                "on the night of March 12, 2026", 220, 520);
            
            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                scenes.showIntroScene = false;
                scenes.showQuestion1  = true;
            }
        }
        
        // QUESTION 1 //
        public void Question1()                    
        {
            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you do the crime?", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 1065, 185);
            
            // Checks if mouse is inside the left option button
            if (Input.GetMouseX() >= yesCircle.X - radius && Input.GetMouseX() <= yesCircle.X + radius
                && Input.GetMouseY() >= yesCircle.Y - radius && Input.GetMouseY() <= yesCircle.Y + radius)
            {
                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    scenes.showQuestion1 = false;
                    scenes.showInterrogationYes = true;
                }
            }

            // Checks if mouse is inside the right option button
            if (Input.GetMouseX() >= noCircle.X - radius && Input.GetMouseX() <= noCircle.X + radius
                && Input.GetMouseY() >= noCircle.Y - radius && Input.GetMouseY() <= noCircle.Y + radius)
            {
                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    scenes.showQuestion1 = false;
                    scenes.showInterrogationNo = true;
                }
            }
        }

        public void InterrogationYes()
        {
            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Questions
            Text.Color = Color.White;
            Text.Draw("I can't believe this. GAME OVER.", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 1065, 185);
        }

        public void InterrogationNo()
        {
            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Questions
            Text.Color = Color.White;
            Text.Draw("I knew it wasn't you. YOU WIN.", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 1065, 185);
        }
    }
}
