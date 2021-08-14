namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.ToDeposit(1000);

            ITypeOfInvestor conservative = new Conservative();
            ITypeOfInvestor moderate = new Moderate();
            ITypeOfInvestor aggressive = new Aggressive();


            InvestmentCalculator investment = new InvestmentCalculator();

            investment.Calculate(account, moderate);
        }
    }
}
