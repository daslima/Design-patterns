namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public Budget Discount(Budget budget)
        {
            //more than five items
            if (budget.Items.Count > 5)
            {
                budget.TypeDiscount += "\n Discount More Than Five Items\n ";
                budget.Discount += 0.1;
                return Next.Discount(budget);
            }
                
              
            return Next.Discount(budget);
        }
    }
}
