using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple_Prac
{
    public interface IPaymentMethodProcessor
    {
        void ProcessPayment(Payment payment);
    }
}
