using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Store;

namespace Block4
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            #region Animal
            Animal animal = new Animal() { Name = "Base" };
            Console.WriteLine($"{animal.Name} says {animal.Speak()}");

            Dog dog = new() { Name = "Scooby" };
            Console.WriteLine($"{dog.Name} says {dog.Speak()}");

            Cat cat = new() { Name = "Sylvester" };
            Console.WriteLine($"{cat.Name} says {cat.Speak()}");

            Bird bird = new() { Name = "Tweety" };
            Console.WriteLine($"{bird.Name} says {bird.Speak()}");

            List<Animal> animalBox = new()
            {
                animal, dog, cat, bird
            };
            //animal is boxed as an animal.
            //they're all boxed as animal
            //polymorphism
            foreach (Animal item in animalBox)
            {
                Console.WriteLine($"{item.Name} says {item.Speak()}");
            }
            #endregion
            //CTRL + K, CTRL + S to surround with a snippet #region

            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();//comment this out if you want to see the animal stuff
            SignatureLibrary.Signature.Header("*** STORE ***");

            Product p1 = new("Iocane Powder", 299.99m, "Odorless, tasteless, dissolves instantly in liquid.");
            Console.WriteLine(p1);
            //CalcHolidayDiscount is an instance method because it requires the Price from a specific
            //instance of a Product object.
            Console.WriteLine("{0}'s discounted price is {1:c}", 
                p1.Name, //{0}
                p1.CalcHolidayDiscount()); //{1}

            //DisplayReturnPolicy is a static method because it doesn't need any information about
            //a specific object. Rather, it relates to ALL Product objects.
            Console.WriteLine(Product.DisplayReturnPolicy());

            Console.WriteLine("\n--- SOFTWARES ---\n");
            Software s1 = new("Halo 2", 5.99m, "Old Skool", false, OS.Windows, "3.Bad", false, new
                DateTime(2007, 10, 23));
            Console.WriteLine(s1);

            List<Product> products = new() { p1, s1 };
            p1.Price = 100;
            s1.Price = 100;

            foreach (Product item in products)
            {
                Console.WriteLine($"{item.Name, -15}\t{item.Price:c}\t{item.CalcHolidayDiscount():c}");
                //-15 lines up Halo 2 with Iocane Powder in the console. It makes it take up 15 character places
            }

        }//end main

    }//end Inheritance class
     //methods

    class Animal
    {
        public string Name { get; set; }

        //the virtual keyword makes it so that the follow method is able to be overridden in a child
        //class.
        public virtual string Speak()
        {
            return "Silence";
        }
    }
    //internal class called dog extends the class "Animal"
    class Dog : Animal
    {
        public override string Speak()
        {
            //return base.Speak();
            return "Bow wow";
        }
    }//end Dog class

    class Cat : Animal
    {
        public override string Speak()
        {
            return "Meow";
        }
    }

    class Bird : Animal
    {
        public override string Speak()
        {
            return "Chirp";
        }
    }
}

