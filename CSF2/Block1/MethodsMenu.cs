using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureLibrary;

namespace Block1
{
    internal class MethodsMenu
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Methods Menu - Creating our own methods!");
            Signature.Header("Custom Methods");

            /*
             * This program will let the user choose between various mini-programs
             * to run. It is set up inside a loop to repeat based on the user's choice.
             * 
             * All choices will call on a method where the real functionality is located.
             * Developers put functionality into methods to be more reusable or
             *sometimes just to tidy up their code
             *
             *Note: Static methods defined inside this class will now be able to be
             *called directly without using the class name.
             *Methods OUTSIDE the class but INSIDE the project will be
             *called from ClassName.MethodName().
             */

             //Loop around the menu
             bool exit = false; //COUNTER

            //Do While Loop - do inicates that we are guarenteed to enter the loop
            //at least once (do the thing, then continue to do it while the condition is met).
            do
            {

                //Print the menu
                Console.WriteLine("\nPlease choose a program:\n" +
                    "B) Break Change \n" +
                    "W) Water Weight \n" +
                    "N) Numbers\n" +
                    "T) Display Time\n" +
                    "C) Calendar App\n" +
                    "X) Exit");

                string choice = Console.ReadLine().ToUpper();
                Console.Clear(); //Clears the screen of the console.
                //Best used after ReadLine(). Don't use Clear () before
                //a ReadLine() or else the user will never get to see the menu.

                switch (choice)
                {
                    case "B":
                        Console.WriteLine("Break Change");
                        BreakChange();
                        break;
                    case "W":
                        Console.WriteLine("Water Weight");
                        WaterWeight();
                        break;
                    case "N":
                        Console.WriteLine("Numbers");
                        CountNumbers();
                        break;
                    case "T":
                        Console.WriteLine("Display Time");
                        DateTimeWarehouse.DisplayTime();
                        break;
                    case "C":
                        Console.WriteLine("Calendar App");
                        DateTimeWarehouse.CalendarApp();
                        break;
                    case "X":
                        Console.WriteLine("Thank you for using our program!");
                        exit = true;//UPDATE
                        break;

                        default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            } while (!exit);//CONDITION
            //The ! above states that it should look for a NOT true (false) value
            //could have also written:
            //exit == false;
            //exti != true;

        }//end main

        //Create the CountNumbers() method
        private static void CountNumbers()
        {
            //private means only usable within this file
            //void - doesn't return anything
            //No parameters, since we don't need additional info

            Console.Write("Enter a whole number to count to: ");
            int userNumber = int.Parse(Console.ReadLine());

            //i in a for loop is the default counter. i refers to "iterations"
            //we can change I to whatever we want -- as long as we are consistent.
            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }//end for
        }//end CountNumbers()

        private static void WaterWeight()
        {
            decimal water = 8.33m;
            Console.WriteLine("How many gallons of water do you have?");
            string userGallons = Console.ReadLine();
            decimal gallons = decimal.Parse(userGallons);
            Console.WriteLine();
            Console.WriteLine($"{userGallons} gallons of water weighs {gallons * 8.33m} pounds.");
            Console.WriteLine();
        }//end WaterWeight

        private static void BreakChange()
        {
            Console.WriteLine("Enter an amount of dollars and cents (ex. X.XX):");
            Console.Write("$");
            string money = Console.ReadLine();
            decimal total = decimal.Parse(money);
            Console.WriteLine();
            Console.WriteLine($"${total} can be broken down into:");
            decimal cents = total * 100;
            int coins = (int)cents;
            int quarters = coins / 25;
            coins %= 25;
            int dimes = coins / 10;
            coins %= 10;
            int nickels = coins / 5;
            coins %= 5;
            int pennies = coins;
            Console.WriteLine($"{quarters} quarters");
            Console.WriteLine($"{dimes} dimes");
            Console.WriteLine($"{nickels} nickels");
            Console.WriteLine($"{pennies} pennies");
        }//end BreakChange

    }//end class
}//end namespace
