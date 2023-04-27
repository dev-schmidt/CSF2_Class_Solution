using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //MAKE IT PUBLIC!
    //make it a child of Character
    public class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Player (string name, int hitChance, int block, int maxLife, Race playerRace, Weapon 
            equippedWeapon) 
            : base(name, hitChance, block, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Possible Expansion - Racial Bonuses
            //he put the switch (PlayerRace) here //switch tabtab. put playerRace in there and it builds it out
            //case Race.Human:
            //MaxLife += 10;
            //break;

            //in program cs, you will have to show the user a list of races and let them pick one.
            //The reference for this is in your csf2 Enums.cs for ClassicMonsters
            #endregion
        }//end ctor

        public override string ToString()
        {
            string raceDescription = "";
            switch (PlayerRace)
            {
                //case Race.Human
                      //raceDescription = "Elf"
                      //break;
                default:
                    break;
            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" +
                $"Description: \n{raceDescription}";
        }
        public override int CalcDamage()
        {
           return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }
        public override int CalcHitChance()
        {
            //              HitChance + EquippedWeapon.BonusHitChance;
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
            //HitChance - Block = chance that you hit.
            //roll a random number between 1 and 100. If it's LESS than the hit chance, we hit.
        }
    }
}
