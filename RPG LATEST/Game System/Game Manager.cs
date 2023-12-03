using RPG_LATEST.Models;
using RPG_LATEST.Models.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class Game_Manager
    {
        public static Mobs randomMob;
        public static Race myHero;
        public static string playerName;

        public static int XP;
        public static string keyPress;
        public static int maxWidth = 100;
        public static bool creationSuccess = false;
        public static bool playerDefeated = false;
        public static int turns;


        // gi per scene para mas han ay
        public static void firstScene()
        {
            //display mainmenu and triggerstartgame prompt
            Menu.DisplayMainMenu();
            Menu.triggerStartGame();


        }
        public static void secondScene()
        {

            CharacterCreation.createChar();
            if (creationSuccess)
            {
                RoamingAndBattleScene();
            }


        }
        public static void RoamingAndBattleScene()
        {
            bool continueRoaming = true;

            while (continueRoaming)
            {
                string selectedMap = Map.DisplayMap();
                randomMob = EnemyRandomizer.RandomEnemy(selectedMap);
                Roam.findingOpponentLoadScreen(selectedMap);

                Roam.RoamResult(Roam.search());
            }
        }

    }


   
}
