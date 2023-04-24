using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class Magic8Ball
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Console.WriteLine("What is your question?");
                Console.ReadLine();
                Console.Clear();

                Random randomNo = new Random();
                int magic = randomNo.Next(21);
                int result = magic;

                switch (result)
                {
                    case 0:
                        Console.WriteLine("It is certain.");
                        break;
                    case 1:
                        Console.WriteLine("As I see it, yes.");
                        break;
                    case 2:
                        Console.WriteLine("Reply hazy, try again.");
                        break;
                    case 3:
                        Console.WriteLine("Don't count on it.");
                        break;
                    case 4:
                        Console.WriteLine("It is decidedly so.");
                        break;
                    case 5:
                        Console.WriteLine("Most likey.");
                        break;
                    case 6:
                        Console.WriteLine("Ask again later.");
                        break;
                    case 7:
                        Console.WriteLine("My reply is no.");
                        break;
                    case 8:
                        Console.WriteLine("Without a doubt.");
                        break;
                    case 9:
                        Console.WriteLine("Outlook good.");
                        break;
                    case 10:
                        Console.WriteLine("Better not tell you now.");
                        break;
                    case 11:
                        Console.WriteLine("My sources say no.");
                        break;
                    case 12:
                        Console.WriteLine("Yes, definitely.");
                        break;
                    case 13:
                        Console.WriteLine("Yes.");
                        break;
                    case 14:
                        Console.WriteLine("Cannot predict now.");
                        break;
                    case 15:
                        Console.WriteLine("Outlook not so good.");
                        break;
                    case 16:
                        Console.WriteLine("You may rely on it.");
                        break;
                    case 17:
                        Console.WriteLine("Signs point to yes.");
                        break;
                    case 18:
                        Console.WriteLine("Concentrate and ask again.");
                        break;
                    case 19:
                        Console.WriteLine("Very doubtful.");
                        break;

                }//END switch (result)


            }while(!exit);
        }//END main
    }//END class
}//END namespace
