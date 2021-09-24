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

        public float ProcessPayment()
        {
            float change = 0 - PaymentAmount;
            return change;
        }

        public float PaymentAmount { get; set; }

        public void PrintReceipt(float grandTotal, float subtotal, List<string> boughtItems)
        {
            Console.WriteLine(boughtItems);
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
            Console.WriteLine($"Amount Paid: ${PaymentAmount}");
            Console.WriteLine($"Change Received: ${ProcessPayment()}");
        }
    }
}