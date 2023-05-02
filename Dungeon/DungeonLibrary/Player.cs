using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //MAKE IT PUBLIC!
    //make it a child of Character
    public sealed class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Player (string name, int hitChance, int block, int maxLife, //character params
            Race playerRace, Weapon equippedWeapon) //player params
            : base(name,hitChance, block, maxLife)//send ONLY character params back to the parent
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
                case Race.Argonian:
                    raceDescription = "A sssssuperb choicccce.";
                    break;
                case Race.Elf:
                    raceDescription = "Not the kind that makes cookies in the forrest.";
                    break;
                case Race.Human:
                    raceDescription = "This is the most boring choice.";
                    break;
                case Race.Khajiit:
                    raceDescription = "Let's just say he's a cat person.";
                    break;
                case Race.Orc:
                    raceDescription = "He likes to smash things!";
                    MaxLife += 10;
                    break;
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
