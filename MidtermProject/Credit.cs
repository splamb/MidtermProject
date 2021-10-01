using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Credit: PaymentInfo
    {
        public string PaymentType { get; set; }

        private string _creditCardNumber;

        public string CreditCardNumber
        {
            get
            {
                return _creditCardNumber;
            }
            set
            {
                _creditCardNumber = value;
            }
        }

        private string _expiration;

        public string Expiration
        {
            get
            {
                return _expiration;
            }
            set
            {
                _expiration = value;
            }
        }

        private string _cw;

        public string CW
        {
            get
            {
                return _cw;
            }
            set
            {
                _cw = value;
            }
        }

        public decimal PaymentAmount { get; set; }

        public void PrintReceipt(decimal grandTotal, decimal subtotal, decimal salesTax, Dictionary<Product, int> orderedItems)
        {
            Product[] productKeys = orderedItems.Keys.ToArray();
            foreach (Product product in productKeys)
            {
                Console.WriteLine($"Item: {product.Name}    Amount: {orderedItems.GetValueOrDefault(product)}   Price: {product.Price * orderedItems.GetValueOrDefault(product)}");
            }
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Sales Tax: ${salesTax}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }
    }
}