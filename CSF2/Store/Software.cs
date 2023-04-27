using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public enum OS
    {
        Linux,
        iOS,
        PalmOS,
        Unix,
        Windows,
        Mac,
        Android
    }
    public class Software : Product
    {
        public OS OperatingSystem { get; set; }
        public string Version { get; set; }
        public bool IsSupported { get; set; }
        public DateTime PublishDate { get; set; }


        //Constructors
        //copy the parameter list from the parent list
        public Software(string name, decimal price, string description, bool isInStock,//from the parent list
            OS operatingSystem, string version, bool isSupported, DateTime publishDate) 
            : base(name,price,description,isInStock)
        {
            //We COULD handle all of the assignment here.
            //However, we can also make use of the parent class's ctor using the ":base()" above.
            //Name = name;
            //Price = price;
            //hande the assignment for this class's unique props
            OperatingSystem = operatingSystem;
            Version = version;
            IsSupported = isSupported;
            PublishDate = publishDate;
        }

        public override string ToString()
        {
            //base.ToString() will return the Product .ToString()
            return base.ToString() + $"OS: {OperatingSystem}\t\tVersion: {Version}\n" +
                $"{(char)169}{PublishDate.Year}\n" +
                $"{(IsSupported ? "" : "Out of order")}" ;
        }
        //Let's suppose that software gets a total of 20% off during the holidays.
        //MINI Lab
        //override the CalcHolidayDiscount() to return a 20% discount on all software.
        public override decimal CalcHolidayDiscount()
        {
            //return base.CalcHolidayDiscount();
            return Price * .8m;
        }
    }//end class
}//end namespace
