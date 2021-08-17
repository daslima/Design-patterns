namespace TemplateMethod
{
    public class SalesTax : Tax
    {
        public double CalculateTax(double value)
        {
            if (value >= 500)
                return value * 0.07;
            else
                return value * 0.5;
        }

    }
}
