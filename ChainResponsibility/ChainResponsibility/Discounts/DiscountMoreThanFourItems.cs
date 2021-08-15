namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanFourItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
             //more than four items
            if (budget.Items.Count == 4)
                return budget.Total * 0.005;

            return Next.Discount(budget);
        }
    }
}
