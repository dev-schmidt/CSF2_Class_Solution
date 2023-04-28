using DungeonLibrary;
using System.Runtime.InteropServices;

namespace Dungeon
{
    internal class Program
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
            //potential expansion, use "money" of some sort to let the user buy potions,
            //weapons, whatever.
            int score = 0;
            //TODO - weapon object creation

            Weapon wep = new("Long Sword", 1, 8, 10, false, WeaponType.Sword);
            //POTENTIAL EXPANSION = show the user a list of weapons and let them pick one. Or, assign one
            //randomly.

            //TODO - Player object creation
            //Recommended expansion = player customization. let the user pick a name and a race.
            Player player = new("Leeroy Jenkins", 70, 15, 40, Race.Elf, wep);

            //main game loop
            bool lose = false;
            do
            {
                //generate a room
                Console.WriteLine(GetRoom());
                //TODO - generate a monster
                Monster monster = GetMonster();
                Console.WriteLine("In this room: " + monster.Name);


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
                            #region possible expansion - racial/weapon bonus
                            //give certain races or characters with a certain weapon an advantage.
                            //if the playter race is dark elf, then combat.doattack(player, monster)
                            #endregion
                            Combat.DoBattle(player, monster);

                            //check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster.Name}!\n");
                                Console.ResetColor();
                                reload = true;
                                score++;
                                //POSSIBLE EXPANSION = combat rewards - money, weapons, potions etc.
                            }

                            break;
                        case ConsoleKey.R://run away
                            Console.WriteLine("Run away!");
                            //Attack of Opportunity
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case ConsoleKey.P://player
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine("You have defeated " + score + "monsters.");
                            break;
                        case ConsoleKey.M://monster
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
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

                    //check player life. If they're dead, game over.
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude, you died.\a");
                        lose = true;
                    }
                } while (!reload && !lose);
                //while reload and lose are BOTH FALSE, keep looping.
                #endregion

            }while (!lose);
            //while lose is false, keep looping.
            //output the final score
            Console.WriteLine("You have defeated " + score + $"monster{(score == 1? "." : "s.")}");
        }//end main

        //TODO GetRoom() returns a string (reference magic 8 ball)
        private static string GetRoom()
        {
            //create a string[]
            string[] rooms = {
                "A modest murky cave in a gloomy bog marks the entrance to this dungeon. Beyond the murky cave lies a small, " +
                "dusty room. The floor is covered in dead insects, rubble, and large bones...",

                "Through a narrow gap in an eerie cliff side, you find a small dark room. Moss and large puddles accumulate " +
                "between the roots which snake accross the floor. Your torch allows you to see the remnants of sacks, crates " +
                "and caskets wasted and ravaged by time.",

                "Beneath the looming remains of a formidable tower lies a seemingly endless corridor of locked brass doors " +
                "large enough for five men to stand within their thresholds. As you continue down the corridor, beads of " +
                "sweat run from your brow as the temperture rises. Along with it, your suspicion that you are being led into a trap",

                "Amidst a somber thicket stand several tall, stone statues of gods long forgotten. As you draw closer, you begin " +
                "to notice the crunching of tiny bits of rock growing louder with each step. Admiring the handiwork of the statues " +
                "themselves, you freeze as you stare into undeniably living stone eyes.",

                "The whine of hidden machinery drowns out your own thoughts as you enter a grimy hexagonal chamber. Manic, bloody " +
                "words cover the fractured and buckling walls. Rodents scurry from sight as a trap door slowly creaks open " +
                "with a slimy green glow.",

                "You seek refuge from the blizzard in a frozen ship-wreck by the mouth of the river. The smell of gun powder " +
                "is nauseating but you wish only to rest here for a short spell. Within your dreams, you lounge on the upper deck, " +
                "the summery sea breeze tickling at your bare feet. Suddenly, you are disturbed by an otherworldy wail, and look up to " +
                "see a narrow silhouette looming in the crow's nest, the setting sun visible between it's exposed ribs."
                };
            //rng
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            //return a room using the rng
            return rooms[index];

            //return rooms[new Random().Next(rooms.Length)];


        }//end GetRoom()

        private static Monster GetMonster()
        {
                         //name, hitChnc,block,maxLife,mindmg,mxdmg,dscrpt
            Monster m1 = new("Orc", 50, 40, 20, 1, 8, "A fierce orc weilding a rusty axe");
            Monster m2 = new("Troll", 40, 50, 30, 1, 8, "A massive troll with a club.");
            Monster m3 = new("Giant Enemy Spider", 70, 30, 10, 1, 8, "A giant spider with venomous fangs.");
            Monster m4 = new("Goblin", 15, 25, 60, 1, 8, "A sneaky goblin with a sharp knife.");
            Cyclist m5 = new();

            Monster[] monsters =
            {
                m1,m1,
                m2,
                m3,
                m4, m4, m4, m4,
                m5,
                
            };

            return monsters[new Random().Next(monsters.Length)];
        }
    }//end Program
}//end namespace