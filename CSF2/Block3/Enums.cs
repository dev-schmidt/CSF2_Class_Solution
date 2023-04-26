using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureLibrary;

namespace Block3
{
    internal class Enums
    {
        /*
        * Enums (aka Enumerators) are a data type that hold a list of uniquely-named constants. 
        * You cannot create an enum directly through the VS interface. Instead, you create a class and then adapt it. 
        * When defining values for an enum, they MUST be single values with NO SPACES in a COMMA-SEPARATED list. 
        * You can optionally assign numeric values to represent each item in the enum. These serve the same purpose as index numbers, to look up the data. 
        * If you do not assign each item a numeric value, the compiler will be default. It uses 0 based counting.
        * 
        * Example: An enum would be a great structure to hold card suits (Spades, Clubs, Hearts, Diamonds)
        * 
        * Enums are different from the collections we have been learning. In fact, they are not a collection at all. Instead, each enum is its own custom data type. 
        * This custom data type holds the list of constants as one value. 
        */

        //we can use values from an enum similarly to how we use them with normal variables
        static void Main(string[] args)
        {
            Signature.Header("Enums!");


            Console.WriteLine("My favorite classical monster is " + ClassicMonsters.Sasquatch);

            //Because enums are NOT collections, we cannot iterate through them in a foreach directly.
            //However, we can use a .GetValues() static method from the enum class to pull
            //all of the values of a vertain enum type into an array.
            ClassicMonsters[] monsters = Enum.GetValues<ClassicMonsters>();
            foreach (ClassicMonsters item in monsters)
            {
                Console.WriteLine($"{(int)item + 1} - {item}");
            }
            Console.Write("\nChoose a classic monster from the list above (enter the number only):" +
                "");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            ClassicMonsters userMonster = (ClassicMonsters)(userChoice - 1);
            switch (userMonster)
            {
                case ClassicMonsters.Frankenstein:
                    Console.WriteLine("\nHe's barely holding the pieces together.");
                    break;
                case ClassicMonsters.Cthulu:
                    break;
                case ClassicMonsters.Dracula:
                    Console.WriteLine("\nDoes he sparkle too?");
                    break;
                case ClassicMonsters.Chupacabra:
                    break;
                case ClassicMonsters.Sasquatch:
                    break;
                case ClassicMonsters.Zombie:
                    break;
                case ClassicMonsters.Troll:
                    break;
                case ClassicMonsters.Orc:
                    break;
                default:
                    break;
            }

        }

    }
}
