using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{
    public class RoyalityDepartmentSlip : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("create a duplicate packing slip for the royalty department");

            return "DuplicatePackingSlip";
        }
    }
}
