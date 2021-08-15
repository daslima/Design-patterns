namespace ChainResponsibility.Discounts
{
    public interface IDiscount
    {
        IDiscount Next { get; set; }

        Budget Discount(Budget budget);
     
    }
}
