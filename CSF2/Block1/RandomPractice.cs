using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class RandomPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice with the Random class \n\n");

            #region Random Notes

            /*
             * Random is a class in the framework. It has an instance
             * method, Next(), which generates the next random number
             * in a desired range (if a range is specified).
             * 
             * As an "instance" method, you must have instantiated
             * (initialized) a Random object (variable) of the Random
             * type in order to call it.
             * Examples: .ToUpper(), .ToLower(), .AddDays()
             * 
             * The alternative to instance methods are static methods,
             * which requires you to call the ClassName where it was
             * defined to access it.
             * Examples: int.Parse(), Array.Sort(), Console.WriteLine()
             * 
             * 
             */

            #endregion

            //create a new random object
            Random randomNbrGen = new Random();

            int randomNumber = randomNbrGen.Next();

            Console.WriteLine($"{randomNumber:n0}");//n0 makes it so there are no decimal

            //The Next() method is overloaded to accept 3 different perameter sets:
            //1) No parameters. Returns an int from - to ~2 Billion
            //2) int for MaxValue. Exclusive upper bound (defaults MinValue to 0)
            //3) int for MinValue and int for MaxValue.
            //MinValue is INCLUSIVE. MaxValue is EXCLUSIVE

            //display a random value from 0 to 50
            int nbr0and50 = randomNbrGen.Next(51);
            Console.WriteLine("A number from 0-50 is " + nbr0and50);

            //display a number from 50-105
            //For that, we will need to provide MinValue and MaxValue
            int nbr50and105 = randomNbrGen.Next(50, 106);
            Console.WriteLine("A number from 50-105 is " + nbr50and105);

            //create a new random object to call the Next() method
            //and generate a number from 1 - 20 and display it
            Random rand = new Random();
            int rand1 = rand.Next(1, 21);

            Console.WriteLine("You rolled a " + rand1 + "!");

            //an example of "seeding" the Random
            Random rand2 = new Random(6);
            int nbr100to200 = rand2.Next(100, 201);
            Console.WriteLine("The number from 100 to 200 is " + nbr100to200);
        }
    }
}
