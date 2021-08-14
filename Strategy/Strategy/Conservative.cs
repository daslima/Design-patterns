namespace Strategy
{
    public class Conservative : ITypeOfInvestor
    {
        #region Methods 
        public double Calculate(Account account) => account.Balance * 0.008;
        #endregion
    }
}
