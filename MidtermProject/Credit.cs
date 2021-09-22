using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Credit
    {
        public string PaymentType { get; set; }

        private int _creditCardNumber;

        public int CreditCardNumber
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

        private int _expiration;

        public int Expiration
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

        private int _cw;

        public int CW
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

        public float PaymentAmount { get; set; }
    }
}