using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class LaundryBasket : Monster
    {
        public int RandomHeal { get; set; }
        public int RandomHealChance { get; set; }
        public string Description { get; set; }

        public LaundryBasket(string name, int hitChance, int block, int maxLife,
            int minDamage, int maxDamage, string description, int randomHeal,
            int randomHealChance)
            : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        {
            RandomHeal = randomHeal;
            RandomHealChance = randomHealChance;
        }

        public LaundryBasket()
        {
            MaxLife = 15;
            MaxDamage = 15;
            Life = 15;
            MinDamage = 5;
            HitChance = 35;
            Name = "Laundry Basket";
            Description = "There is no reason why it should be this full.";
            RandomHeal = 5;
            RandomHealChance = 40;
            
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
                newHeal = MaxLife;
                Console.WriteLine("Are you kidding me? " +
                    "It just filled itself up with more clothes!");
            }
            return newHeal;
           
        }
    }
}
