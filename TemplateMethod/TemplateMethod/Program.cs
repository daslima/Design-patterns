using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sales Tax: {new SalesTax().CalculateTax(480.0)}");
            Console.WriteLine($"Income Tax: {new IncomeTax().CalculateTax(500)}");

        }
    }
}
