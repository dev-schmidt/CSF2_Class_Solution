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
            Weapon w1 = new Weapon("Bow", 1, 5, 0, true, WeaponType.Bow);
            Player player = new Player("Gavino", 80, 47, 100, Race.Khajiit, w1);
            Monster m1 = new Monster("Dragon", 50, 40, 20, 1, 8, "He is scary");


            while (player.Life > 0 && m1.Life > 0)
            {
                Combat.DoBattle(player, m1);
                Console.WriteLine("Player Life: " + player.Life);
                Console.WriteLine("Monster Life: " + m1.Life);
                Console.ReadKey();
                Console.Clear();
            }
            if (player.Life <= 0)
            {
                Console.WriteLine("Dude, you lost");
            }

        }
    }
}
