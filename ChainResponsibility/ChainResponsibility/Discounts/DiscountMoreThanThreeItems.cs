namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanThreeItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            //more than three items
            if (budget.Items.Count == 3)
                return budget.Total * 0.03;
           
            return Next.Discount(budget);
        }
    }
}
