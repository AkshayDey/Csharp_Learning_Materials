using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple_Prac
{
    public class PayPalProcessor : IPaymentMethodProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("PayPal Processing");
        }
    }
}
