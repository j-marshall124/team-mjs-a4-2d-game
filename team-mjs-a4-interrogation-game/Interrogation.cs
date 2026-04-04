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
        public bool showBackstory = true;
        public bool showIntroScene = false;
        public bool showQuestion1 = false;
        public bool showQuestion1Option1 = false;
        public bool showQuestion1Option2 = false;
        public bool showQuestion2 = false;
        public bool showQuestion2Option1 = false;
        public bool showQuestion2Option2 = false;
        public bool showQuestion2Option3 = false;
        public bool showQuestion3 = false;
        public bool showQuestion3Option1 = false;
        public bool showQuestion3Option2 = false;
        public bool showQuestion4 = false;
        public bool showQuestion4Option1 = false;
        public bool showQuestion4Option2 = false;
        public bool showQuestion4Option3 = false;
        public bool showGuiltyEnding = false;
        public bool showNotGuiltyEnding = false;

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

        // MAIN MENU //
        public void MainMenu()
        {
            Text.Color = Color.White;
            Text.Draw("MAIN MENU (TEMP)", 275, 320);
            Text.Draw("Click to Start.", 480, 450);

            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showMainMenu = false;
                showBackstory = true;
            }
        }

        // BACKSTORY //
        public void Backstory()
        {            
            Text.Color = Color.White;
            Text.Draw("A crime was commited a few weeks ago...\n" +
                "You are guilty but try to avoid being caught!!!", 275, 320);
            Text.Draw("Click to continue.", 480, 450);

            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showBackstory = false;
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
                "I've brought you in for questioning about a crime that \n" +
                "was commited two weeks ago on the night of \n" +
                "March 12, 2026.", 35, 470);
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
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you use the front door or back door to break in?", 35, 470);

            // Options
            Graphics.Draw(button, buttonPositions[0]);
            Text.Draw("Option 1", 1060, 480);
            Graphics.Draw(button, buttonPositions[1]);
            Text.Draw("Option 2", 1060, 580);
            Graphics.Draw(button, buttonPositions[2]);
            Text.Draw("Option 3", 1060, 680);

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
                Text.Draw("I used the front door.", 35, 470);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion2 = false;
                    showQuestion2Option1 = true;
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
                Text.Draw("The back door was unlocked, so that's where I snuck in.", 35, 470);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion2 = false;
                    showQuestion2Option2 = true;
                }
            }
            // Checks if mouse is inside the Option 3 button
            if (Input.GetMouseX() >= buttonPositions[2].X && Input.GetMouseX() <= buttonPositions[2].X + 220
                && Input.GetMouseY() >= buttonPositions[2].Y && Input.GetMouseY() <= buttonPositions[2].Y + 100)
            {
                //Audio.Play(hover);

                // Button highlight
                Graphics.Draw(buttonHover, buttonPositions[2]);
                Text.Color = Color.Black;
                Text.Draw("Option 3", 1060, 680);

                // Text box
                Graphics.Draw(textBox, 10, 445);
                Text.Color = Color.White;
                Text.Draw("I'm telling you, I didn't do it.", 35, 470);

                bool isInsideOption3 = true;
                if (isInsideOption3 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion2 = false;
                    showQuestion2Option3 = true;
                }
            }
        }

        // QUESTION 2 ANSWERS //
        public void Question2Option1()
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
                showQuestion2Option1 = false;
                showQuestion3 = true;
            }
        }

        public void Question2Option2()
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
                showQuestion2Option2 = false;
                showQuestion3 = true;
            }
        }

        public void Question2Option3()
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
                showQuestion2Option3 = false;
                showQuestion3 = true;
            }
        }

        // QUESTION 3 //
        public void Question3()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you check to see if anyone was home?", 35, 470);

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
                Text.Draw("I made sure no one was home.", 35, 470);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion3 = false;
                    showQuestion3Option1 = true;
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
                Text.Draw("Hey man, I'm telling you I didn't do anything.", 35, 470);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion3 = false;
                    showQuestion3Option2 = true;
                }
            }
        }

        // QUESTION 3 ANSWERS //
        public void Question3Option1()
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
                showQuestion3Option1 = false;
                showQuestion4 = true;
            }
        }

        public void Question3Option2()
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
                showQuestion3Option2 = false;
                showQuestion4 = true;
            }
        }

        // QUESTION 4 //
        public void Question4()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            Text.Draw("Did you panic when you heard the police sirens?", 35, 470);

            // Options
            Graphics.Draw(button, buttonPositions[0]);
            Text.Draw("Option 1", 1060, 480);
            Graphics.Draw(button, buttonPositions[1]);
            Text.Draw("Option 2", 1060, 580);
            Graphics.Draw(button, buttonPositions[2]);
            Text.Draw("Option 3", 1060, 680);

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
                Text.Draw("No I never panicked.", 35, 470);

                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion4 = false;
                    showQuestion4Option1 = true;
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
                Text.Draw("No, because I was never there.", 35, 470);

                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion4 = false;
                    showQuestion4Option2 = true;
                }
            }
            // Checks if mouse is inside the Option 3 button
            if (Input.GetMouseX() >= buttonPositions[2].X && Input.GetMouseX() <= buttonPositions[2].X + 220
                && Input.GetMouseY() >= buttonPositions[2].Y && Input.GetMouseY() <= buttonPositions[2].Y + 100)
            {
                //Audio.Play(hover);

                // Button highlight
                Graphics.Draw(buttonHover, buttonPositions[2]);
                Text.Color = Color.Black;
                Text.Draw("Option 3", 1060, 680);

                // Text box
                Graphics.Draw(textBox, 10, 445);
                Text.Color = Color.White;
                Text.Draw("No, because the cops were never called.", 35, 470);

                bool isInsideOption3 = true;
                if (isInsideOption3 && Input.IsMouseButtonPressed(0))
                {
                    Audio.Play(click);
                    showQuestion4 = false;
                    showQuestion4Option3 = true;
                }
            }
        }

        // QUESTION 4 ANSWERS //
        public void Question4Option1()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            notGuilty = false;
            guilty = true;
            Text.Draw("Interesting...", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showQuestion4Option1 = false;
                if (guilty == true) // Checks which ending to play
                {
                    showGuiltyEnding = true;
                }
                else if (notGuilty == true)
                {
                    showNotGuiltyEnding = true;
                }
            }
        }

        public void Question4Option2()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            notGuilty = true;
            guilty = false;
            Text.Draw("Interesting...", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showQuestion4Option2 = false;
                if (guilty == true) // Checks which ending to play
                {
                    showGuiltyEnding = true;
                }
                else if (notGuilty == true)
                {
                    showNotGuiltyEnding = true;
                }
            }
        }

        public void Question4Option3()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Question
            Text.Color = Color.White;
            notGuilty = false;
            guilty = true;
            Text.Draw("Interesting...", 35, 470);
            Text.Draw("Click to continue...", 640, 690);

            // When mouse clicks, moves to the first question
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showQuestion4Option3 = false;
                if (guilty == true) // Checks which ending to play
                {
                    showGuiltyEnding = true;
                }
                else if (notGuilty == true)
                {
                    showNotGuiltyEnding = true;
                }
            }
        }

        public void GuiltyEnding()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Text
            Text.Color = Color.White;
            Text.Draw("GUILTY", 35, 470);
            Text.Draw("Click to play again...", 630, 690);
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                showGuiltyEnding = false;
                showBackstory = true;
            }
        }

        public void NotGuiltyEnding()
        {
            // Background


            // Text box
            Graphics.Draw(textBox, 10, 445);

            // Text
            Text.Color = Color.White;
            Text.Draw("NOT GUILTY", 35, 470);
            Text.Draw("Click to play again...", 630, 690);
            if (Input.IsMouseButtonPressed(0))
            {
                Audio.Play(click);
                
                showNotGuiltyEnding = false;
                showBackstory = true;
            }
        }
    }
}
