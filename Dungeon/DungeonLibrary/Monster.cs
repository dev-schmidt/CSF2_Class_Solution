using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //props
        //MinDamage int - FIELD - Business Rule: > 0 && < MaxDamage
        //MaxDamage int
        //description string

        #region
        //Add a WeaponType for a weakness or a resistance
        //you could add funtionality to tomorrow's combat class
        //to deal additional damage if the monster is weak to the
        //weapon you have
        #endregion

        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value < MaxDamage && value > 0 ? value : 1; }
        }
      
        public Monster(string name, int hitChance, int block, int maxLife, 
            int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, maxLife)
        {
            if (maxDamage <= minDamage || minDamage <= 0)
            {
                throw new ArgumentException("Min damange must be between 0 and Max Damage");
            }
            //TODO - Create the props/fields, add parameters, and assign to your custom props
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster()
        {
            //default ctor
        }

        //TODO - override the ToString() to include your new custom props.
        //TODO - override CalcDamage()
        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} - {MaxDamage}\n{Description}";
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
            //return a random number between your min and max damage properties
            //DON'T run the program will ^this is here
        }

    }
}
