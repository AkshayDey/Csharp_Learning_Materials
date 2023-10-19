using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Prac_1
{
    public interface IPaymentMethodProcessor
    {
        void processPayment(Payment payment);
    }
}
