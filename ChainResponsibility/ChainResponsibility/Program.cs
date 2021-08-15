using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget budget = new Budget();

            budget.Items.Add(new Item("Pen", 15.0));
            budget.Items.Add(new Item("Book", 25.0));
            budget.Items.Add(new Item("Mouse", 30.0));
            budget.Items.Add(new Item("Keyboard", 50.0));
  

            Console.WriteLine($"Total no discount: ${budget.GetTotal()}");

            var budgetReturn = new DiscountCalculator().Calculate(budget);

            Console.WriteLine($"Type discount: {budgetReturn.TypeDiscount}");
            Console.WriteLine($" Discount: {budgetReturn.Discount * 100}%");

            var Discount = budgetReturn.GetTotal() * budgetReturn.Discount;

            Console.WriteLine($"Total with discount: ${budgetReturn.GetTotal() - Discount}");

        }
    }
}
