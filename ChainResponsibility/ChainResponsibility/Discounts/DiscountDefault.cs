namespace ChainResponsibility.Discounts
{
    public class DiscountDefault : IDiscount
    {
        public IDiscount Next { get; set; }

        public Budget Discount(Budget budget)
        {
            if (budget.Discount.Equals(0))
            {
                budget.TypeDiscount = "DiscountDefault";
                budget.Discount = 0;
            }
            return budget;
        }

    }
}
