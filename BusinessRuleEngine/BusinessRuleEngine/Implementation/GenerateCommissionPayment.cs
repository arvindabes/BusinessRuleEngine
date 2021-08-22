using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{
    public class GenerateCommissionPayment : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("generate a commission payment to the agent");

            return "CommissionPaymentToAgent";
        }
    }
}
