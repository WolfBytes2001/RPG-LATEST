using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    internal class PlayerInfo
    {
        public static void DisplayPlayerInfo()
        {
            Console.WriteLine($"---Player Details ({Game_Manager.playerName}) ---");
            Console.WriteLine($"Level:{Game_Manager.myHero.Level}");
            Console.WriteLine($"Race: {Game_Manager.myHero.HeroType}");
            Console.WriteLine($"Health: {Game_Manager.myHero.Health}");
            Console.WriteLine($"Damage: {Game_Manager.myHero.Damage}");
            Console.WriteLine($"Armor: {Game_Manager.myHero.Armor}");
            Console.WriteLine($"Healing Potions:{Game_Manager.myHero.HealingPotion}");

        }
    }
}
