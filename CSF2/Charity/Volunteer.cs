namespace Charity
{
    /*
    * This Class Library project is intended to store classes that will be consumed 
    * elsewhere in the application. Storing them here makes the application more
    * modular (all of the Charity classes are in one place) and reusable (all
    * of the classes can be used anywhere in the application). In order to use it 
    * in another project we have to ensure that any classes we want to use are public,
    * the consuming project has a reference to this project and, optionally, that any
    * consuming classes have a using statement for this namespace.
    */
    public class Volunteer
    {
        //NO SVM
        //Intended as a blueprint to make an object/instance of "this" type
        //class members
        //FIELDS (aka attributes)
        //represent the physical location for information stored about an object of "this" type.
        //Naming Convention: _camelCase
        //Access modifier: private
        private string _name;
        private byte _yearsOfService;
        private bool _isActive;

        //Properties
        //Control access to the fields by establishing "rules" for getting or setting
        //the values of the field variables
        //Naming Convention: PascalCase version of the _fieldName
        //Access Modifier: public

        /*
         * public datatype PascalName
         * {
         *    //accessors
         *    get { return _field;}
         *    set {_field = value; }
         */
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name
        public byte YearsOfService
        {
            get { return _yearsOfService; }
            set { _yearsOfService = value; }
        }//end YearsOfService
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }//end IsActive
        //FIELDS are where the data is stored. Props are the "gatekeeper"
    }//end class
}//end namespace