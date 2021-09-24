using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Check : PaymentInfo
    {
        public string PaymentType { get; set; }

        private string _checkNumber;

        public string CheckNumber
        {
            get
            {
                return _checkNumber;
            }
            set
            {
                _checkNumber = value;
            }
        }

        public float PaymentAmount { get; set; }

        public void PrintReceipt(float grandTotal, float subtotal, List<string> boughtItems)
        {
            Console.WriteLine(boughtItems);
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }
    }
}