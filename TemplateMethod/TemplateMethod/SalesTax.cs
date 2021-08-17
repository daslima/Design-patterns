namespace TemplateMethod
{
    public class SalesTax : TemplateTax
    {
        public override double HighestRate(double value) => value * 0.07;

        public override double LowerRate(double value) => value * 0.5;

        public override bool ValidateOperation(double value) => value >= 500;

    }
}
