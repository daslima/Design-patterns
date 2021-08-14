using System;

namespace Strategy
{
    public class Moderate : ITypeOfInvestor
    {
        #region Attributes
        private readonly Random _random;
        #endregion

        #region Constructor
        public Moderate() => _random = new Random();
        #endregion

        #region Methods 
        public double Calculate(Account account)
        {
            if (_random.Next(2) == 0)
                return account.Balance * 0.025;
            else
                return account.Balance * 0.007;
        }
        #endregion
    }
}
