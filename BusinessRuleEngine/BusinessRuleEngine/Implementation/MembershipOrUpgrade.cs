using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{
    public class MembershipOrUpgrade : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("e-mail the owner and inform them of the activation/upgrade");

            return "MembershipOrUpgrade";
        }
    }
}
