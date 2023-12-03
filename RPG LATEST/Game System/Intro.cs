using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    internal class Intro
    {
        // mao ni tawgon if mag start game ang user prompted if skip or play scene
        public static void IntroPrompt()
        {
            Console.Clear();
            Console.WriteLine("(1) TO PLAY INTRO (2) TO SKIP INTRO");
            if (GetKeyPress.GetUserInput() == "1")
            {
                //if play then call display intro func
                displayIntro();
            }
            else
            {

            }
        }

        //for displaying intro only
        public static void displayIntro()
        {


            string[] messages =
                 {
                    ">In the rugged realm of Skyrim, you awaken to a revelation—the dragon's soul resides within you. ",
                    ">Guided by the wise Greybeards, you'll tread through political turmoil, align with factions, and face moral crossroads.  ",
                    "> The climax awaits in Sovngarde, where you, the Dragonborn, confront Alduin to safeguard Skyrim. ",
                    "> As the sun sets on your adventure, the choice is yours—embrace your destined heroism or vanish into the shadows. Your journey in Skyrim begins now.",
                     ">               You're finally awake."

                };

            Console.Clear();

            foreach (string message in messages)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                Console.WriteLine("--->D R A G O N  B O R N<---");

                for (int i = 0; i < message.Length; i++)
                {
                    sb.Append(message[i]);
                    Console.WriteLine(sb.ToString());

                    Thread.Sleep(10);
                    Console.SetCursorPosition(0, 1);
                }

                Thread.Sleep(5000);

                Console.Clear();

            }
        }
    }
}
