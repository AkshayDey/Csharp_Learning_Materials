using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple_Prac
{
    public class BitcoinProcessor : IPaymentMethodProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Bit Coin Processing");
        }
    }
}
