// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Player player = new Player();
        Scene scenes = new Scene();             

        Vector2 yesCircle = new Vector2(100, 200);
        float radius = 50;
        Vector2 noCircle = new Vector2(700, 200);

        public void Setup()
        {
            Window.SetSize(1280, 720);
            Window.SetTitle("Interrogation");
            Window.TargetFPS = 60;
        }

        public void Update()
        {
            Window.ClearBackground(Color.Black);
            if (scenes.showCrimeScene == true)
            {
                scenes.Crime();
            }
            else if (scenes.showLoadingScene == true)
            {
                scenes.Loading();
            }
            else if (scenes.showInterrogation == true)
            {
                Interrogation();
            }
            else if (scenes.showInterrogationYes == true)
            {
                InterrogationYes();
            }
            else if (scenes.showInterrogationNo == true)
            {
                InterrogationNo();
            }
        }     

        public void Interrogation()
        {
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(0, 600, 800, 200);
            Text.Color = Color.White;
            Text.Draw("Did you do the crime?", 20, 620);
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 75, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 685, 185);

            if (Input.GetMouseX() >= yesCircle.X - radius && Input.GetMouseX() <= yesCircle.X + radius
                && Input.GetMouseY() >= yesCircle.Y - radius && Input.GetMouseY() <= yesCircle.Y + radius)
            {
                bool isInsideOption1 = true;
                if (isInsideOption1 && Input.IsMouseButtonPressed(0))
                {
                    scenes.showInterrogation = false;
                    scenes.showInterrogationYes = true;
                }
            }

            if (Input.GetMouseX() >= noCircle.X - radius && Input.GetMouseX() <= noCircle.X + radius
                && Input.GetMouseY() >= noCircle.Y - radius && Input.GetMouseY() <= noCircle.Y + radius)
            {
                bool isInsideOption2 = true;
                if (isInsideOption2 && Input.IsMouseButtonPressed(0))
                {
                    scenes.showInterrogation = false;
                    scenes.showInterrogationNo = true;
                }
            }
        }

        public void InterrogationYes()
        {
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(0, 600, 800, 200);
            Text.Color = Color.White;
            Text.Draw("I can't believe this. GAME OVER.", 20, 620);
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 75, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 685, 185);
        }

        public void InterrogationNo()
        {
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.DarkGray;
            Draw.Rectangle(0, 600, 800, 200);
            Text.Color = Color.White;
            Text.Draw("I knew it wasn't you. YOU WIN.", 20, 620);
            Draw.Circle(yesCircle, radius);
            Text.Draw("Yes", 75, 185);
            Draw.Circle(noCircle, radius);
            Text.Draw("No", 685, 185);
        }
    }

}
