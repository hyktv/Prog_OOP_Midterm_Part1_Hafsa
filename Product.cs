using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_Hafsa
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string ExpiryDate { get; set; }
        public abstract void DisplayProductInfo();


        public Product (string name, double price, string size, string color, string brand, string expiryDate)
        {
            Name = name;
            Price = price; 
            Size = size; 
            Color = color;
            Brand = brand;
            ExpiryDate = expiryDate;
        }

        public void DisplayProductInformation()
        {
            Console.WriteLine("Product Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
        }


        //**9** encapsulation is one of the principles of OOP that involves bundling
        //data and methods that opertate on the dtaa into a single unit called class.

        //**10** OOP principles include encapsulation, inheritance, polymorphism and abstraction


        protected Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        //public virtual void DisplayProductInfo()
        //{
        //    Console.WriteLine("Product Information");
        //    Console.WriteLine($"Name: {Name}");
        //    Console.WriteLine($"Price: {Price}");
        //}

        //**11** this is not a question :)

        //**12** virtual indicates that a method can be overridden in derived classes.

        //**13** virtual method allows subclasses of the type to override the method.
        //it is used to ensure that the correct type of function is called for an object

        //**14** derived means a class that inherits properties from another class

        //**15** "base" class is what the class is derived from

        ////////*******************************//////////

        //**22** an abstract class cannot be directly instantiated and serve as a base for other classes

        //**23** Abstract methods don't have a body in the base class because they are
        //meant to be implemented by derived classes. Virtual methods have a default
        //implementation in the base class but can be overridden in derived classes.

        //**24** By making Product abstract, you enforce the idea that it is meant to be a base
        //class and should not be instantiated on its own. Instead, it serves as a foundation for creating
        //more specialized classes through inheritance. The protected constructor ensures that only
        //inheriting classes can perform the necessary initialization through their own constructors.

        //**25** When you changed the DisplayProductInfo() method from virtual to abstract in the base class
        //Product, the derived classes are now required to provide their own implementation of the method.


    }
}
