using System;
using System.IO;
using System.Collections.Generic;


namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sean and Sean's Cafe! Please take a look at our menu below and enter a number to order the respective item.");

            List<float> Prices = new List<float>();
            ReadInPrices(Prices);

            List<string> Drinks = new List<string>();
            ReadInDrinks(Drinks);

            List<string> Descriptions = new List<string>();
            ReadInDescriptions(Descriptions);

            List<string> Category = new List<string>();
            ReadInCategories(Category);

            List<string> IDNumber = new List<string>();
            ReadInIDNumbers(IDNumber);

            Product coffee = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, coffee, 0);

            Product espresso = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, espresso, 0);

            Product latte = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, latte, 0);

            Product cappuccino = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, cappuccino, 0);

            Product tea = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tea, 0);

            Product orangeJuice = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, orangeJuice, 0);

            Product appleJuice = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, appleJuice, 0);

            Product water = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, water, 0);

            Product sparkWater = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, sparkWater, 0);

            Product croissant = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, croissant, 0);

            Product bagel = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, bagel, 0);

            Product engMuffin = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, engMuffin, 0);

            //var fileInfo = File.Exists(@"C:\Users\seanf\source\repos\MidtermProject\MidtermProject\ProductList.txt");
            var fileInfo = File.Exists(@"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt");
            //Product product = new Product();
            //Console.WriteLine(product.ReadProductList());

            //List<Product> OrderedItems = new List<Product>();
            //var itemNumber = Console.ReadLine(); 

            //Console.WriteLine("How many of the item would you like?");
            //var amount = int.Parse(Console.ReadLine());

        }

        static void PayBill()
        {
            bool paymentTypeCheck = false;
            while (paymentTypeCheck != true)
            {
                //Console.WriteLine($"Your amount due is {grandTotal}. How will you be paying today?(cash, credit, check)");
                string paymentType = Console.ReadLine().ToLower();

                if (paymentType == "cash")
                {
                    Cash paymentCash = new Cash();
                    paymentCash.PaymentType = "Cash";

                    Console.WriteLine("What amount will you be using to pay?");
                    paymentCash.PaymentAmount = float.Parse(Console.ReadLine());
                    paymentTypeCheck = true;
                }
                else if (paymentType == "credit")
                {
                    Credit paymentCredit = new Credit();
                    paymentCredit.PaymentType = "Credit";

                    Console.WriteLine("What is the credit card number?");
                    paymentCredit.CreditCardNumber = Console.ReadLine();

                    Console.WriteLine("What is the credit card CW?");
                    paymentCredit.CW = Console.ReadLine();

                    Console.WriteLine("Lastly, what is the expiration?");
                    paymentCredit.Expiration = Console.ReadLine();
                    paymentTypeCheck = true;
                }
                else if (paymentType == "check")
                {
                    Check paymentCheck = new Check();
                    paymentCheck.PaymentType = "Check";

                    Console.WriteLine("What is the check number?");
                    paymentCheck.CheckNumber = Console.ReadLine();
                    paymentTypeCheck = true;
                }
                else
                {
                    Console.WriteLine("Your input was invalid. Please try again.");
                }
            }
        }
        static void ReadInPrices(List<float> Prices)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Prices.Add(float.Parse(value[2]));
            }
        }

        static void ReadInDrinks(List<string> Drinks)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Drinks.Add(value[1]);
            }
        }

        static void ReadInDescriptions(List<string> Descriptions)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split('.');
                Descriptions.Add(value[4]);
            }
        }

        static void ReadInCategories(List<string> Category)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split('.');
                Category.Add(value[3]);
            }
        }

        static void ReadInIDNumbers(List<string> IDNumber)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split('.');
                IDNumber.Add(value[0]);
            }
        }

        static void AssignFields(List<string> Drinks, List<float> Prices, List<string> Descriptions, List<string> Category, List<string> IDNumber, Product product, int i)
        {
            product.Name = Drinks[i];
            product.Price = Prices[i];
            product.Description = Descriptions[i];
            product.Category = Category[i];
            product.IDNumber = IDNumber[i];
        }
    }
}
