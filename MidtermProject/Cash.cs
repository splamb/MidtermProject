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

    }
}