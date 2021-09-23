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

        public float PaymentAmount { get; set; }
    }
}