using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    //Make it a public enum, add at least 5 races to the mix.
    //The intent is for the Player object to have a property of this type.
    //The enemies/monsters will NOT have this.
    public class Race
    {
        enum CharacterRace
        {
            Orc,
            Human,
            Elf,
            Dwarf,
            Khajiit
        }


        static void Main(string[] args)
        {
            Console.WriteLine("The race I have chosen is " +
              CharacterRace[] races = Enum.GetValues<CharacterRace>();
            foreach (CharacterRace item in races)
            {
                Console.WriteLine($"{(int)item + 1} - {item}");
            }
            Console.Write("\nChoose a race from the list above (enter the number only): " +
                "");
            int userChoice = int.Parse( Console.ReadLine());
            CharacterRace userRace = (CharacterRace)(userRace - 1);
            switch (userChoice)
            {
                case CharacterRace.Orc:
                    Console.WriteLine("\nIt ain't easy being green.");
                    break;
                case CharacterRace.Human:
                    Console.WriteLine("\nHuman? You're already a human failure!");
                    break;
                case CharacterRace.Elf:
                    Console.WriteLine("\nOooh, you're one of those guys...");
                    break;
                case CharacterRace.Dwarf:
                    Console.WriteLine("\nYes dude! Dwarves are sick.");
                    break;
                case CharacterRace.Khajiit:
                    Console.WriteLine("\nMay your road lead you to warm sands.");
                    break;

            }//end switch
        }//end main
    }//end class
}//end namespace
