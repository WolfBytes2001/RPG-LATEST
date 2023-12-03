using RPG_LATEST.Models.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class EnemyRandomizer
    {
        public static Mobs RandomEnemy(string map)
        {
            List<Mobs> enemyListLowLevel = new List<Mobs>
            {
                new Wolves(20, 5, 1,1),
                new Mudcrabs(10, 2, 1,1),
                new SabreCats(15,3,1,1)
            };
            List<Mobs> enemyListMidLevel = new List<Mobs>
            {
                new Bandits(20, 10, 1,3),
                new Skeleton(20, 12, 1,4),
                new Bears(20,10,1,5),
            };
            List<Mobs> enemyListEliteLevel = new List<Mobs>
            {
                new Giants(15,15,3,10),
                new DragonPriest(15,14,3,15),

            };
            List<Mobs> enemyListBossTier = new List<Mobs>
            {
                new Alduin(50,40,10,40),
                new Sahloknir(40,25,10,25)
            };

            Random random = new Random();

            List<Mobs> enemyList;

            // Choose the appropriate enemy list based on the player's level
            if (map == "WhiteRun" || map == "Riverwood")
            {
                enemyList = enemyListLowLevel;
            }
            else if (map == "Falkeath" || map == "WinterHold")
            {
                enemyList = enemyListMidLevel;
            }
            else if (map == "WhiteRun Tundra" || map == "The Reach")
            {
                enemyList = enemyListEliteLevel;
            }
            else if (map == "Sovngrade")
            {
                enemyList = enemyListBossTier;
            }
            else
            {

                Console.WriteLine("Invalid Selection");
                Console.WriteLine("Face the boss instead!LOL");
                enemyList = enemyListBossTier;
            }

            Mobs randomEnemy = enemyList[random.Next(enemyList.Count)];

            return randomEnemy;
        }
    }
}
