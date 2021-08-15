namespace ChainResponsibility.Discounts
{
    public class DiscountDefault : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget) => 0;

    }
}
