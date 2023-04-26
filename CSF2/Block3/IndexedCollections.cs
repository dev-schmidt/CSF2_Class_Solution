using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureLibrary;//added for non-generic collections.

namespace Block3
{
    internal class IndexedCollections
    {
        static void Main(string[] args)
        {
            /*
            * Collections are groups of objects stored together under one name. 
            * Some examples: Array[], ArrayList[], or List<> (aka "Typed List"). 
            * All of these collections store data that can be retrieved using an index number. 
            * Additionally, some of these collection types are Generic, meaning they are type safe. 
            * Alternatively, one is a non-generic meaning that it is not type safe. 
            * 
            * Array:
            * - Type safe (any type, but only one type per array) / Generic
            * - Length is fixed at declaration (can NOT change
            *  the length later in code)
            *  
            * ArrayList:
            * - Not type safe /Non-Generic
            * - It can store values of any datatype into 
            * any index in the collection. Mixing datatypes is acceptable.
            * This can cause issues, however, since the values are stored 
            * as type Object. This is called BOXING. To use the values as
            * their original datatype you have to cast them back to their
            * original datatype. This is called UNBOXING.
            * - Length IS expandable (CAN add/remove indexes after
            *  creation)
            * - NAMESPACE: System.Collections;
            * 
            * List (aka Typed List or List of T):
            * - Type safe (just like arrays) / Generic
            * - Expandable (CAN add/remove indexes after creation)
            * */

            Signature.Header("Indexed Collections");
            #region Arrays

            string[] colors = { "Blue", "Green", "Red", "Black", "Lavender" };
            //length is 5
            //first index 0
            //last index 4

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }//end foreach

            Array.Sort(colors);
            Console.WriteLine();
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            #endregion

            #region ArrayLists
            Console.WriteLine("\nARRAY LISTS!\n");
            ArrayList aList = new ArrayList();//an empty ArrayList
            //These are expandable, so we can add or remove items from it
            aList.Add("Triforce");
            //The string value is being implicitely cast as type Object, which is then added to the list.
            //This is BOXING
            aList.Add(42);
            aList.Add(new DateTime(2024, 1, 1));
            //Console.WriteLine(aList[1] * 2);
            //This is the downside to using non-generic collections. We get lots of flexibility
            //with what we can store, because EVERYTHING is an Object. But, when we
            //try to use those stored values, they are no longer stored as theri specific type.
            //we will need to cast them back (explicitely) to their original, more specific datatype.
            Console.WriteLine((int)aList[1] * 2);//UNBOXING
            Console.WriteLine($"{(DateTime)aList[2]:d}");
            Console.WriteLine(((string)aList[0]).ToUpper());

            //Insert () lets us add values to the collection at a specified index.
            aList.Insert(1, "Ganon");//instance method. called form an "instance" of an ArrayList object.
            //aList[4] = "Zelda";
            for (int i = 0; i < aList.Count; i++) //.Count instead of .Length
            {
                Console.WriteLine($"{aList[i]} is at the index of {i}");
            }//end for
            int index = 0;

            //aList.Sort();//Instance, unlike Array.Sort(), which is static.
            #endregion

            #region List<T>
            Console.WriteLine("\n\n TYPED LIST\n\n");
            //SYNTAX: List<DataType> listName = new List<DateType>();
            int x = 1000;
            List<int> scores = new List<int>()
            {//collection initialization syntax
                12, 29, 0, 44, x, x, x
            };
            scores.Add(100);
            Console.WriteLine(scores.Count);
            //.Insert(), .Sort()
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }

            //removing items
            scores.RemoveAt(2);                 
            //.Remove(value) removes the FIRST occurance of that value in the collection
            //.RemoveAt(index) removes a specific index, in this case the 0
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }

            #endregion

            Signature.Footer();
        }
    }
}
