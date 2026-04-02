using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Interrogation
    {
        // BOOL CHECKS TO CHANGE SCENES //
        public bool showMainMenu = true;
        public bool showIntroScene = false;
        public bool showQuestion1 = false;
        public bool showQuestion1Option1 = false;
        public bool showQuestion1Option2 = false;
        public bool showQuestion2 = false;
        public bool showQuestion2Front = false;
        public bool showQuestion2Back = false;
        public bool showQuestion2No = false;
        public bool showQuestion3No = false;
        public bool showQuestion3yes = false;
        public bool showQuestion4NoNeverPanicked = false;
        public bool showQuestion4NoNeverThere = false;
        public bool showQuestion4NoNeverCalled = false;

        public bool guilty = false;
        public bool notGuilty = false;

        // ASSETS VARIABLES //
        public Color bg = new Color(50, 50, 48);
        Texture2D textBox = Graphics.LoadTexture("../../../../assets/graphics/TextBox.png");
        Texture2D button = Graphics.LoadTexture("../../../../assets/graphics/Button.png");
        Texture2D buttonHover = Graphics.LoadTexture("../../../../assets/graphics/ButtonHover.png");

        Sound click = Audio.LoadSound("../../../../assets/audio/click.ogg");
        Sound hover = Audio.LoadSound("../../../../assets/audio/hover.ogg");


        // BUTTONS //
        Vector2[] buttonPositions = [
            new Vector2(1020, 445),
            new Vector2(1020, 545),
            new Vector2(1020, 645)
            ];
        float radius = 50;
        Vector2 noCircle = new Vector2(1080, 200);
        Vector2 yesCircle = new Vector2(1080, 200);

        // MAIN MENU //
        public void MainMenu()
        {            
            Text.Color = Color.White;
            Text.Draw("Two weeks later...", 480, 360);
            Text.Draw("Click to continue.", 480, 400);

            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showMainMenu = false;
                showIntroScene = true;
            }
        }

        // INTRO SCENE //
        public void Intro()
        {
            // Background
            

            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            Text.Draw("Good afternoon, Jordan..\n" +
                "I'm Monty, a detective with Hamilton Police.\n" +
                "I've brought you in for questioning about a crime \n" +
                "that was commited two weeks ago \n" +
                "on the night of March 12, 2026", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showIntroScene = false;
                showQuestion1 = true;
            }
        }

        // QUESTION 1 //
        public void Question1()
        {
            // Background
            

            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you break into the house?", 35, 470);

            // Options
            Graphics.Draw(button, buttonPositions[0]);
            Text.Draw("Option 1", 1060, 480);
            Graphics.Draw(button, buttonPositions[1]);
            Text.Draw("Option 2", 1060, 580);

            // Checks if mouse is inside the Option 1 button
            if (Input.GetMouseX() >= buttonPositions[0].X && Input.GetMouseX() <= buttonPositions[0].X + 220
                && Input.GetMouseY() >= buttonPositions[0].Y && Input.GetMouseY() <= buttonPositions[0].Y + 100)
            {
                //Audio.Play(hover);

                // Button highlight
                Graphics.Draw(buttonHover, buttonPositions[0]);
                Text.Color = Color.Black;
                Text.Draw("Option 1", 1060, 480);

                // Text box
                Graphics.Draw(textBox, 10, 445);
                Text.Color = Color.White;
                Text.Draw("Yes, I broke in.", 35, 470);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion1 = false;
                    showQuestion1Option1 = true;
                }
            }

            // Checks if mouse is inside the Option 2 button
            if (Input.GetMouseX() >= buttonPositions[1].X && Input.GetMouseX() <= buttonPositions[1].X + 220
                && Input.GetMouseY() >= buttonPositions[1].Y && Input.GetMouseY() <= buttonPositions[1].Y + 100)
            {
                //Audio.Play(hover);
                
                // Button highlight
                Graphics.Draw(buttonHover, buttonPositions[1]);
                Text.Color = Color.Black;
                Text.Draw("Option 2", 1060, 580);

                // Text box
                Graphics.Draw(textBox, 10, 445);
                Text.Color = Color.White;
                Text.Draw("No, I don't know what you're talking about.", 35, 470);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion1 = false;
                    showQuestion1Option2 = true;
                }
            }
        }

        // QUESTION 1 ANSWERS //
        public void Question1Option1()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            guilty = true;
            Text.Draw("Interesting...", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showQuestion1Option1 = false;
                showQuestion2 = true;
            }
        }

        public void Question1Option2()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            notGuilty = true;
            Text.Draw("Interesting...", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showQuestion1Option2 = false;
                showQuestion2 = true;
            }
        }

        // QUESTION 2 //
        public void Question2()
        {
            // Background


            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you use the front door or back door to break in?", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("Front door", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("Back door", 1065, 185);
            Text.Draw("I did not commit the crime.", 1065, 185);

            // Checks if mouse is inside the left option button
            if (Input.GetMouseX() >= yesCircle.X - radius && Input.GetMouseX() <= yesCircle.X + radius
                && Input.GetMouseY() >= yesCircle.Y - radius && Input.GetMouseY() <= yesCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(yesCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("Yes", 175, 185);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option1 = true;
                }
            }

            // Checks if mouse is inside the right option button
            if (Input.GetMouseX() >= noCircle.X - radius && Input.GetMouseX() <= noCircle.X + radius
                && Input.GetMouseY() >= noCircle.Y - radius && Input.GetMouseY() <= noCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(noCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("No", 1065, 185);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option2 = true;
                }
            }
        }

        // QUESTION 2 ANSWERS //
        public void Question2Front()
        {
            // Background


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

        public void Question2Back()
        {
            // Background


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

        public void Question2No()
        {
            // Background


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

        // QUESTION 3 //
        public void Question3()
        {
            // Background


            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you check to see if anyone was home?", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("I made sure no one was home", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("Hey man Im telling I didn't do anything", 1065, 185);


            // Checks if mouse is inside the left option button
            if (Input.GetMouseX() >= yesCircle.X - radius && Input.GetMouseX() <= yesCircle.X + radius
                && Input.GetMouseY() >= yesCircle.Y - radius && Input.GetMouseY() <= yesCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(yesCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("Yes", 175, 185);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option1 = true;
                }
            }

            // Checks if mouse is inside the right option button
            if (Input.GetMouseX() >= noCircle.X - radius && Input.GetMouseX() <= noCircle.X + radius
                && Input.GetMouseY() >= noCircle.Y - radius && Input.GetMouseY() <= noCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(noCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("No", 1065, 185);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option2 = true;
                }
            }
        }
        // QUESTION 4 //
        public void Question4()
        {
            // Background


            // Text box
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(200, 500, 880, 200);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you panic when you heard the police sirens?", 220, 520);

            // Options
            Draw.Circle(yesCircle, radius);
            Text.Draw("No I never panicked", 175, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No because I was never there", 1065, 185);
            Text.Draw("No because the cops were never called", 1065, 185);


            // Checks if mouse is inside the left option button
            if (Input.GetMouseX() >= yesCircle.X - radius && Input.GetMouseX() <= yesCircle.X + radius
                && Input.GetMouseY() >= yesCircle.Y - radius && Input.GetMouseY() <= yesCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(yesCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("Yes", 175, 185);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option1 = true;
                }
            }

            // Checks if mouse is inside the right option button
            if (Input.GetMouseX() >= noCircle.X - radius && Input.GetMouseX() <= noCircle.X + radius
                && Input.GetMouseY() >= noCircle.Y - radius && Input.GetMouseY() <= noCircle.Y + radius)
            {
                // Button highlight
                Draw.FillColor = Color.OffWhite;
                Draw.Circle(noCircle, radius);
                Text.Color = Color.Black;
                Text.Draw("No", 1065, 185);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    showQuestion1 = false;
                    showQuestion1Option2 = true;
                }
            }
        }
    }
}
