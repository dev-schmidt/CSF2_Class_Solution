namespace SignatureLibrary
{
    //We created this project as a class library. This type of project will compile to a .DLL
    //Dynamic Link Library.
    //Class libraries cannot run on their own. NO SVMs.
    //The first class is public by default. Any subsequent classes will default to internal.
    //public -> accessible anywhere in the solution.
    //internal -> accessible only within this assembly (SignatureLibrary)
    public class Signature
    {
        public static void Header(string title)
        {
            Console.Title = "- " + title.ToUpper() + " -";
            Console.WriteLine("-= CSF2: " + title.ToUpper() + " =-");
        }//end header

        public static void Footer()
        {
            Console.WriteLine("\n\nAll code has ended. Press any key to terminate the " +
                "program...");
            Console.ReadKey();
        }
        /*
         * To use these methods in another project there are 3 things to consider:
         * 1) The class must be accessible (public)
         * 2) You must add a project reference to this library in the consuming application.
         * - Right clicking on the consuming project dependencies > Add Project Reference
         * 3) You can optionally add a using statement in the consuming class to make life easier.
         */
    }
}