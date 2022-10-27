namespace Module17
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterestAccount(ICalculate account)
        {
            account.CalculateInterest();
        }
    }
}