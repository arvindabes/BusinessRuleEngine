using BusinessRuleEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Implementation
{    

    public class LearningToSkiVideo : IOrderProcessing
    {
        public string ProcessOrder()
        {
            Console.WriteLine("First Add Video To Packing Slip");

            return "FirstAddVideoToPackingSlip";
        }
    }
}

