using RPG_LATEST.Models.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_LATEST;
using System.Net;
using RPG_LATEST.Game_System;

namespace RPG_LATEST.Models
{
    abstract class Race
    {

        Random random = new Random();
        public string HeroType { get; protected set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Health { get;  set; }
        public int Damage { get;  set; }
        public string DamageType { get; set; }  
        public int Armor { get; set; }
        public string Description { get; protected set; }
        public int AttackTurn { get; set; }
        public int AttackLimit { get; set; }

        public int HealingPotion { get; set; } = 0;

        public Race(int health, int damage, int armor, int level)
        {
            Level = level;
            Health = health * Level;
            Damage = damage * Level;
            Armor = armor * Level;
        }

        public virtual int takeDamage(int damage)
        {   
            
            double randomMultiplier = (1.3f - 0.7f) * random.NextDouble() + 0.7f;
            int damageBeforeArmor = (int)(damage * randomMultiplier);
            int finalDamage = (int)(damageBeforeArmor / Armor);

            if (finalDamage <= 0)
                finalDamage = 1;

            Health -= finalDamage;

            return finalDamage;
        }
        public virtual void heal()
        {
            if(HealingPotion > 0)
            {
                Console.WriteLine("You drank healing potion (50 points) added to your healthpoints.");
                Health += 50;
                HealingPotion--;
                
            }

            else
            {
                Console.WriteLine("No healing potion in the inventory!");
                
            }
            
        }

        
        public abstract void specialSkill();


    }

    class Nord : Race
    {
        
        public Nord(int health, int damage, int armor,int level) : base(health, damage, armor,level)
        {
            HeroType = "Nord";
            AttackLimit = 1;
            AttackTurn = 1;
        }
   
        public override void specialSkill()
        {
            Console.WriteLine("BATTLE CRY IN USED!");
            Console.WriteLine("Temporary boost for 1 attack");

            Damage *= 2;
            //Battle.Attack()
            
            AttackTurn = 1;
            
        }
        
       

    }

    class Elf : Race
    {
        public static int mana { get; set; }
        public Elf(int health, int damage, int armor, int level) : base(health, damage, armor,level)
        {
            HeroType = "Elf";
            mana = 100;
        }

        

        public override void specialSkill()
        {
           if(mana >74)
            {
                Console.WriteLine("!!FIREBALL IN USE!!");
                int temp = Damage;
                Damage = 80;
                Battle.Attack(Game_Manager.myHero, Game_Manager.randomMob, Damage);
                Damage = temp;
                mana -= 50;
            }
           else
            {
                Console.WriteLine("Not enough Mana!!");
            }
        }
    }

    class Orc : Race
    {
        public Orc(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            HeroType = "Orc";
        }

       

        
        public override void specialSkill()
        {
            Console.WriteLine("!!!!BERSERKER RAGE IN USE!!!!");
            
                Damage *= 4;


        }
    }

    class Kahjit : Race
    {
        public static bool carnageActivated = true;
        public Kahjit(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            HeroType = "Kahjit";
        }

        public override void specialSkill()
        {
            
            if(Health > 100)
            {
                Console.WriteLine("!!!CARNAGE IN USED!!!");
                Console.WriteLine("-Sacrificing health for damage boost.");
                Console.WriteLine("Buff: Damage x 5 | Debuff: Health -100");
                Damage *= 5;
                Health -= 100;

            }
            else
            {
                Console.WriteLine("Cannot activate carnage insufficient Health! ");
                carnageActivated = false;
            }
        }
    }


}