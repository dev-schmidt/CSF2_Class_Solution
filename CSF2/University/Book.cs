namespace University
{
    public class Book
    {
        //FIELDS
        //A full prop is only required if you have business rules. So, we only need fields for 
        //props with business rules.


        //PROPERTIES
        //Auto properties can be created with prop + tab

        public string Title { get; set; }
        //this syntax is shorthand for creating a property
        //with the default getter and setter. At runtime, the compiler
        //will take stock of these props and create the necesarry fields
        //for data storage.

        public string Publisher { get; set; }

        public string ISBN { get; set; }

        //CONSTRUCTORS

        public Book(string title, string publisher, string isbn)
        {
            //Assignment
            //Property = Parameter
            //PascalCase = camelCase
            //White = blue
            Title = title;
            Publisher = publisher;
            ISBN = isbn;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();)Namespace.ClassName
            return Title;
        }
    }
}