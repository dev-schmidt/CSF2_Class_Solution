using System;
using System.Collections.Generic;
using System.Collections;//non-type-safe collections
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class ReferenceCollections
    {
        static void Main(string[] args)
        {
            #region Employee Objects
            Employee e1 = new Employee(111111, "Mike", "Baxter", "Marketing Genius", new DateTime(2011, 1, 1), true);

            Employee e2 = new Employee(222222, "Kristin",
                "Baxter", "Restaurant Manager",
                new DateTime(2011, 1, 1), false);

            Employee e3 = new Employee(333333, "Ed",
                "Alzate", "Business Owner",
                new DateTime(2011, 1, 1), true);

            Employee e4 = new Employee(444444, "Kyle",
                "Anderson", "Gopher",
                new DateTime(2011, 1, 1), false);

            Employee e5 = new Employee(555555, "Chuck",
                "Larabee", "Security Manager",
                new DateTime(2011, 1, 1), true);
            #endregion

            #region Notes
            /*
             * Reference type collections store Key/Value pairs.
             * 
             * These types of collections are best suited for large collections where the order of entry and/or the indexed value do not matter. 
             * 
             * The key is a value that can uniquely identify an item in the collection. For example, a student ID could unquiely identify a student record. 
             * 
             * The value is the entire object that is being stored. 
             * 
             * Collection Initialization is available.
             * Looping through the Hashtable, the holding type is DictionaryEntry - both the key and the 
             * value go IN of type object.
             * 
             * Looping throughout the Dictionary, the holding type KeyValuePair - both the key and the value
             * are strongly typed in this collection.
             */
            #endregion

            //Collection Initialization Syntax
            Hashtable hEmps = new Hashtable()
            {
                // {key(unique), value(entire object) },
                { e1.ID, e1 },
                { e2.ID, e2 },
                { e3.ID, e3 },
                { e4.ID, e4 }
            };//don't forget the semi colon
            object o = e1;
            Console.WriteLine(((Employee)o).FirstName);
            Console.WriteLine("Employees Hashtable: \n\n");

            foreach (DictionaryEntry entry in hEmps)
            {
                //Console.WriteLine(entry.Value);   idk
                

                Console.WriteLine(((Employee)entry.Value).LastName);
                Console.WriteLine("-------------\n");

            }
            foreach (Employee e in hEmps.Values)
            {
                Console.WriteLine(e.FirstName);
            }
            hEmps.Add(e5.ID, e5);

            Console.WriteLine(hEmps[555555]);//ToString() still works, nothings else does unless we cast it

            #region Dictionary<TKey, TVal>  
            //typed key and typed value
            Dictionary<int, Employee> dEmps = new Dictionary<int, Employee>()
            //Dictionary<int, Employee> dEmps = new();
            {
                {e1.ID, e1 },
                {e2.ID, e2 },
                {e3.ID, e3 },
                {e4.ID, e4 },
                {e5.ID, e5 },
                
            };

            Console.WriteLine("Dictionary Collection");
            //the var keyword menas "implicitely" typed.
            //var should only be used when the datatype is obvious
            //KeyValuePair<int, Employee> takes longer to write
            foreach (var kvp in dEmps)
            {
                Console.WriteLine($"{kvp.Value.FirstName} {kvp.Value.LastName}");
            }
            foreach (Employee e in dEmps.Values) //you can replace Employee with var
            {
                Console.WriteLine(e.LastName);
            }

            //arrayName[array.Length]//ERROR - IndexOutOfRangeExeption (it is out of bounds for the array)
            hEmps.Remove(e5.ID);
            Console.WriteLine(((Employee)hEmps[e5.ID]));//no error, just an empty response
            //Console.WriteLine(((Employee)hEmps[e5.ID]).FirstName);//if we try to access the
            //properties of an object that doesn't exist, we get a NUllReferenceExeption

            int id = 555_555;
            if (hEmps.ContainsKey(id))
            {
                Console.WriteLine(((Employee)hEmps[e5.ID]).FirstName);
            }
            else
            {
                Console.WriteLine($"The requested ID, {id}, is invalid.");
            }
            #endregion
        }
    }
}
