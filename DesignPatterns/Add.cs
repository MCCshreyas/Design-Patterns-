using System;

namespace DesignPatterns
{
    public class Add : ICalculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine($"Addition is {a + b}");
        }
    }

}
