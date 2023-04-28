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

        public Monster(string name, int maxLife, int hitChance, int block) 
            : base(name, hitChance, block, maxLife)
        {
            //TODO - Create the props/fields, add parameters, and assign to your custom props
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = DescriptionAttribute;
        }
        public Monster()
        {
            //default ctor
        }
        //TODO - override the ToString() to include your new custom props.
        //TODO - override CalcDamage()

        public override int CalcDamage()
        {
            //return a random number betwween your min and max damage properties
            throw new NotImplementedException();
            //DON'T run the program will ^this is here
        }

    }
}
