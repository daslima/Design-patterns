using System;

namespace Strategy
{
    public class InvestmentCalculator
    {
        public void Calculate(Account account, string typeInvestment)
        {
            double result  = 0;

            if ("Conservative".Equals(typeInvestment))
            {
                result = account.Balance * 0.008;
            }
            else if ("Moderate".Equals(typeInvestment))
            {
                Random random = new Random();

                if (random.Next(2) == 0)
                    result = account.Balance * 0.025;
                else
                    result = account.Balance * 0.007;

            }
            else if ("Aggressive".Equals(typeInvestment))
            {
                Random random = new Random();
                int numRamdom = random.Next(10);

                if (numRamdom > 0 && numRamdom <= 1)
                    result = account.Balance * 0.5;
                else if (numRamdom >= 2 && numRamdom <= 4)
                    result = account.Balance * 0.3;
                else
                    result = account.Balance * 0.006;
            }

            account.ToDeposit(result * 0.75);

            Console.WriteLine($"New Balance: {account.Balance}");


        }
    }
}
