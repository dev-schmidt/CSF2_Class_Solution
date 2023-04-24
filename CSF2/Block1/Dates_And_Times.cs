namespace Block1
{
    internal class DatesAndTimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime DataType");

            #region DateTime Notes

            /*
             * DateTime is a class from the framework
             * that we can use as a datatype to create
             * variables that hold date and time info.
             * 
             * Time defaults to 12:00 AM (00:00:00)
             * 
             * This is a complex datatype, unlike bools,
             * ints, etc. which are all instrinsic datatypes.
             * 
             * Complex datatypes often need the "new" keyword
             * and a constructor method, which has the same name
             * as the datatype, followed by parens.
             * 
             * One example we've already done:
             * string[] colors = new string[5];
             * 
             * Syntax for DateTime:
             * DateTime x = new DateTime();
             * 
             * You can use "format specifiers" on Datetimes.
             * (d, D, M, t, T, f, F)
             */

            #endregion

            //Create a DateTime object
            DateTime graduationDay = new DateTime(2023, 07, 28);

            //Test the format specifiers
            Console.WriteLine("Graduation day is {0:d} as a short date.", graduationDay );
            Console.WriteLine("Graduation day is {0:D} as a long date.", graduationDay );
            Console.WriteLine("Graduation day is {0:M} as Month Day.", graduationDay );
            Console.WriteLine("Graduation day is {0:t} as a short time.", graduationDay );
            Console.WriteLine("Graduation day is {0:T} as a long time.", graduationDay );
            Console.WriteLine("Graduation day is {0:f} as a short full datetime.", graduationDay );
            Console.WriteLine("Graduation day is {0:F} as a long full datetime.", graduationDay );
            Console.WriteLine("Graduation day is {0} with no formatting.", graduationDay ); //Short date + long time

            //create a new DateTime object
            DateTime bDay = new DateTime(1996, 11, 27);

            Console.WriteLine("Birthday was {0:D}", bDay);

            //Let's find 7 days after bDay.
            //DateTime weekAfterDate = bDay + 7;  //We can't add a DateTime and an int

            //DateTime weekAfterDate = new DateTime(1996, 11, 27 + 7);
           //Console.WriteLine("A week after birthday was {0:D}", weekAfterDate);
           //the above code works for some dates, but it will fail if the day value
           //exeeds the number of days for that month.

           //To explore an object with Intellisense, use a period
           //to explore a method with Intellisense, use parens.

            DateTime weekAfterDate = bDay.AddDays(7);

            Console.WriteLine("One week after birthday was {0:D}", weekAfterDate);

            //Console.WriteLine("3 days before the date: {0:D}", bDay.Subtract(3));
            //Subtract() won't work for subtracting 3 days from our date.
            //It wants a time span for that method
            Console.WriteLine("3 days before the date: {0:D}", bDay.AddDays(-3));
            //to subtract days, we still use AddDays() -- just with a negative number

            //you can determine the current date (DateTime.Today) or the current
            //date and time (DateTime.Now).

            //Very useful when we start recording changes to information in our
            //databases (typically, we record a timestamp with any change.)

            Console.WriteLine("Current date, dynamically generated, is {0:D}\n", DateTime.Today);

            Console.WriteLine("Current full date and time: {0:F}", DateTime.Now);

            DateTime anotherBirthday = new DateTime(2018, 04, 01);

            DateTime upcomingBirthday = anotherBirthday.AddYears(6);

            Console.WriteLine("The next birthday will occur on: {0:D}", upcomingBirthday);

            DateTime futureBirthday = new DateTime(2023, 09, 21);

            //Console.WriteLine("The days until your next birthday: " + 
                //"{0:dd\\ hh\\:mm\\:ss}\n", DateTime.Now.Subtract(futureBirthday));

            //TimeSpan objects are useful for determining the amount of time
            //between two DateTime objects.

            DateTime clockedIn = new DateTime(2013, 10, 17, 20, 30, 0);
            DateTime clockedOut = new DateTime(2013, 10, 18, 4, 31, 1);

            //TimeSpan timeWorked = clockedOut.Subtract(clockedIn);
            TimeSpan timeWorked = clockedOut - clockedIn; //natural language works!

            Console.WriteLine("\nOur worker was on the clock for " +
                "{0} hours {1} minute{2}!",
                timeWorked.Hours,
                timeWorked.Minutes,
                timeWorked.Minutes == 1 ? "" :"s"); //Ternary Operator (it's like a mini if/else)


        }//end main
    }//end class
}//end namespace