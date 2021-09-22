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

        private int _checkNumber;

        public int CheckNumber
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
    }
}