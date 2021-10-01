using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Cash : PaymentInfo
    {
        public string PaymentType { get; set; }

        public decimal ProcessPayment(Cash paymentCash, decimal grandTotal)
        {
            decimal change = grandTotal - paymentCash.PaymentAmount;
            return Math.Round(change, 2);
        }

        public decimal PaymentAmount { get; set; }

        public void PrintReceipt(decimal grandTotal, decimal subtotal, decimal salesTax, Dictionary<Product, int> orderedItems, Cash paymentCash)
        {
            Product[] productKeys = orderedItems.Keys.ToArray();
            foreach(Product product in productKeys)
            {
                Console.WriteLine($"Item: {product.Name}    Amount: {orderedItems.GetValueOrDefault(product)}   Price: {product.Price * orderedItems.GetValueOrDefault(product)}");
            }
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Sales Tax: ${salesTax}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
            Console.WriteLine($"Amount Paid: ${Math.Round(paymentCash.PaymentAmount, 2)}");
            Console.WriteLine($"Change Received: ${ProcessPayment(paymentCash, grandTotal)}");
        }
    }
}