namespace TemplateMethod
{
    public class IncomeTax : Tax
    {
        public double CalculateTax(double value)
        {
            if (value > 400 && ValueIs500(value))
                return value * 0.10;
            else
                return value * 0.6;
        }

        private bool ValueIs500(double value)
        {
            if (value == 500)
                return true;
            else
                return false;
        }

    }
}
