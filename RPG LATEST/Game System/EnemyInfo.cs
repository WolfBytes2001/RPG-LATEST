using RPG_LATEST.Models.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class EnemyInfo
    {
        public static void DisplayEnemyInfo(Mobs enemy)
        {
            Console.WriteLine();
            Console.WriteLine("---Enemy Details---");
            Console.WriteLine($"Name: {enemy.EnemyType}");
            Console.WriteLine($"Level: {enemy.Level}");
            Console.WriteLine($"Health: {enemy.Health}");
            Console.WriteLine($"Damage: {enemy.Damage}");
            Console.WriteLine($"Armor: {enemy.Armor}");
            Console.WriteLine();
        }
    }
}
