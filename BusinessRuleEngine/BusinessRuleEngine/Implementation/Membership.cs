using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{

    public class Membership : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine(" activate that membership");

            return "Membership";
        }
    }
}
