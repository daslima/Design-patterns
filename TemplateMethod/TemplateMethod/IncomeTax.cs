namespace TemplateMethod
{
    public class IncomeTax : TemplateTax
    {
        public override double HighestRate(double value) => value * 0.10;

        public override double LowerRate(double value) => value * 0.6;

        public override bool ValidateOperation(double value) => value == 500;

    }
}
