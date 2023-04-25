using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    //ONLY the first class in a class library is public
    //all new classes default to internal.
    //if we want to use this class, MAKE IT PUBLIC!
    public class Organization
    {
        //the 4 parts of a class are called "class members."
        //mnemonic
        //Funny People Collect Monkeys

        //Fields
        //ALWAYS private. _camelCase
        private string _name;
        private DateTime _dateFounded;
        private int _nbrOfMembers;
        private decimal _revenue;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public DateTime DateFounded
        {
            get { return _dateFounded; }
            set { _dateFounded = value; }
        }//end DateFounded

        public decimal Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }//end

        //business should be defined after all the other props.

        public int NbrOfMembers
        {
            //default get, but a custom set
            get { return _nbrOfMembers; }
            set
            {
                //if the value passed is greater than zero, we're good.
                //if they try to set a number of members less than zero, default it to 1.
                if (value >= 0)
                {
                    _nbrOfMembers = value;
                }
                else
                {
                    _nbrOfMembers = 1;
                }
            }//end set
        }
        //Constructors
        /*
         * COnstructors (CTORS) are specialized methods used to create an object of "this" type.
         * We call CTORS using the "new" keyword. The CTOR ALWAYS has the same name as the DataType
         * and NO return type is listed, not even void.
         * 
         * If you DON'T create your own, you get the default, unqualified CTOR for free.
         * When you DO create your own, you lose the free "unqualified" CTOR, unless you rebuild it.
         */

        //"Fully Qualified" constructor - Accepts parameters for each of the object's properties.
        public Organization(string name, DateTime dateFounded, int nbrOfMembers, decimal revenue)
        {
            //assignment
            //property = parameter
            //PascalCase = camelCase
            Name = name;
            DateFounded = dateFounded;
            NbrOfMembers = nbrOfMembers;
            Revenue = revenue;

            //by performing this assignment, the properties (gatekeepers) can then perform their 
            //duty of assigning appropriate values to the object's fields (private) using any
            //business rules defined for the property.
        }//end fully qualified CTOR
        //"Unqualified" CTOR - allows the creation of an object without any parameters.
        public Organization() { }
        //Methods
        //Actions realted to or utilizing the properties of this object
        public override string ToString()
        {
            //return base.ToString();
            //the above is the default method for outputting a complex object
            //It returns GetType(), which returns Namespace.ClassName
            return $"Organization: {Name}\nRevenue: {Revenue:c}\n Members {NbrOfMembers:n0}\n Founded: {DateFounded:d}";
        }

    }//end class
} //end namespace
