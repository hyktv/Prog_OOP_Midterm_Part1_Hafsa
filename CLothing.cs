using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_Hafsa
{
    internal class CLothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public CLothing (string name, double price, string size, string color) : base(name, price)
        {
            Size = size;
            Color = color;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Clothing Type: {Name}, Price: {Price}, Size: {Size}, Color: {Color}");
        }

        //**21** because we overided the display method each time 
    }
}
