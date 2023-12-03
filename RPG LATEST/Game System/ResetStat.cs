using RPG_LATEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class ResetStat
    {
        public static void Reset(bool defeated)
        {
            if (defeated == true)
            {
                if (Game_Manager.myHero.HeroType == "Nord")
                {
                    Game_Manager.myHero = new Nord(120, 5, 1, Game_Manager.myHero.Level);
                }
                else if (Game_Manager.myHero.HeroType == "Elf")
                {
                    Game_Manager.myHero = new Elf(100, 6, 1, Game_Manager.myHero.Level);
                    Elf.mana = 100;
                }
                else if (Game_Manager.myHero.HeroType == "Orc")
                {
                    Game_Manager.myHero = new Orc(150, 15, 4, Game_Manager.myHero.Level);
                }
                else if (Game_Manager.myHero.HeroType == "Kahjit")
                {
                    Game_Manager.myHero = new Kahjit(110, 25, 1, Game_Manager.myHero.Level);
                }
            }
        }
    }
}
