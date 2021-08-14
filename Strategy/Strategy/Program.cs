using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.ToDeposit(1000);

            InvestmentCalculator investment = new InvestmentCalculator();

            investment.Calculate(account, "Moderate");
        }
    }
}
