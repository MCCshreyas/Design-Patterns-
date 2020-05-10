using System;

namespace DesignPatterns
{
    class Program
    {
        public static void Main()
        {
            CalculateFactory obj = new CalculateFactory();
            var op = obj.GetCalculation("add");
            op.Calculate(10,20);

            var sub = obj.GetCalculation("subtract");
            sub.Calculate(10,20);

            Console.ReadLine();
        }
    }
}
/*
 * Factory pattern allows you to centralized a place where objects are created as requested by user in this above example CalculateFactory is our factory for creating objects.
 */
