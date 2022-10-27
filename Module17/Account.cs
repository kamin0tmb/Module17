namespace Module17
{
    public abstract class Account : ICalculate
    {
        // Баланс учетной записи.
        public double Balance { get; set; }

        // Процентная ставка.
        public double Interest { get; set; } = 0;

        public Account(double balance)
        {
            Balance = balance;
        }

        public abstract void CalculateInterest();
    }
}