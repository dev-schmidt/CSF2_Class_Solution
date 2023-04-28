using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public
    public class Combat
    {
        //this is not a datatype class so we will not have fields, properties or instructors.

        //Hande one side of an attack.
        public static void DoAttack(Character attacker, Character defender)
        {
            //Adjust the hit chance
            int chance = attacker.CalcHitChance() - defender.CalcBlock();
            //roll a random number 1-100
            Random rand = new Random();
            int roll = rand.Next(1, 101);
            //the attacker "hits" if the roll is less than the adjusted hit chance
            if (roll <= chance)
            {
                //Calculate the damage
                int damage = attacker.CalcDamage();
                #region potential expansion - crits
                //if Roll == 100, then increase damage by something.
                //if they fail, with a 1, maybe hurt the attacker instead of the defender
                #endregion
                //subtract that damage from the defender's life.
                defender.Life -= damage;
                //output the result.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else //the attacker missed
            {
                Console.WriteLine($"{attacker.Name} missed!");
                //Console.WriteLine( "Roll: " );
                //
            }
        }
        //handle one round of battle, attacks from both sides.
        public static void DoBattle(Player player, Monster monster)
        {
            //For this example, we will grant the player "initiative" by default.
            DoAttack(player, monster);
            //if the monster survives, let them attack
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}
