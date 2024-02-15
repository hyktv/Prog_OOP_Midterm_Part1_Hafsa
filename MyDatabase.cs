using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_Hafsa
{
    public static class MyDatabase
    {
        //private static List<string> data; //static feild
        private static List<Product> data;
        static MyDatabase()
        {
            Console.WriteLine("The list is loading");
            Console.WriteLine("The list is loading");
            CLothing tShirt = new CLothing("T-shirt", 19.99, "Medium", "Red");
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");

            data = new List<Product>();

            data.Add(tShirt);
            data.Add(smartphone);
            data.Add(banana);


            //data = new List<string>
            //{
            //    "Data 1",
            //    "Data 2",
            //    "Data 3",
            //    "Data 4",
            //    "Data 5"
            //};
        }//static mydatabase

        //public static List<string> Data //static property
        //{
        //    get { return data; }
        //}

        public static List<Product> Data
        {
            get { return data; }
        }

        //**3** the static modifier means that the it belongs to the
        //class itself rather than the instance of the class 

        //**4** no, you dont need an instance of an object to call a
        //static method because you can call it directly on the class itself

        //**5** no, you cant create an instance of a static class
        //because they cant be initiated and theres no need

        //**6** no, you cant call a static constructor because its automatically
        //called by the runtime (CLR - common language runtime) before any static
        //methods are accessed and anything else is initialized

        //**7** no, i didnt have to create an instance of MyDatabase to access
        //data because its a static property of the myDatabase class. 

        //**8** chatgpt says it would be printed when the relevant part of the code is executed



    }//public static class mydatabase
}
