﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public interface PaymentInfo
    {
        public string PaymentType { get; set; }

        public float PaymentAmount { get; set; }

        public void PrintReceipt(float grandTotal, float subtotal, List<string> boughtItems);
    }
}