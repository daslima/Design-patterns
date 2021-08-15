using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget budget = new Budget();

            budget.Items.Add(new Item("Pen", 15.0));
            budget.Items.Add(new Item("Book", 25.9));
            budget.Items.Add(new Item("Mouse", 30.0));

            Console.WriteLine($"Total no discount: ${budget.GetTotal()}");

            Console.WriteLine($"discount: ${new DiscountCalculator().Calculate(budget)}");
            Console.WriteLine($"Total with discount: ${budget.GetTotal() -  new DiscountCalculator().Calculate(budget)}");
        }
    }
}
