﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class SelfCheckout : Monster
    {
        public int AttackBonus { get; set; }
        public int AttackBonusChance { get; set; }
        public string Description { get; set; }

        //FQTOR
        public SelfCheckout(string name, int hitChance, int block, int maxLife,
            int minDamage, int maxDamage, string description, int attackBonus,
            int attackBonusChance)
            : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        {
            AttackBonus = attackBonus;
            AttackBonusChance = attackBonusChance;
        }

        //CTOR
        public SelfCheckout()
        {
            MaxLife = 10;
            MaxDamage = 5;
            Life = 10;
            MinDamage = 1;
            HitChance = 70;
            Name = "Self Checkout Machine";
            Description = "Frequent shopper account activated!";
            AttackBonus = 10;
            AttackBonusChance = 99;
            //POTENTIAL ADDITION - make the machine say random phrases
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}\n\nDamage: " +
                $"{MinDamage} - {MaxDamage}\n\n{Description}";
        }

        //TODO I don't think the attack bonus is working
        //I might want to change it to a chance for annoying beeps
        public override int CalcBlock()
        {
            int bonus = AttackBonus;
            Random rand = new Random();
            int roll = rand.Next(101);

            if ( roll < 30)
            {
                bonus += MaxDamage;
                Console.WriteLine($"The machine did {bonus} points of extra damage!");
            }
            return bonus;
        }


    }
}
