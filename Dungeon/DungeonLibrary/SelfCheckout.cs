using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class SelfCheckout : Monster
    {
        public int RandomHeal { get; set; }
        public int RandomHealChance { get; set; }
        public string Description { get; set; }

        public SelfCheckout(string name, int hitChance, int block, int maxLife,
            int minDamage, int maxDamage, string description, int randomHeal,
            int randomHealChance)
            : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        {
            RandomHeal = randomHeal;
            RandomHealChance = randomHealChance;
        }

        public SelfCheckout()
        {
            MaxLife = 15;
            MaxDamage = 20;
            Life = 15;
            MinDamage = 5;
            HitChance = 35;
            Name = "Self Checkout Machine";
            Description = "Please take your receipt.";
            RandomHeal = 5;
            RandomHealChance = 40;
            //POTENTIAL ADDITION - make the machine say random phrases
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}\nDamage: {MinDamage} - {MaxDamage}\n" +
                $"{Description}";
        }

        public override int CalcBlock()
        {
            int newHeal = Life;
            Random rand = new Random();
            int roll = rand.Next(101);
            
            if(roll <= RandomHealChance)
            {
                newHeal += RandomHeal;
                Console.WriteLine($"The machine healed itself by {RandomHeal} points!");
            }
            return newHeal;
           
        }
    }
}
