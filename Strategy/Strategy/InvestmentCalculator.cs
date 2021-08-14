using System;

namespace Strategy
{
    public class InvestmentCalculator
    {
        public void Calculate(Account account, ITypeOfInvestor typeInvestment)
        {
            double result = typeInvestment.Calculate(account);

            account.ToDeposit(result * 0.75);

            Console.WriteLine($"New Balance: {account.Balance}");


        }
    }
}
