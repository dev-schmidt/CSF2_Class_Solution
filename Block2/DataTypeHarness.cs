using SignatureLibrary;
using Charity;
using System.Net.WebSockets;

namespace Block2
{
    internal class DataTypeHarness
    {
        static void Main(string[] args)
        {
            Signature.Header("Data Type Test Harness");

            //complex datatypes need to be "Constructed". To do this, we use
            //the "new" keyword.
            //the new keyword calls the constructor method (a specialized method used to
            //"construct" an object of "this" type).
            //If you do not define a custom constructor method, you get a default, parameterless one.
            Volunteer v1 = new Volunteer();
            //we can access the properties and set values using the accessors (getters and setters).
            v1.Name = "Spider-Man";
            v1.IsActive = true;
            v1.YearsOfService = 12;

            Console.WriteLine($"{v1.Name} has volunteered for {v1.YearsOfService} years.\n" +
                $"{(v1.IsActive ? "Active" : "Inactive")}" );
            //MINI LAB
            //Create another volunteer object, populate its fields, then display them.
            
            Console.WriteLine();
            Volunteer v2 = new Volunteer();

            v2.Name = "Master Chief";
            v2.IsActive = true;
            v2.YearsOfService = 49;

            Console.WriteLine($"{v2.Name} has volunteered for {v2.YearsOfService} years.\n" +
                $"{(v2.IsActive ? "Active" : "Inactive")}");

            //object initialization syntax - reuires a default, parameterless ctor to work
            Organization o1 = new Organization();
            {
                o1.Name = "Goofy Goober Inc.";
                o1.NbrOfMembers = 12;
                o1.Revenue = 3;
                o1.DateFounded = new DateTime(1995, 08, 01);
            };

            Console.WriteLine($"{o1.Name}\nRevenue: {o1.Revenue:c}\nMembers: {o1.NbrOfMembers:n0}\nFounded: {o1.DateFounded:d}");

            DateTime dateCreated = new DateTime(1982, 11, 7);
            Organization o2 = new Organization("Justice League",dateCreated, 10, 750_231.89m);

            Console.WriteLine($"{o2.Name}\nRevenue: {o2.Revenue:c}\nMembers: {o2.NbrOfMembers:n0}\nFounded: {o2.DateFounded:d}");

            Console.WriteLine(o1);
            //complex objects don't play well with strings.
            //.ToString() for complex objects is .GetType() which returns Namespace.ClassName

            Signature.Footer();
        }//end main
    }//end class
}//end namespace