// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;


// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Interrogation scenes = new Interrogation();

        public void Setup()
        {
            Window.SetSize(1250, 750);
            Window.SetTitle("Interrogation");
            Window.TargetFPS = 60;
        }

        public void Update()
        {
            Window.ClearBackground(Color.Black);
            SceneChanger();
        }

        public void SceneChanger()
        {
            if (scenes.showMainMenu == true)
            {
                scenes.MainMenu();
            }
            else if (scenes.showIntroScene == true)
            {
                scenes.Intro();
            }
            else if (scenes.showQuestion1 == true)
            {
                scenes.Question1();
            }
            else if (scenes.showQuestion1Yes == true)
            {
                scenes.Question1Yes();
            }
            else if (scenes.showQuestion1No == true)
            {
                scenes.Question1No();
            }
        }     
    }
}
