using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple_Prac
{
    public class PaymentProcessor
    {
        private IDictionary<PaymentMethod, IPaymentMethodProcessor> processors = new Dictionary<PaymentMethod, IPaymentMethodProcessor>();

        public PaymentProcessor() 
        {

            //processors.Add(PaymentMethod.CREDIT_CARD, new CreditCardProcessor());
        }
    }

    //public interface IPaymentMethodProcessor
    //{
    //    void ProcessPayment(Payment payment);
    //}

    //public class CreditCardProcessor : IPaymentMethodProcessor
    //{
    //    public void ProcessPayment(Payment payment)
    //    {
    //        // Process credit card payment
    //    }
    //}

    //public class PayPalProcessor : IPaymentMethodProcessor
    //{
    //    public void ProcessPayment(Payment payment)
    //    {
    //        // Process PayPal payment
    //    }
    //}

    //public class BitcoinProcessor : IPaymentMethodProcessor
    //{
    //    public void ProcessPayment(Payment payment)
    //    {
    //        // Process Bitcoin payment
    //    }
    //}

    //public class PaymentProcessor
    //{
    //    private IDictionary<PaymentMethod, IPaymentMethodProcessor> processors = new Dictionary<PaymentMethod, IPaymentMethodProcessor>();

    //    public PaymentProcessor()
    //    {
    //        processors.Add(PaymentMethod.CreditCard, new CreditCardProcessor());
    //        processors.Add(PaymentMethod.PayPal, new PayPalProcessor());
    //        processors.Add(PaymentMethod.Bitcoin, new BitcoinProcessor());
    //    }

    //    public void ProcessPayment(Payment payment)
    //    {
    //        IPaymentMethodProcessor processor;
    //        if (processors.TryGetValue(payment.Method, out processor))
    //        {
    //            processor.ProcessPayment(payment);
    //        }
    //    }
    //}


}
