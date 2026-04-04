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

        Music bgm = Audio.LoadMusic("../../../../assets/audio/Cool Vibes.mp3");

        public void Setup()
        {
            Window.SetSize(1250, 750);
            Window.SetTitle("Interrogation");
            Window.TargetFPS = 60;
            Audio.Play(bgm);
        }

        public void Update()
        {
            Window.ClearBackground(scenes.bg);            
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
            else if (scenes.showQuestion1Option1 == true)
            {
                scenes.Question1Option1();
            }
            else if (scenes.showQuestion1Option2 == true)
            {
                scenes.Question1Option2();
            }
            else if (scenes.showQuestion2 == true)
            {
                scenes.Question2();
            }
            else if (scenes.showQuestion2Option1 == true)
            {
                scenes.Question2Option1();
            }
            else if (scenes.showQuestion2Option2 == true)
            {
                scenes.Question2Option2();
            }
            else if (scenes.showQuestion2Option3 == true)
            {
                scenes.Question2Option3();
            }
            else if (scenes.showQuestion3 == true)
            {
                scenes.Question3();
            }
            else if (scenes.showQuestion3Option1 == true)
            {
                scenes.Question3Option1();
            }
            else if (scenes.showQuestion3Option2 == true)
            {
                scenes.Question3Option2();
            }
            else if (scenes.showQuestion4 == true)
            {
                scenes.Question4();
            }
            else if (scenes.showQuestion4Option1 == true)
            {
                scenes.Question4Option1();
            }
            else if (scenes.showQuestion4Option2 == true)
            {
                scenes.Question4Option2();
            }
            else if (scenes.showQuestion4Option3 == true)
            {
                scenes.Question4Option3();
            }
            else if (scenes.showGuiltyEnding == true)
            {
                scenes.GuiltyEnding();
            }
            else if (scenes.showNotGuiltyEnding == true)
            {
                scenes.NotGuiltyEnding();
            }
        }     
    }
}
