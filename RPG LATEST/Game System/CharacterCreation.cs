using RPG_LATEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class CharacterCreation
    {
        //for character creation only gigamit nako ang GameManager class para sa temp storage sa mga inputs since didto ko mag gama sa gam loop logic
        public static void createChar()
        {
            Console.Clear();
            Console.WriteLine("    D R A G O N B O R N\n");
            Console.WriteLine("CHOOSE A STARTING CLASS");
            CharacterInfo.DisplayCharacter();
            Console.Write("(1,2,3,4,5)");
            Game_Manager.keyPress = GetKeyPress.GetUserInput();

            Console.Write("\nType your name: ");
            Game_Manager.playerName = Console.ReadLine();

            if (Game_Manager.keyPress == "1")
            {
                Game_Manager.myHero = new Nord(120, 20, 2, 1);
                Game_Manager.creationSuccess = true;
            }
            else if (Game_Manager.keyPress == "2")
            {
                Game_Manager.myHero = new Orc(150, 15, 4, 1);
                Game_Manager.creationSuccess = true;
            }
            else if (Game_Manager.keyPress == "3")
            {
                Game_Manager.myHero = new Elf(100, 30, 1, 1);
                Game_Manager.creationSuccess = true;
            }
            else if (Game_Manager.keyPress == "4")
            {
                Game_Manager.myHero = new Kahjit(110, 25, 1, 1);
                Game_Manager.creationSuccess = true;
            }
            else
            {
                Console.WriteLine("Hero not found");
                return;
            }

            Console.Clear();
        }
    }
}
