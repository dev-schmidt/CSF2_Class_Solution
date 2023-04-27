using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {

        //FIELDS
        private double _gpa;

        //PROPERTIES
        public string Name { get; set; }
        public int ID { get; set; }
        public Dept Major { get; set; }
        public string ContactInfo { get; set; }

        //GPA must be between 0 and 4
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    _gpa = value;
                }
                else
                {
                    _gpa = 0;
                }
                //I have just an if and an else, no else ifs.
                //I am doing the same thing in each block. Assigning something to _gpa
                _gpa = (value >= 0 && value <= 4) ? value : 0;
                //(condition to be evaluated) ? ifTrue : elseFalse;
            }
        }

            //CONSTRUCTORS
            public Student(string name, int id, double gpa, Dept major, string contactInfo)
        {
            Name = name;
            ID = id;
            GPA = gpa;
            Major = major;
            ContactInfo = contactInfo;
        }


        //METHODS
        public override string ToString()
        {
            return Name;
        }
    }
}
