namespace Strategy
{
    public class Account
    {
        public double Balance { get; private set; }

        public void ToDeposit(double value)
        {
            Balance += value;
        }
    }
}
