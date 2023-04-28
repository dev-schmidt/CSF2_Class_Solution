using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //MAKE IT PUBLIC!
    public class Weapon
    {
        /*  Weapon: Make fields and props for each of these with the appropriate naming conventions.
            Business rule on MinDamage, can't be more than MaxDamage, or less than 1. If it is, default it to 1.
            minDamage – int
            maxDamage – int
            name – string
            bonusHitChance – int
            isTwoHanded - bool
        */

        //FIELDS
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;

        //add a _weapon type 
        //add a property
        //update constructor with parameter and assignment
        //add WeaponType to the ToString() 

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value < _maxDamage && value > 0)
                {
                    _minDamage = value;
                }
                   
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value;}
        }

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        //CONSTRUCTORS

        public Weapon (string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded,
            WeaponType type)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }

        public Weapon() { }

        public override string ToString()
        {
            return $"{Name}:\n" +
                $"Two-Handed: {(IsTwoHanded ? "Two" : "One")}-Handed {Type}" +
                $"Minimum Damage: {MinDamage}" +
                $"Maximum Damage: {MaxDamage}" +
                $"Bonus Hit Chance: {BonusHitChance}";
        }
    }//end class
}//end namespace
