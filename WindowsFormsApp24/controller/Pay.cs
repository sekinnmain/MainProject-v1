using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Pay
    {
        public string creditCardNumber;
        public string threeDigit;
        public string expirationDate;
        public Pay()
        {

        }
        public Pay(string creditCardNumber,string expirationDate, string threeDigit)
        {
            this.creditCardNumber = creditCardNumber;
            this.threeDigit = threeDigit;
            this.expirationDate = expirationDate;
        }

        public string creditCardNumberP { get { return this.creditCardNumber; } set { this.creditCardNumber = value; } }
        public string threeDigitP { get { return this.threeDigit; } set { this.threeDigit = value; } }
        public string expirationDateP { get { return this.expirationDate; } set { this.expirationDate = value; } }




    }
}
