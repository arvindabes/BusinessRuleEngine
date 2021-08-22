using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{
    public class UpgradeMembership : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("apply the upgrade");

            return "UpgradeMembership";
        }
    }
}
