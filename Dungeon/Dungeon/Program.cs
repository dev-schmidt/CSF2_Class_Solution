using DungeonLibrary;
using System.Runtime.InteropServices;

//The only requirement not implemented at present is testing.
//Outside of this, I would like to clean up the presentation
//in the console and make it more interesting.
namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //Start to play background music? (.wav) < 100MB
            //System.Windows.Extensions (NuGet package)
            Console.Title = "THE DUNGEON OF MUNDANE ADVERSARIES!";
            Console.WriteLine("-================THE DUNGEON OF MUNDANE ADVERSARIES!================-\n");
            Console.WriteLine("Welcome, adventurer! Your journey awaits!\n");

            # endregion

            Console.WriteLine("What be thy name?");
            string username = Console.ReadLine();
            Console.WriteLine();


            //TODO - variable to keep score
            //potential expansion, use "money" of some sort to let the user buy potions,

            int score = 0;
            //weapon object creation

            Weapon noodle = new("Wet Pool Noodle", 1, 8, 10, false, WeaponType.Noodle);
            Weapon candy = new("Baggie of Frozen Candy Corn", 1, 8, 10, true, WeaponType.Candy);
            Weapon spray = new("Spray Bottle", 1, 8, 10, false, WeaponType.Spray);
            Weapon slap = new("Slap", 1, 8, 10, false, WeaponType.Slap);
            Weapon sword = new("Big Scary Sword", 1, 8, 10, true, WeaponType.Sword);

            List<Weapon> weapons = new(){ noodle, candy, spray, slap, sword };
            Console.WriteLine("Enter a number to choose your tool of destruction: \n");

            int index = 1;
            foreach(var item in weapons)
            {
                Console.WriteLine(index + ") " + item.Name);
                index++;
            }

            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Weapon userWeapon = weapons[userChoice - 1];

            //TODO - allow the user to choose their race

            //Player object creation
            //Recommended expansion = player customization. let the user pick a name and a race.
            Player player = new($"\n{username}", 70, 15, 40, Race.Khajiit, userWeapon);

            //main game loop
            bool lose = false;
            do
            {
                //generate a room
                Console.WriteLine(GetRoom());
                //generate a monster
                Monster monster = GetMonster();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("In this room: " + monster.Name);
                Console.ResetColor();


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
                                Console.WriteLine($"\nYou defeated {monster.Name}!\n");
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
                            Console.WriteLine("Player Info: \n");
                            Console.WriteLine(player);
                            Console.WriteLine("You have defeated " + score + " monsters.");
                            break;
                        case ConsoleKey.M://monster
                            Console.WriteLine("Monster Info: \n");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.WriteLine("No one likes a quitter!");
                            lose = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou " +
                                "again.");
                            break;
                    }//end switch

                    //check player life. If they're dead, game over.
                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Dude, you died.\a");
                        lose = true;
                        Console.ResetColor(); 
                    }
                } while (!reload && !lose);
                //while reload and lose are BOTH FALSE, keep looping.
                #endregion

            }while (!lose);
            //while lose is false, keep looping.
            //output the final score
            Console.WriteLine("You have defeated " + score + $"monster{(score == 1? "." : "s.")}");
        }//end main

        //GetRoom() returns a string (reference magic 8 ball)
        //TODO rewrite the room descriptions
        private static string GetRoom()
        {
            //create a string[]
            string[] rooms = {
                "A modest cave in a gloomy bog marks the entrance to this dungeon. Within the cave lies a small, " +
                "dusty room. The floor is covered in dead insects, rubble, and large bones...\n",

                "Through a narrow gap in an eerie cliff side, you find a small dark room. Moss and large puddles accumulate " +
                "between the roots which snake accross the floor. Your torch allows you to see the remnants of sacks, crates " +
                "and caskets wasted and ravaged by time...\n",

                "Beneath the looming remains of a formidable tower lies a seemingly endless corridor of locked brass doors " +
                "large enough for five men to stand within their thresholds. As you continue down the corridor, beads of " +
                "sweat run from your brow as the temperture rises. Along with it, your suspicion that you are being led into a trap...\n",

                "Amidst a somber thicket stand several tall, stone statues of gods long forgotten. As you draw closer, you begin " +
                "to notice the crunching of tiny bits of rock growing louder with each step. Stopping to admire the handiwork of the statues " +
                "themselves, you freeze as you sense a presence behind you...\n",

                "The whine of hidden machinery drowns out your own thoughts as you enter a grimy hexagonal chamber. Manic, bloody " +
                "words cover the fractured and buckling walls. Rodents scurry from sight as a trap door slowly creaks open " +
                "with a horrid green glow...\n",

                "You seek refuge from the blizzard in a frozen ship-wreck by the mouth of the river. The smell of gun powder " +
                "is nauseating but you wish only to rest here for a short spell. Within your dreams, you lounge on the upper deck, " +
                "the summery sea breeze tickling at your bare feet. Suddenly, you are disturbed by an otherworldy wail..."
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
            //Monster m1 = new("Orc", 50, 40, 20, 1, 8, "A fierce orc weilding a rusty axe");
            //Monster m2 = new("Troll", 40, 50, 30, 1, 8, "A massive troll with a club.");
            //Monster m3 = new("Giant Enemy Spider", 70, 30, 10, 1, 8, "A giant spider with venomous fangs.");
            //Monster m4 = new("Goblin", 15, 25, 60, 1, 8, "A sneaky goblin with a sharp knife.");
            //Cyclist m5 = new();
            LaundryBasket m1 = new();
            SelfCheckout m2 = new();
            Cyclist m3 = new();
            Driver m4 = new();

            Monster[] monsters =
            {
                m1,
                m2,
                m3,
                m4
            };

            return monsters[new Random().Next(monsters.Length)];
        }
    }//end Program
}//end namespace