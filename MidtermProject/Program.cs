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

            List<decimal> Prices = new List<decimal>();
            ReadInPrices(Prices);

            List<string> Drinks = new List<string>();
            ReadInDrinks(Drinks);

            List<string> Descriptions = new List<string>();
            ReadInDescriptions(Descriptions);

            List<string> Category = new List<string>();
            ReadInCategories(Category);

            List<string> IDNumber = new List<string>();
            ReadInIDNumbers(IDNumber);

            

            Product espresso = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, espresso, 1);

            Product latte = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, latte, 2);

            Product cappuccino = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, cappuccino, 3);

            Product tea = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tea, 4);

            Product orangeJuice = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, orangeJuice, 5);

            Product appleJuice = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, appleJuice, 6);

            Product water = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, water, 7);

            Product sparkWater = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, sparkWater, 8);

            Product croissant = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, croissant, 9);

            Product bagel = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, bagel, 10);

            Product engMuffin = new Product();
            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, engMuffin, 11);

            bool reorderCheck = false;
            while(reorderCheck != true)
            {
                List<Product> OrderedItems = new List<Product>();
                bool moreItemsCheck = false;
                while(moreItemsCheck != true)
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Product tempProduct1 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct1, 0);
                            return;

                        case "2":
                            Product tempProduct2 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct2, 1);
                            return;

                        case "3":
                            Product tempProduct = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct, 2);
                            return;

                        case "4":
                            Product tempProduct4 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct4, 3);
                            return;

                        case "5":
                            Product tempProduct5 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct5, 4);
                            return;

                        case "6":
                            Product tempProduct6 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct6, 5);
                            return;

                        case "7":
                            Product tempProduct7 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct7, 6);
                            return;

                        case "8":
                            Product tempProduct8 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct8, 7);
                            return;

                        case "9":
                            Product tempProduct9 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct9, 8);
                            return;

                        case "10":
                            Product tempProduct10 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct10, 9);
                            return;

                        case "11":
                            Product tempProduct11 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct11, 10);
                            return;

                        case "12":
                            Product tempProduct12 = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tempProduct12, 11);
                            return;

                        default:
                            Console.WriteLine("Your input was invalid.");
                            return;
                    }
                        
                }



            }

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
        static void ReadInPrices(List<decimal> Prices)
        {
            // string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Prices.Add(decimal.Parse(value[2]));
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
                var value = s.Split(',');
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
                var value = s.Split(',');
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
                var value = s.Split(',');
                IDNumber.Add(value[0]);
            }
        }

        static void AssignFields(List<string> Drinks, List<decimal> Prices, List<string> Descriptions, List<string> Category, List<string> IDNumber, Product product, int i)
        {
            product.Name = Drinks[i];
            product.Price = Prices[i];
            product.Description = Descriptions[i];
            product.Category = Category[i];
            product.IDNumber = IDNumber[i];
        }

        static void 
    }
}
