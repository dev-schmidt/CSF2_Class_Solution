namespace Store
{
    public class Product
    {

        private readonly static string _policy = "All returns must be processed within 90 days of purchase.";

        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsInStock { get; set; }

        public Product(string name, decimal price, string description, bool isInStock)
        {
            Name = name;
            Price = price;
            Description = description;
            IsInStock = isInStock;
        }//FQCTOR - fully qualified constructor

        public Product() 
        {
            //you can assign default values to all of your
            //properties here.
            //Name = "TestProduct"
            //Price = 0;
        }//DEFAULT CTOR

        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
            //This constructor does not have a parameter for IsInStock. We COULD 
            //leave that property unassigned, but it's safer to give it a default value.
            //Let's assume that any Products added using this constructor ARE in stock.
            IsInStock = true;
        }//FQCTOR

        public override string ToString()
        {
            return $"Product Name: {Name}\n" +
                $"Price: {Price:c}\n" +
                $"{Description}\n" +
                $"{(IsInStock ? "" : "(out of stock)")}\n";
        }
        //REFRESHER - Static vs Instance

        public static string DisplayReturnPolicy()
        {
            //return Name;//Static methods CANNOT access non-static (instance) class members
            return _policy;//policy is static, so we CAN use it in static methods.
        }
        //Instance methods are used with respect to a specific "instance" of an object of this type.
        //Static methods tend to have some general use that relates to the class as a whole.

        public virtual decimal CalcHolidayDiscount()
        {
            //the virtual keyword allows, but does not require, this method to be overridden in child
            //classes.
            //By default, let's say all products get a 5% discount.
            //100 * .05 = 5
            //Price * (1 - Discount)
            decimal newPrice = //Price - (Price * .05m);
                Price * .95m;
            return newPrice;
        }
    }//end class
    
}//end namespace