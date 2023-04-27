using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    //MAKE IT PUBLIC
    public class Course
    {
        //no business rules, no fields needed

        //PROPERTIES

        public string Name { get; set; }
        public Dept Department { get; set; }
        //Each course may have multiple students or multiple books.
        public List <Student> Roster { get; set; }
        public List<Book> Curriculum { get; set; }
        public double CreditHours { get; set; }

        //CONSTRUCTOR
        public Course(string name, Dept department, List<Student> roster,
            List<Book> curriculum, double creditHours)
        {
            Name = name;
            Department = department;
            Roster = roster;
            Curriculum = curriculum;
            CreditHours = creditHours;
        }// Fully Qualified CTOR - one parameter for every property

        public override string ToString()
        {
            //Running Variable
            //created outside of the loop, update inside the loop, and used after the loop.
            string strRoster = "";
            string StrCurriculum = string.Empty;
            foreach (Student s in Roster)
            {
                //+= assignment operator to ADD the current "s" value to the string.
                strRoster += s + "\n";
            }
            //loop through books
            foreach (Book b in Curriculum)
            {
                StrCurriculum += b + "\n";
            }
            return $"Course: {Name}\t\tCredit Hours: {CreditHours}\n" +
                $"Department: {Department.ToString().Replace('_', ' ')}\n" +
                $"Curriculum:\n{StrCurriculum}\n" +
                $"Roster:\n{strRoster}\n";
        }
    }
}
