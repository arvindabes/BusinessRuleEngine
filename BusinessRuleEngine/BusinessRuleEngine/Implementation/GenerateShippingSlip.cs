using BusinessRuleEngine.Interface;
using System;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Implementation
{
    public class GenerateShippingSlip : IOrderProcessing
    {
        public string  ProcessOrder()
        {
            Console.WriteLine("generate a packing slip for shipping");

            return "ShippingSlipGenerated";
        }
    }
}
