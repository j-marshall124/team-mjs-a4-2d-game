using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Scene
    {
        Player player = new Player();

        public float countdown = 5;
        public float transitionTimer;

        // BOOL CHECKS TO CHANGE SCENES //
        public bool showCrimeScene = true;
        public bool showLoadingScene = false;
        public bool showIntroScene = false;
        public bool showQuestion1 = false;
        public bool showInterrogationYes = false;
        public bool showInterrogationNo = false;        

        // GAMEPLAY CRIME SCENE //
        public void Crime()
        {
            player.PlayerMove();
            countdown -= Time.DeltaTime;
            if (countdown > 0)
            {
                Text.Color = Color.White;
                Text.Draw($"Timer: {countdown}", 10, 10);
            }
            else if (countdown <= 0)
            {
                transitionTimer = countdown + 3;
                transitionTimer -= Time.DeltaTime;
                if (transitionTimer <= 0)
                {
                    transitionTimer = 0;
                    showCrimeScene = false;
                    showLoadingScene = true;
                }
            }
        }

        // TWO WEEKS LATER... TRANSITION SCENE //
        public void Loading()
        {
            Window.ClearBackground(Color.Black);
            Text.Color = Color.White;
            Text.Draw("Two weeks later...", 480, 360);

            float continueTimer;
            continueTimer = Time.SecondsElapsed;
            if (continueTimer >= 5)
            {
                Text.Draw("Click to continue.", 480, 400);
            }
            if (Input.IsMouseButtonPressed(0))
            {
                showLoadingScene = false;
                showIntroScene = true;
            }
        }
    }
}
