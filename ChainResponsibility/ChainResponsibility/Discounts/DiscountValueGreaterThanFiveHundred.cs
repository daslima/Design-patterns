namespace ChainResponsibility.Discounts
{
    public class DiscountValueGreaterThanFiveHundred : IDiscount
    {
        public IDiscount Next { get; set; }

        public Budget Discount(Budget budget)
        {
            //value greater than 500
            if (budget.Total > 500)
            {
                budget.TypeDiscount += "\n Discount Value Greater Than Five Hundred \n";
                budget.Discount += 0.15;
                return Next.Discount(budget);
            }
               
            return Next.Discount(budget);
        }
    }
}
