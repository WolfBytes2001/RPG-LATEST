using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    internal class Encounter
    {
        public static void enemy()
        {
            Console.WriteLine($"WATCH OUT {Game_Manager.randomMob.EnemyType} AHEAD!!");
            Console.WriteLine($"{Game_Manager.randomMob.EnemyType} level: {Game_Manager.randomMob.Level}");
            Console.WriteLine("1.FIGHT || 2. FLEE");
            Console.Write("(1,2):");
            Game_Manager.keyPress = GetKeyPress.GetUserInput();

            if (Game_Manager.keyPress == "1")
            {
                Battle.StartBattle();
            }
            else if (Game_Manager.keyPress == "2")
            {
                Console.WriteLine("");
                //Random random = new Random();
                //int chance = random.Next(2);
                if (Game_Manager.randomMob.Level < 11)
                {

                    Console.WriteLine("You successfully flee from your enemy!");
                    Console.ReadKey();
                    Map.DisplayMap();
                }
                else
                {
                    Console.WriteLine("You failed to escape! Your enemy is attacking you!");
                    Console.ReadKey();
                    Battle.StartBattle();
                }
            }
            // Handle other cases 
        }
    }
}
