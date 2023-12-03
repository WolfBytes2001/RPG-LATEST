using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Models.Mobs
{   
    abstract class Mobs
    {
        public int Level { get; protected set; } = 1;

        public string EnemyType { get; protected set; }
        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public int Armor { get; protected set; }
        
        public Mobs(int health, int damage, int armor,int level)
        {
            Level = level;
            Health = health *Level;
            Damage = damage * Level;
            Armor = armor;
        }

       
        public abstract int TakeDamage(int damage);
        public abstract void specialSkill();
        public abstract void heal();


    }

    class LowTier : Mobs
    {
        public LowTier(int health, int damage, int armor,int level) : base(health, damage, armor,level)
        {
        }

        Random random = new Random();
        public override int TakeDamage(int damage)
        {
            double randomMultiplier = (1.3f - 0.7f) * random.NextDouble() + 0.7f;
            int damageBeforeArmor = (int)(damage * randomMultiplier);
            int finalDamage = (int)(damageBeforeArmor / Armor);

            if (finalDamage <= 0)
                finalDamage = 1;

            Health -= finalDamage;

            return finalDamage;
        }
        public override void specialSkill() { }
        public override void heal() { }
    }

    class Wolves : LowTier
    {
        public Wolves(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Wolf";
            
        }
    }
    class Mudcrabs : LowTier
    {
        public Mudcrabs(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Mud Crab";
        }

    }

    class SabreCats : LowTier
    {
        public SabreCats(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Sabre Cat";
        }
    }

    // MID TIER MOBS LEVEL 5 - 10
    class MidTier : Mobs
    {
        public MidTier(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {

        }
        Random random = new Random();
        public override int TakeDamage(int damage)
        {
            double randomMultiplier = (1.3f - 0.7f) * random.NextDouble() + 0.7f;
            int damageBeforeArmor = (int)(damage * randomMultiplier);
            int finalDamage = (int)(damageBeforeArmor / Armor);

            if (finalDamage <= 0)
                finalDamage = 1;

            Health -= finalDamage;

            return finalDamage;
        }

        public override void specialSkill()
        {
            throw new NotImplementedException();
        }

        public override void heal()
        {
            throw new NotImplementedException();
        }
    }

    class Bandits : MidTier
    {
        public Bandits(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Bandit";
        }

        
    }

    class Skeleton : MidTier
    {
        public Skeleton(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Skeleton";
        }
    }

    class Bears : MidTier
    {
        public Bears(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Bear";
        }
    }

    class EliteTier : Mobs
    {
        public EliteTier(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
        }
        Random random = new Random();
        public override int TakeDamage(int damage)
        {
            double randomMultiplier = (1.3f - 0.7f) * random.NextDouble() + 0.7f;
            int damageBeforeArmor = (int)(damage * randomMultiplier);
            int finalDamage = (int)(damageBeforeArmor / Armor);

            if (finalDamage <= 0)
                finalDamage = 1;

            Health -= finalDamage;

            return finalDamage;
        }
        public override void specialSkill()
        {
            throw new NotImplementedException();
        }
        public override void heal()
        {
            throw new NotImplementedException();
        }
    }

    class Giants : EliteTier
    {
        public Giants(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Giant";
        }
    }

    class DragonPriest : EliteTier
    {
        public DragonPriest(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Dragon Priest";
        }
    }

    class BossTier : Mobs
    {
        public BossTier(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
        }

        public override void specialSkill()
        {
            
        }
        public override int TakeDamage(int damage)
        {
            Random random = new Random();
            double randomMultiplier = (1.3f - 0.7f) * random.NextDouble() + 0.7f;
            int damageBeforeArmor = (int)(damage * randomMultiplier);
            int finalDamage = (int)(damageBeforeArmor / Armor);

            if (finalDamage <= 0)
                finalDamage = 1;

            Health -= finalDamage;

            return finalDamage; throw new NotImplementedException();
        }
        public override void heal()
        {
            throw new NotImplementedException();
        }
    }

    class Alduin : BossTier
    {
        public Alduin(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Alduin";
        }
    }

    class Sahloknir : BossTier
    {
        public Sahloknir(int health, int damage, int armor, int level) : base(health, damage, armor, level)
        {
            EnemyType = "Sahloknir";
        }
    }
}
