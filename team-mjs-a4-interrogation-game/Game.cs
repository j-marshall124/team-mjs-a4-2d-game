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
            else if (scenes.showQuestion2Front == true)
            {
                scenes.Question2Front();
            }
            else if (scenes.showQuestion2Back == true)
            {
                scenes.Question2Back();
            }
            else if (scenes.showQuestion2No == true)
            {
                scenes.Question2No();
            }
        }     
    }
}
