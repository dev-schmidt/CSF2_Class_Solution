using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    //an internal class can only be used inside this assembly
    //internal is the default and doesn't need to be typed out
    /// <summary>
    /// Triple slashes in an XML Comment. This appears in intellisense to help us figure out what this class does
    /// Deals with various date and time related methods/calculations. Beware using special symbols in XML comments
    /// because they can cause issues.
    /// </summary>
    internal class DateTimeWarehouse
    {
        //this class does NOT get an SVM. It isn't going ot run on it's own, we're just going to use
        //this document to store some methods related to Dates and Times

        /// <summary>
        /// Displays the current time.
        /// </summary>
        internal static void DisplayTime()
        {
            Console.WriteLine($"{DateTime.Now:t}");
        }//end DisplayTime()
        //In a class, every method must have a unique name OR list of parameters.
        //Methods with the same name but different parameters become OVERLOADED

        /// <summary>
        /// Displays a given date in custom formatting.
        /// </summary>
        /// <param name="datetoDisplay">Date to display</param>
        internal static void DisplayTime(DateTime datetoDisplay)//Additional parameters are included, comma separated
        {
            //Which datatypes you pass will determine which overload you use.
            Console.WriteLine($"{datetoDisplay:dddd\\, MMM\\ dd\\, yyyy\\ hh\\:mm}");
        }//end DisplayTime overload

        /// <summary>
        /// Basically, this is just AddDays(), but way more fun.
        /// </summary>
        /// <param name="days">Number of days to add to Today. Use a negative number to subtract.</param>
        /// <returns>Returns the date calculated from Today.</returns>
        internal static DateTime CalculateDate(int days)
        {
            //when you have a return type listed, you need to create the object to return.
            DateTime result = DateTime.Now.AddDays(days);
            return result;//returns the calculated date to whatever praogram called this method.
        }//end calc date

        internal static void CalendarApp()
        {
            //askt eh user for a number of days
            Console.Write("Please type a number of days from today to display: ");//""
            string? strDays = Console.ReadLine() ?? "0";//COALESCE operator. ALlegedly replaces null values with some other value
            int days = int.Parse(strDays);//string s - parameter, strDays is the argument.
            //calculate the new date
            DateTime newDate = CalculateDate(days);
            //display the new date
            DisplayTime(newDate);

            //refactor
            DisplayTime(CalculateDate(int.Parse(Console.ReadLine() ?? "0")));

        }//end calendar app
    }//end class
}//end namespace
