using System;
using DungeonLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dungeon
{
    internal class testHarness
    {
        static void Main(string[] args)
        {
            Character c1 = new Character("Gavino", 100 , 100 , 50 , 30 );
            Console.WriteLine(c1);

            Weapon w1 = new Weapon("3-4 dozen claymore mines", 10, 40, 9, false);
                Console.WriteLine(w1);
            
        }
    }
}
