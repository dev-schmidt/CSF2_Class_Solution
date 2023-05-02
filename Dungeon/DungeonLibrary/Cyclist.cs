using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonLibrary
{
    public sealed class Cyclist : Monster
    {
        public int BlockBonus { get; set; }
        public int BlockBonusChance { get; set; }
        public string Description { get; set; }

        //FQCTOR
        public Cyclist(string name, int hitChance, int block, int maxLife,
            int minDamage, int maxDamage, string description, int blockBonus, 
            int blockBonusChance)
            : base(name, hitChance, block, maxLife,
            minDamage, maxDamage, description)
        { 
            BlockBonus = blockBonus;
            BlockBonusChance = blockBonusChance;
        }

        //CTOR
        public Cyclist()
        {
            
            MaxLife = 10;
            MaxDamage = 2;
            Life = 10;
            MinDamage = 1;
            HitChance = 65;
            Name = "Angry Cyclist";
            Description = "They saw you riding on the sidewalk.";
            BlockBonus = 10;
            BlockBonusChance = 40;
        }
        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}\nDamage: {MinDamage} - {MaxDamage}\n{Description}";

        }

        public override int CalcBlock()
        {
            int betterBlock = Block;

            Random rand = new Random();
            int chance = rand.Next(101);

            if (chance <= BlockBonusChance)
            {
                betterBlock += BlockBonus;
            }
            return betterBlock;
        }

    }//end class
}//end namespace
