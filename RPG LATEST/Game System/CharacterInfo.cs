using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class CharacterInfo
    {
        //func for displaying character info only but wrapped na siya
        public static void DisplayCharacter()
        {
            Console.WriteLine("1. NORD");
            Console.WriteLine($"Damage:120 HP:200");
            string nordDescript = "The Nords are a race of hardy humans native to the province of Skyrim, where The Elder Scrolls V: Skyrim takes place. Known for their resistance to cold, exceptional physical strength, and valor in combat, Nords are often seen as fearless warriors and seafarers.";
            string nordWrapped = WordWrap.Wrap(nordDescript, 100);
            Console.WriteLine(nordWrapped);

            Console.WriteLine();

            Console.WriteLine("2.ORCS");
            Console.WriteLine("Damage:35 HP:400");
            string orcDes = "They are a powerful, nomadic race. Many are currently residing in the Wrothgarian Mountains. They make some of the best heavily armored warriors, but also have a high willpower. Respect between Orcs is high, male or female, and none are neglected.\n";
            string orcWrap = WordWrap.Wrap(orcDes, 100);
            Console.WriteLine(orcWrap);


            Console.WriteLine("3. HIGH ELF");
            Console.WriteLine("DAMAGE:30 HP:100");
            string hElfDes = "The High Elves, also known as Altmer, are natives of Summerset Isle. They are the most magically proficient race in Tamriel as well as being the most hubristic. Their racial power is a constant effect that lets them regenerate magicka faster than other races.\n";
            string hElfWra = WordWrap.Wrap(hElfDes, 100);
            Console.WriteLine(hElfWra);

            Console.WriteLine("4. KAHJIT");
            Console.WriteLine("Damage:25 HP:110");
            string kahjitDes = "Feline humanoids from Elsweyr in the Elder Scrolls universe. Known for agility, stealth, and diverse physical forms based on moon phases. Often skilled in thievery and commerce, with a unique linguistic trait of referring to themselves in the third person.\n";
            string kahjitWrap = WordWrap.Wrap(kahjitDes, 100);
            Console.WriteLine(kahjitWrap);


        }
    }
}
