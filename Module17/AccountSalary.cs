using System;
namespace Module17
{
    public class AccountSalary : Account
    {
        public AccountSalary(double balance) : base(balance)
        {
        }

        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {Interest}");
        }
    }
}