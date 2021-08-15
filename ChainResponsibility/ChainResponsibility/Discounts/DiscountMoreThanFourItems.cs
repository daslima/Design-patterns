namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanFourItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public Budget Discount(Budget budget)
        {
             //more than four items
            if (budget.Items.Count > 4)
            {
                budget.TypeDiscount += "\n Discount More Than Four Items \n";
                budget.Discount += 0.05;
                return Next.Discount(budget);
            }

            return Next.Discount(budget);
        }
    }
}
