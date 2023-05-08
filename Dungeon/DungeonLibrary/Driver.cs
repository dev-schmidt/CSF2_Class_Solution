using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonLibrary
{
    public sealed class Driver : Monster
    {
        
       
        public string Description { get; set; }


        public Driver(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage,
            string description )
            : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        {
        }

        public Driver()
        {
            MaxLife = 30;
            MaxDamage = 2;
            Life = 30;
            MinDamage = 1;
            HitChance = 88;
            Name = "The slow driver";
            Description = "He's just sitting there perfectly matching the speed of the person next " +
                "to him. He has zero intentions of speeding up or moving over.";
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}\n\n{Description}";
        }

        public override int CalcDamage()
        {
            
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            if (roll < 15)
            {
                Life = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("He took an exit! Not our problem anymore, I guess.");
                Console.ResetColor();
                return 0;
                
            }
            return base.CalcDamage();
            
        }
    }
}
