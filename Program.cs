namespace Prog_OOP_Midterm_Part1_Hafsa
{
    //Hafsa Mohamed
    //02/13/24

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myLocalList = new List<string> 
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            }; 
        
            //display or manipulate the local list as needed
            foreach (string item in myLocalList) 
            {
                Console.WriteLine(item);
            }

            //**1** creating an instance of an object means to create a specific
            //occurence of a class resulting in a object with its own set of properties
            //ex. Car myCar = new Car(); --- "Car" is the class and "myCar" is the instance of the class

            //**2** creating a local variable means declaring a variable within a method
            //or a block of code. local variables are only accessible with the particular scope.


            //access the static property to get the data
            //List<string> dataList = MyDatabase.Data; 

            //display the data from the static class
            //foreach (string item in dataList)
            //{
               //Console.WriteLine(item);
            //}


            //testing our products class with sample data
            //Product product = new Product("T-shirt ", 19.99, "Medium", "Red", "", "");

            //product.DisplayProductInformation();


            //creating new instance of groceries
            Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");

            //call the DisplayProductInfo method to display the bananas details
            banana.DisplayProductInformation();


            //**19** anything that is public but basically all class members

            //**20** the public and internal access modifiers would allow
            //everything in the project to have access to class members

            // Testing Clothing
            CLothing tShirt = new CLothing("T-shirt", 19.99, "Medium", "Red");
            tShirt.DisplayProductInfo();

            // Testing Electronics
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            smartphone.DisplayProductInfo();

            List<Product> productList = new List<Product>();

            productList.Add(tShirt);
            productList.Add(smartphone);
            productList.Add(banana);

            foreach (Product product in productList)
            {
                product.DisplayProductInfo();
            }


            //**22** 

            //**23** because of polymorphism

            //**24** to access the expiry date field, you would need to either cast
            //the object to its actual type or use methods that expose that field.

            List<Product> dataList = MyDatabase.Data;

            foreach (Product product in productList)
            {
                product.DisplayProductInfo();
            }


            // Using our UpdateConfig method to change our connection string.
            // Make sure to pass in the correct information
            Config.UpdateConnectionString("CramberryFarms", "training", "Admin", "1234");

            // Saving the connectionString to a local variable
            string connectionString = Config.ConnectionString;

            // Using the Database.ConnectToDatabase() method that takes a
            // formatted connection string to connect
            Database db = Database.ConnectToDatabase(connectionString);

            // If it connects, grab the data as a list of product
            // In the real world theres a lot of framework and code to make this happen
            List<Product> data = db.Data();

            //Saving a reference to an object in our list
            Product testGetType = data[0];

            // Display the type of the object
            Console.WriteLine(testGetType.GetType());

            // Saving a local variable holding the type of a specific object, here groceries.
            Type groceryType = typeof(Groceries);

            // Comparing GetType to typeof(Groceries)
            bool sameType = testGetType.GetType() == groceryType;

            // Printing the result
            Console.WriteLine($"Are they the same time:  {sameType}");

            // Display our list of product from the training table.
            foreach (Product d in data)
            {
                d.DisplayProductInfo();
            }


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Items");
                Console.WriteLine("2. Display Electronics");
                Console.WriteLine("3. Display Groceries");
                Console.WriteLine("4. Display Clothing");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllItems(data);
                        break;
                    case 2:
                        // DisplayElectronics();
                        break;
                    case 3:
                        // DisplayGroceries();
                        break;
                    case 4:
                        // DisplayClothing();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }//main

        static void DisplayAllItems(List<Product> data)
        {
            foreach (Product product in data)
            {
                product.DisplayProductInfo();
            }

        }

        static void DisplayElectronics(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product.GetType() == typeof(Electronics))
                {
                    product.DisplayProductInfo();
                }
            }
        }

        static void DisplayGroceries(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product is Groceries groceries)
                {
                    groceries.DisplayProductInfo();
                }
            }
        

        }

        static void DisplayClothing(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product is CLothing clothing)
                {
                    clothing.DisplayProductInfo();
                }
                //if (product.GetType() == typeof(CLothing))
                //{
                //product.DisplayProductInfo();
                //}
            }
        }

        //**27**  To get the type of an instance of an object, you can use the GetType() method. 

        //**28** To check if one type is another, you can use the is keyword.


    }//class

}//namespace