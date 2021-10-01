using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sean and Sean's Cafe!\n");

            List<string> Items = new List<string>();

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

            string reorderAnswer;
            bool reorderCheck = false;
            while(reorderCheck != true)
            {
                decimal subtotal = 0;
                decimal grandTotal = 0;
                decimal salesTax = 0;
                decimal taxRate = .06M;
                var orderedItems = new Dictionary<Product, int>();
                bool moreItemsCheck = false;
                while(moreItemsCheck != true)
                {
                    Console.WriteLine("Please take a look at our menu below and enter a number to order the respective item.\n");
                    DisplayMenu(Items);
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
                            Console.WriteLine($"Added {amount} of item {coffee.Name} at ${Math.Round((coffee.Price * amount), 2)}.");
                            break;

                        case "2":
                            Product espresso = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, espresso, 1);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(espresso, amount);
                            Console.WriteLine($"Added {amount} of item {espresso.Name} at ${Math.Round((espresso.Price * amount), 2)}.");
                            break;

                        case "3":
                            Product latte = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, latte, 2);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(latte, amount);
                            Console.WriteLine($"Added {amount} of item {latte.Name} at ${Math.Round((latte.Price * amount), 2)}.");
                            break;

                        case "4":
                            Product cappuccino = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, cappuccino, 3);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(cappuccino, amount);
                            Console.WriteLine($"Added {amount} of item {cappuccino.Name} at ${Math.Round((cappuccino.Price * amount), 2)}.");
                            break;

                        case "5":
                            Product tea = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, tea, 4);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(tea, amount);
                            Console.WriteLine($"Added {amount} of item {tea.Name} at ${Math.Round((tea.Price * amount), 2)}.");
                            break;

                        case "6":
                            Product orangeJuice = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, orangeJuice, 5);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(orangeJuice, amount);
                            Console.WriteLine($"Added {amount} of item {orangeJuice.Name} at ${Math.Round((orangeJuice.Price * amount), 2)}.");
                            break;

                        case "7":
                            Product appleJuice = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, appleJuice, 6);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(appleJuice, amount);
                            Console.WriteLine($"Added {amount} of item {appleJuice.Name} at ${Math.Round((appleJuice.Price * amount), 2)}.");
                            break;

                        case "8":
                            Product water = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, water, 7);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(water, amount);
                            Console.WriteLine($"Added {amount} of item {water.Name} at ${Math.Round((water.Price * amount), 2)}.");
                            break;

                        case "9":
                            Product sparkling = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, sparkling, 8);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(sparkling, amount);
                            Console.WriteLine($"Added {amount} of item {sparkling.Name} at ${Math.Round((sparkling.Price * amount), 2)}.");
                            break;

                        case "10":
                            Product croissant = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, croissant, 9);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(croissant, amount);
                            Console.WriteLine($"Added {amount} of item {croissant.Name} at ${Math.Round((croissant.Price * amount), 2)}.");
                            break;

                        case "11":
                            Product bagel = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, bagel, 10);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(bagel, amount);
                            Console.WriteLine($"Added {amount} of item {bagel.Name} at ${Math.Round((bagel.Price * amount), 2)}.");
                            break;

                        case "12":
                            Product englishMuffin = new Product();
                            AssignFields(Drinks, Prices, Descriptions, Category, IDNumber, englishMuffin, 11);
                            Console.WriteLine("How many would you like?");
                            amount = int.Parse(Console.ReadLine());
                            orderedItems.Add(englishMuffin, amount);
                            Console.WriteLine($"Added {amount} of item {englishMuffin.Name} at ${Math.Round((englishMuffin.Price * amount), 2)}.");
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
                subtotal = CalculateSubtotal(orderedItems, subtotal);
                salesTax = Math.Round((subtotal * taxRate), 2);
                grandTotal = Math.Round((subtotal + salesTax), 2);
                PayBill(orderedItems, subtotal, salesTax, grandTotal);

                Console.WriteLine("\nThank you for your order. Would you like to start another? (Y/N)");
                bool reorderAnswerCheck = false;
                while (reorderAnswerCheck != true)
                {
                    reorderAnswer = Console.ReadLine().ToLower();
                    if (reorderAnswer == "y")
                    {
                        reorderCheck = false;
                        reorderAnswerCheck = true;
                    }
                    else if (reorderAnswer == "n")
                    {
                        reorderCheck = true;
                        reorderAnswerCheck = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input was invalid. Please try again.");
                        reorderAnswerCheck = false;
                    }
                }
            }
            Console.WriteLine("Thank you for visiting Sean and Sean's Cafe! Please come again soon.");
        }

        static void PayBill(Dictionary<Product, int> orderedItems, decimal subtotal, decimal salesTax, decimal grandTotal)
        {
            bool paymentTypeCheck = false;
            while (paymentTypeCheck != true)
            {
                Console.WriteLine($"Your amount due is ${grandTotal}. How will you be paying today?(cash, credit, check)");
                string paymentType = Console.ReadLine().ToLower();

                if (paymentType == "cash")
                {
                    Cash paymentCash = new Cash();
                    paymentCash.PaymentType = "Cash";

                    Console.WriteLine("What amount will you be using to pay?");
                    paymentCash.PaymentAmount = decimal.Parse(Console.ReadLine());
                    paymentCash.PrintReceipt(grandTotal, subtotal, salesTax, orderedItems, paymentCash);
                    paymentTypeCheck = true;
                }
                else if (paymentType == "credit")
                {
                    Credit paymentCredit = new Credit();
                    paymentCredit.PaymentType = "Credit";

                    bool creditCardNumberCheck = false;
                    while (creditCardNumberCheck != true)
                    {
                        Console.WriteLine("What is the credit card number?");
                        paymentCredit.CreditCardNumber = Console.ReadLine();
                        if (paymentCredit.CreditCardNumber.Length == 16)
                        {
                            creditCardNumberCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("The credit card number input was invalid.");
                        }
                    }

                    bool creditCWCheck = false;
                    while(creditCWCheck != true)
                    {
                        Console.WriteLine("What is the credit card CW?");
                        paymentCredit.CW = Console.ReadLine();
                        if(paymentCredit.CW.Length == 3)
                        {
                            creditCWCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("The CW input was invalid.");
                        }
                    }

                    bool creditExpirationCheck = false;
                    while(creditExpirationCheck != true)
                    {
                        Console.WriteLine("Lastly, what is the expiration?(MMYY)");
                        paymentCredit.Expiration = Console.ReadLine();
                        if(paymentCredit.Expiration.Length == 4)
                        {
                            creditExpirationCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("The expiration input was invalid.");
                        }
                    }


                    paymentCredit.PrintReceipt(grandTotal, subtotal, salesTax, orderedItems);
                    Console.WriteLine($"Your payment for ${grandTotal} was processed successfully.");
                    paymentTypeCheck = true;
                }
                else if (paymentType == "check")
                {
                    Check paymentCheck = new Check();
                    paymentCheck.PaymentType = "Check";

                    bool checkNumberCheck = false;
                    while (checkNumberCheck != true)
                    {
                        Console.WriteLine("What is the check number?");
                        paymentCheck.CheckNumber = Console.ReadLine();
                        if(paymentCheck.CheckNumber.Length == 4)
                        {
                            checkNumberCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("Your check number input was invalid.");
                        }
                    }
 
                    paymentCheck.PrintReceipt(grandTotal, subtotal, salesTax, orderedItems);
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
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
            string path = @"D:\Source\Repos\MidtermProject\MidtermProject\ProductList.txt";
            string[] readText = File.ReadAllLines(path);

            foreach (string s in readText)
            {
                var value = s.Split(',');
                Console.Write($"{value[0]}. " + $"{value[1]} ");
                Console.WriteLine($"${value[2]}");
                Console.WriteLine($"{value[3]}");
                Console.WriteLine($"{value[4]}\n");
            }
        }
        static void ReadInPrices(List<decimal> Prices)
        {
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
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
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
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
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
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
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
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
            //string path = @"C:\Users\SFlanigan1\source\repos\MidtermProject\MidtermProject\ProductList.txt";
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

        static decimal CalculateSubtotal(Dictionary<Product, int> orderedItems, decimal subtotal)
        {
            Product[] productKeys = orderedItems.Keys.ToArray();
            foreach (Product product in productKeys)
            {
                decimal tempNum = product.Price * orderedItems.GetValueOrDefault(product);
                subtotal = subtotal + tempNum;
            }
            return subtotal;
        }
    }
}
