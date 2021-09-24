using System;
using System.IO;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fileInfo = File.Exists(@"C:\Users\seanf\source\repos\MidtermProject\MidtermProject\ProductList.txt");
            Product product = new Product();
            Console.WriteLine(product.ReadProductList());
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
    }
}
