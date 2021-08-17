namespace TemplateMethod
{
    public abstract class TemplateTax : Tax
    {
        public double CalculateTax(double value)
        {
            if (ValidateOperation(value))
                return HighestRate(value);
            else
                return LowerRate(value);
        }

        public abstract bool ValidateOperation(double value);
        public abstract double HighestRate(double value);
        public abstract double LowerRate(double value);

    }
}
