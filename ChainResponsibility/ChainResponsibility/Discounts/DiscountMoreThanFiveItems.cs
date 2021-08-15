namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            //more than five items
            if (budget.Items.Count > 5)
                return budget.Total * 0.1;
              
            return Next.Discount(budget);
        }
    }
}
