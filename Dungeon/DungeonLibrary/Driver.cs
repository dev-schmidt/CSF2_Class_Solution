using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Driver : Monster
    {
        public int GoAway { get; set; }
        public int GoAwayChance { get; set; }
        public string Description { get; set; }


        public Driver(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage,
            string description, int goAway, int goAwayChance)
            : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        {
            GoAway = goAway;
            GoAwayChance = goAwayChance;
        }

        public Driver()
        {
            MaxLife = 30;
            MaxDamage = 2;
            Life = 30;
            MinDamage = 1;
            HitChance = 88;
            Name = "Some guy is going 5 under in the left lane";
            Description = "He's just sitting there perfectly matching the speed of the person next " +
                "to him. He has zero intentions of speeding up or moving over.";
            GoAway = 10;
            GoAwayChance = 99;
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}\n\nDamage: " +
                $"{MinDamage} - {MaxDamage}\n\n{Description}";
        }
    }
}
