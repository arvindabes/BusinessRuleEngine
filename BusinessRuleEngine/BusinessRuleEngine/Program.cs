using BusinessRuleEngine.Interface;
using System;

namespace BusinessRuleEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write payment type and press ENTER!");

            string paymentType = Console.ReadLine();

            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();

            IOrderProcessing orderProcessing = strategy.ResolveStrategy(paymentType);

            orderProcessing.ProcessOrder();

            Console.WriteLine("\n Order Processing Completed!");

            Console.ReadLine();
        }
    }
}
