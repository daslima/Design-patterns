namespace ChainResponsibility
{
    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            //more than five items
            if (budget.Items.Count >  5)
            {
                return budget.Total * 0.1;
            } //more than four items
            else if(budget.Items.Count == 4)
            {
                return budget.Total * 0.005;
            }//more than three items
            else if(budget.Items.Count == 3)
            {
                return budget.Total * 0.03;
            }//value greater than 500
            else if(budget.Total > 500)
            {
                return budget.Total * 0.15;
            }

            return 0;
        }
    }
}
