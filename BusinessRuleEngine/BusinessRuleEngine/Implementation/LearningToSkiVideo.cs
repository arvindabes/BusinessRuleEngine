using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine.Implementation
{

    public class LearningToSkiVideo : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("First-Aid Video To Packing Slip");

            return "FirstAddVideoToPackingSlip";
        }
    }
}

