using RPG_LATEST.Models.Mobs;
using RPG_LATEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class GainLevel
    {
        public static void gainXP(Mobs enemy)
        {
            int xpToAdd;

            if (enemy.Level <= 3)
            {
                xpToAdd = 10;
                Console.WriteLine($"Gained {xpToAdd} XP!");
            }
            else if (enemy.Level <= 5)
            {
                xpToAdd = 15;
                Console.WriteLine($"Gained {xpToAdd} XP!");
            }
            else if (enemy.Level <= 8)
            {
                xpToAdd = 20;
            }
            else if (enemy.Level <= 10)
            {
                xpToAdd = 25;
            }
            else if (enemy.Level <= 15)
            {
                xpToAdd = 50;
            }
            else if (enemy.Level <= 20)
            {
                xpToAdd = 70;
            }
            else if (enemy.Level <= 25)
            {
                xpToAdd = 100;
            }
            else
            {
                xpToAdd = 5000;
            }

            Game_Manager.myHero.XP += xpToAdd;

        }
        public static void levelup(Race myHero)
        {
            if ((myHero.Level == 1 && myHero.XP >= 10) || (myHero.Level == 2 && myHero.XP >= 30) || (myHero.Level == 3 && myHero.XP >= 50) || (myHero.Level == 4 && myHero.XP >= 100) || myHero.Level == 5 && myHero.XP == 250)
            {
                myHero.Level++;
                myHero.XP = 0;

                //applying stat upgrade
                myHero.Health *= myHero.Level;
                myHero.Damage *= myHero.Level;
                myHero.Armor *= myHero.Level;
                Console.WriteLine("YOU LEVEL UP!!!");
                //setting new initial stats
                Battle.initalHealth = myHero.Health;
                Battle.iniArmor = myHero.Armor;
                Battle.iniDamage = myHero.Damage;

            }
        }
    }
}
