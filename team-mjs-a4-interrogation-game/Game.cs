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
        Obstacle obstacles = new Obstacle();
        Interrogation questions;

        Vector2 yesCircle = new Vector2(200, 200);
        float radius = 50;
        Vector2 noCircle = new Vector2(1080, 200);

        public void Setup()
        {
            Window.SetSize(1250, 750);
            Window.SetTitle("Interrogation");
            Window.TargetFPS = 60;

            questions = new Interrogation(scenes);
        }

        public void Update()
        {
            Window.ClearBackground(Color.Black);
            if (scenes.showCrimeScene == true)
            {
                Gameplay();
                scenes.Crime();
            }
            else if (scenes.showLoadingScene == true)
            {
                scenes.Loading();
            }
            else if (scenes.showIntroScene == true)
            {
                questions.Intro();
            }
            else if (scenes.showQuestion1 == true)
            {
                questions.Question1();
            }
            else if (scenes.showInterrogationYes == true)
            {
                questions.InterrogationYes();
            }
            else if (scenes.showInterrogationNo == true)
            {
                questions.InterrogationNo();
            }
        }

        public void Gameplay()
        {
            
        }
     
    }

}
