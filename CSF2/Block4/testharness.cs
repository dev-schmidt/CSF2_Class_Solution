using SignatureLibrary;
using University;
namespace Block4
{
    internal class testharness
    {
        static void Main(string[] args)
        {
            Signature.Header("Custom Datatype Review");
            Console.WriteLine("\n--- BOOKS ---\n");

            Book bk1 = new Book("The Count of Monte Cristo", "Penguin Publishing", "0486456439");
            Book bk2 = new("Xanathar's Guide to Everything", "Wizards of the Coast", "0796966114");
            Console.WriteLine(bk1);
            Console.WriteLine(bk2);

            Console.WriteLine("\n--- STUDENTS ---\n");
            var s1 = new Student("Derek Zoolander", 123, 0.4, Dept.Finger_Painting, "bluesteel@aol.com");
            Student s2 = new("Hansel", 456, 3.8, Dept.Break_Dance_Fighting, "sohotrightnow@yahoo.com");
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n--- COURSE ---\n");
            //It is often easier to create the required collections BEFORE creating the object that needs
            //them.
            List<Student> students = new() { s1, s2 };
            var books = new List<Book>() { bk1, bk2 };

            Course c1 = new("Selling Is As Selling Does", Dept.Jedi_Mind_Tricking,students,books,12);
            Console.WriteLine(c1);

            Signature.Footer();
        }
    }
}