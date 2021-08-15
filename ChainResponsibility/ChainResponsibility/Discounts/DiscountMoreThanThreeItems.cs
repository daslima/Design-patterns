namespace ChainResponsibility.Discounts
{
    public class DiscountMoreThanThreeItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public Budget Discount(Budget budget)
        {
            //more than three items
            if (budget.Items.Count > 3)
            {
                budget.TypeDiscount += "\n Discount More Than Three Items \n";
                budget.Discount += 0.03;
                return Next.Discount(budget);
            }
                
           
            return Next.Discount(budget);
        }
    }
}
