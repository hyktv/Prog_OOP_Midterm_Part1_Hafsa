using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_Hafsa
{
    internal class Groceries : Product
    {
        public string ExpiryDate { get; set; }

        public Groceries (string name, double price, string expiryDate) : base (name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Grocery Item: {Name}, Expiry Date: {ExpiryDate}, Price: {Price}");
        }

        //**16** property and constructor

        //**17** it calls for the constructor of the base class which is product
        //from the derived class which is groceries and passing the values for
        //name and price to the product class

        //**18** using "override" indicates that the method is intentionally providing
        //a new implementation for a virtual or abstract method in the base class.
        //if you take away "virtual" from the method in the base class, you won't
        //be able to override it in derived classes.


    }
}
