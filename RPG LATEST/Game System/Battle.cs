using RPG_LATEST.Models.Mobs;
using RPG_LATEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class Battle
    {
        public static int iniDamage = Game_Manager.myHero.Damage;
        public static int iniArmor = Game_Manager.myHero.Armor;
        public static int finalDamage;
        static bool skillInuse = false;
        public static int initalHealth = Game_Manager.myHero.Health;
        public static void StartBattle()
        {
            int turn = 0;

            while (true)
            {

                Console.Clear();

                Console.WriteLine(initalHealth);
                Console.WriteLine("Turns :" + turn);
                PlayerInfo.DisplayPlayerInfo();

                if (Game_Manager.myHero.HeroType == "Elf")
                {
                    Console.WriteLine($"Mana: {Elf.mana}");
                }
                EnemyInfo.DisplayEnemyInfo(Game_Manager.randomMob);

                Console.WriteLine("->Choose an action<-");
                Console.WriteLine("(A) to Basic Attack | (H) to use Potion | (S) for Special Skill");
                Console.Write("> ");
                Game_Manager.keyPress = Console.ReadLine();

                if (Game_Manager.keyPress.ToUpper() == "A")
                {
                    Attack(Game_Manager.myHero, Game_Manager.randomMob, Game_Manager.myHero.Damage);
                    checkVictory(Game_Manager.randomMob, Game_Manager.myHero);
                    turn++;
                }

                else if (Game_Manager.keyPress.ToUpper() == "H")
                {
                    Console.WriteLine("Grabbing a potion...");
                    Game_Manager.myHero.heal();
                    turn++;
                }

                else if (Game_Manager.keyPress.ToUpper() == "S")
                {

                    if (Game_Manager.myHero.HeroType == "Nord")
                    {
                        if (turn != 0 && turn % 3 == 0)
                        {
                            Game_Manager.myHero.specialSkill();
                            Attack(Game_Manager.myHero, Game_Manager.randomMob, Game_Manager.myHero.Damage);
                            Game_Manager.myHero.Damage /= 2;
                        }
                        else
                        {
                            Console.WriteLine("Its not time yet!!!");
                        }
                    }

                    else if (Game_Manager.myHero.HeroType == "Orc")
                    {

                        if (Game_Manager.myHero.Health < (.5 * initalHealth))
                        {
                            if (skillInuse)
                            {
                                Console.WriteLine("Berserker Rage Already In use!");
                            }
                            else if (skillInuse == false)
                            {
                                Game_Manager.myHero.specialSkill();
                                skillInuse = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Its not time yet!!");
                        }



                    }

                    else if (Game_Manager.myHero.HeroType == "Elf")
                    {
                        Game_Manager.myHero.specialSkill();

                    }

                    else if (Game_Manager.myHero.HeroType == "Kahjit")
                    {
                        Game_Manager.myHero.specialSkill();
                        if (Kahjit.carnageActivated == true)
                        {
                            Attack(Game_Manager.myHero, Game_Manager.randomMob, Game_Manager.myHero.Damage);
                            Game_Manager.myHero.Damage /= 5;
                        }


                    }

                    checkVictory(Game_Manager.randomMob, Game_Manager.myHero);

                }


                //Game_Manager.myHero.specialSkill();
                //finalDamage = (Game_Manager.randomMob.TakeDamage(Game_Manager.myHero.Damage)) * 2;
                //Console.WriteLine($"{Game_Manager.randomMob.EnemyType} took {finalDamage} damage");
                //checkVictory(Game_Manager.randomMob, Game_Manager.myHero);
                //if (Game_Manager.myHero.HeroType == "Nord" && Game_Manager.myHero.AttackTurn == Game_Manager.myHero.AttackLimit)
                //{
                //    //ResetStat.Reset(true);
                //}

                turn++;

                Elf.mana += 25;

                Thread.Sleep(1000);
                Console.WriteLine();

                finalDamage = Game_Manager.myHero.takeDamage(Game_Manager.randomMob.Damage);
                Console.WriteLine($"Player took {finalDamage} damage");

                Console.WriteLine();
                if (Game_Manager.myHero.Health <= 0)
                {
                    Defeat();
                    break;
                }

                Thread.Sleep(1000);

            }


        }
        public static void Attack(Race player, Mobs enemy, int damage)
        {


            finalDamage = enemy.TakeDamage(damage);
            Console.WriteLine($"{enemy.EnemyType} took {finalDamage} damage");


        }

        public static void SpecialSkill(Race player, Mobs enemy)
        {

        }
        public static void checkVictory(Mobs enemy, Race player)
        {
            if (enemy.Health <= 0)
            {
                Console.WriteLine("!!!You won!!!");
                GainLevel.gainXP(enemy);
                GainLevel.levelup(player);

                Thread.Sleep(1000);
                Console.ReadKey();
                Game_Manager.RoamingAndBattleScene();
            }
        }

        public static void Defeat()
        {

            Console.WriteLine("!!!You lost!!!");
            Game_Manager.playerDefeated = true;
            ResetStat.Reset(Game_Manager.playerDefeated);
            Console.ReadKey();
            // Handle losing conditions if needed


        }
    }
}
