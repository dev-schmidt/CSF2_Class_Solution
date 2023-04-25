using System.Runtime.InteropServices;

namespace Dungeon
{
    internal class DungeonClassCode
    {
        static void Main(string[] args)
        {
            #region Introduction
            //Start to play background music? (.wav) < 100MB
            //System.Windows.Extensions (NuGet package)
            Console.Title = "DUNGEON OF DOOM!";
            Console.WriteLine("Welcome, adventurer! Your journey awaits!");

            # endregion

            //TODO - variable to keep score

            //TODO - weapon object creation

            //TODO - Player object creation

            //main game loop
            bool lose = false;
            do
            {
                //generate a room
                Console.WriteLine(GetRoom());
                //TODO - generate a monster

                #region Main Menu Loop
                //Encounter/Menu Loop
                bool reload = false;
                do
                {
                    //print the menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");
                    //caputure their selection
                    ConsoleKey choice = Console.ReadKey(true).Key;
                    //clear the console
                    Console.Clear();
                    //switch
                    switch (choice)
                    {
                        case ConsoleKey.A://TODO Combat
                            break;
                        case ConsoleKey.R://TODO run away
                            Console.WriteLine("Run away!");
                            reload = true;
                            break;
                        case ConsoleKey.P://TODO player
                            break;
                        case ConsoleKey.M://TODO monster
                            break;

                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("No one likes a quitter!");
                            lose = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou" +
                                "again.");
                            break;
                    }//end switch

                    //TODO check player life. If they're dead, game over.
                } while (!reload && !lose);
                //while reload and lose are BOTH FALSE, keep looping.
                #endregion

            }while (!lose);
            //while lose is false, keep looping.
            //TODO output the final score
        }//end main

        //TODO GetRoom() returns a string (reference magic 8 ball)
        private static string GetRoom()
        {
            //create a string[]
            string[] rooms = {
                "Room 1",
                "Room 2",
                "Room 3",
                "Room 4",
                "Room 5",
                "Room 6"
                };
            //rng
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            //return a room using the rng
            return rooms[index];

            //return rooms[new Random().Next(rooms.Length)];


        }//end GetRoom()
    }//end Program
}//end namespace