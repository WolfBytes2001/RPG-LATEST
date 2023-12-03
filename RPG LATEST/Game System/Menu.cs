using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class Menu
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("D R A G O N B O R N\n");
            Console.WriteLine("1.START GAME");
            Console.WriteLine("2.OPTIONS");
            Console.WriteLine("3.EXIT");

        }

        public static void triggerStartGame()
        {
            if (GetKeyPress.GetUserInput() == "1")
            {
                //if 1 tawagon ag intro prompt from intro class
                Intro.IntroPrompt();
            }

            else
            {

            }
        }
    }
}
