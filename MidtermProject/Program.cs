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
    }
}
