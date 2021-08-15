using ChainResponsibility.Discounts;

namespace ChainResponsibility
{
    public class DiscountCalculator
    {
        public Budget Calculate(Budget budget)
        {
            IDiscount d1 = new DiscountMoreThanFiveItems();
            IDiscount d2 = new DiscountMoreThanFourItems();
            IDiscount d3 = new DiscountMoreThanThreeItems();
            IDiscount d4 = new DiscountValueGreaterThanFiveHundred();
            IDiscount d5 = new DiscountDefault();

            d1.Next = d2;
            d2.Next = d3;
            d3.Next = d4;
            d4.Next = d5;

            return d1.Discount(budget);
        }
    }
}
