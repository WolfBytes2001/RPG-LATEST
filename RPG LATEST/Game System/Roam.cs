using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class Roam
    {
        public static void findingOpponentLoadScreen(string choosenMap)
        {
            Console.Clear();
            Console.WriteLine($"Roaming the map of {choosenMap}.....");
            Thread.Sleep(500);
            Console.WriteLine("Dont Press Any Button.......");
            Thread.Sleep(1000);
            Console.WriteLine("Finding an enemy..........\n");
            Thread.Sleep(500);
        }

        public static string search()
        {
            Random random = new Random();
            int chance = random.Next(1, 5);
            if (chance == 1 || chance == 5)
            {

                return "Potion";
            }

            else if (chance == 2 || chance == 3 || chance == 4)
            {

                return "Enemy";
            }

            else
            {
                return "Nothing";
            }
        }

        public static void RoamResult(string stumbled)
        {
            if (stumbled == "Enemy")
            {
                Encounter.enemy();
                ResetStat.Reset(Game_Manager.playerDefeated);
            }

            else if (stumbled == "Potion")
            {
                Game_Manager.myHero.HealingPotion++;
                Console.WriteLine("You stumble upon a chest! Get you loot now.");
                Console.WriteLine("Healing Potion is added to your inventory!");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadKey();
            }

            else if (stumbled == "Nothing")
            {
                Console.WriteLine("Nothing interesting here might take a look for other areas...");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadKey();
            }
        }
    }
}
