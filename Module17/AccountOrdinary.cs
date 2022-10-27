using System;
namespace Module17
{
    public class AccountOrdinary : Account
    {
        public AccountOrdinary(double balance) : base(balance)
        {
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"Процентная ставка для обычного аккаунта: {Interest}");
        }
    }
}