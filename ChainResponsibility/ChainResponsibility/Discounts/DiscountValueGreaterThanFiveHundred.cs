namespace ChainResponsibility.Discounts
{
    public class DiscountValueGreaterThanFiveHundred : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            //value greater than 500
            if (budget.Total > 500)
                return budget.Total * 0.15;

            return Next.Discount(budget);
        }
    }
}
