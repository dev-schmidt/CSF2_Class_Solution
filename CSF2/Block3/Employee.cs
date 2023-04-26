using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class Employee
    {
        private int _iD;
        private string  _firstName;
        private string  _lastName;
        private string _jobTitle;
        private DateTime _dateOfHire;//Containment - when a complex datatype HAS another complex
        //datatype as a property or field.
        private bool _isDirectDeposit;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }

        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }
        public DateTime DateOfHire
        {
            get { return _dateOfHire;}
            set { _dateOfHire = value;}
        }
        public bool IsDirectDeposit
        {
            get { return _isDirectDeposit; }
            set { _isDirectDeposit = value; }
        }

        public Employee(int id, string firstName, string lastName, string jobTitle, DateTime dateOfHire, bool isDirectDeposit) 
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName; 
            JobTitle = jobTitle;
            DateOfHire = dateOfHire;
            IsDirectDeposit = isDirectDeposit;
        }

        public override string ToString()
        {
            //return base.ToString();
            //Namespace.ClassName
            return $"ID: {ID}\n" +
                   $"Job Title: {JobTitle}\n" +
                   $"Date of Hire: {DateOfHire.ToShortDateString()}\n" +
                   $"Direct Deposit: {(IsDirectDeposit ? "Enabled" : "Disabled")}";
        }
    }
}
