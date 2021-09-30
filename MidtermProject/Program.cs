using System;
using System.IO;
using System.Collections.Generic;


namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sean and Sean's Cafe! Please take a look at our menu below and enter a number to order the respective item.\n");

            List<string> Items = new List<string>();
            DisplayMenu(Items);

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

            bool reorderCheck = false;
            while(reorderCheck != true)
            {
                var orderedItems = new Dictionary<Product, int>();
                bool moreItemsCheck = false;
                while(moreItemsCheck != true)
                {
                    int amount;
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Product coffee = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, coffee, 0);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(coffee, amount);
                            break;

                        case "2":
                            Product espresso = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, espresso, 1);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(espresso, amount);
                            break;

                        case "3":
                            Product latte = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, latte, 2);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(latte, amount); 
                            break;

                        case "4":
                            Product cappuccino = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, cappuccino, 3);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(cappuccino, amount);
                            break;

                        case "5":
                            Product tea = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tea, 4);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(tea, amount);
                            break;

                        case "6":
                            Product orangeJuice = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, orangeJuice, 5);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(orangeJuice, amount);
                            break;

                        case "7":
                            Product appleJuice = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, appleJuice, 6);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(appleJuice, amount);
                            break;

                        case "8":
                            Product water = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, water, 7);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(water, amount);
                            break;

                        case "9":
                            Product sparkling = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, sparkling, 8);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(sparkling, amount);
                            break;

                        case "10":
                            Product croissant = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, croissant, 9);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(croissant, amount);
                            break;

                        case "11":
                            Product bagel = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, bagel, 10);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(bagel, amount); 
                            break;

                        case "12":
                            Product englishMuffin = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, englishMuffin, 11);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(englishMuffin, amount);
                            break;

                        default:
                            Console.WriteLine("Your input was invalid.");
                            break;
                    }

                    bool answerCheck = false;
                    while (answerCheck != true)
                    {
                        Console.WriteLine("Would you like to order another item? (Y/N)");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "y")
                        {
                            Console.WriteLine("Please enter the number for the item you wish to purchase.");
                            moreItemsCheck = false;
                            answerCheck = true;
                        }
                        else if (answer == "n")
                        {
                            moreItemsCheck = true;
                            answerCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("Your answer was invalid.");
                            answerCheck = false;
                        }
                    }
                }



            }
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
        static void DisplayMenu(List<string> Items)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Prices.Add(decimal.Parse(value[2]));
                Console.Write($"{value[0]}. " + $"{value[1]} ");
                Console.WriteLine($"${value[2]}");
                Console.WriteLine($"{value[3]}");
                Console.WriteLine($"{value[4]}\n");
            }
        }
        static void ReadInPrices(List<decimal> Prices)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Prices.Add(decimal.Parse(value[2]));
                //Console.WriteLine(value[2]);
            }
        }

        static void ReadInDrinks(List<string> Drinks)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Drinks.Add(value[1]);
                //Console.WriteLine(value[1]);
            }
        }

        static void ReadInDescriptions(List<string> Descriptions)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Descriptions.Add(value[4]);
            }
        }

        static void ReadInCategories(List<string> Category)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Category.Add(value[3]);
            }
        }

        static void ReadInIDNumbers(List<string> IDNumber)
        {
            string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            //string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";

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
    }
}
