using System;

namespace Strategy
{
    public class Aggressive : ITypeOfInvestor
    {
        #region Attributes
        private readonly Random _random;
        #endregion

        #region Constructor
        public Aggressive() => _random = new Random();
        #endregion

        #region Methods 
        public double Calculate(Account account)
        {
            int numRamdom = _random.Next(10);

            if (numRamdom > 0 && numRamdom <= 1)
                return account.Balance * 0.5;
            else if (numRamdom >= 2 && numRamdom <= 4)
                return account.Balance * 0.3;
            else
                return account.Balance * 0.006;
        }
        #endregion
    }
}
