namespace ChainResponsibility.Discounts
{
    public interface IDiscount
    {
        IDiscount Next { get; set; }

        double Discount(Budget budget);
     
    }
}
