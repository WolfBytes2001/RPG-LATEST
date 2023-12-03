using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class Map
    {
        public static string DisplayMap()
        {
            Console.Clear();
            Console.WriteLine($"Name:{Game_Manager.playerName} Level:{Game_Manager.myHero.Level} XP:{Game_Manager.myHero.XP} HP:{Game_Manager.myHero.Health}\n");
            Console.WriteLine("                Starting Area           ");
            Console.WriteLine("Low - Mid Tier Enemy    : 1.Riverwood 2.WhiteRun ");
            Console.WriteLine("Mid - Elite Tier Enemy  : 3.Falkeath 4. Winterhold");
            Console.WriteLine("Elite - Boss Tier Enemy : 5.Whiterun Tundra  6.The Reach");
            Console.WriteLine("Final Boss Location     : 7.Sovngrade\n");
            Console.WriteLine("Choose map to explore (1,2,3,4,5,6,7):");


            Game_Manager.keyPress = GetKeyPress.GetUserInput();

            if (Game_Manager.keyPress == "1")
            {
                return "Riverwood";
            }
            else if (Game_Manager.keyPress == "2")
            {
                return "WhiteRun";
            }
            else if (Game_Manager.keyPress == "3")
            {
                return "Falkeath";
            }
            else if (Game_Manager.keyPress == "4")
            {
                return "WinterHold";
            }
            else if (Game_Manager.keyPress == "5")
            {
                return "WhiteRun Tundra";
            }
            else if (Game_Manager.keyPress == "6")
            {
                return "The Reach";
            }
            else if (Game_Manager.keyPress == "7")
            {
                return "Sovngrade";
            }

            else
            {
                return "Invalid";
            }
        }
    }
}
