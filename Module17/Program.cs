using System;

namespace Module17
{
    class Program
    {
        static void Main(string[] args)
        {
            var Account1 = new AccountOrdinary(80000.0);
            var Account2 = new AccountSalary(2000.0);
            var Account3 = new AccountOrdinary(5000.0);

            Calculator.CalculateInterestAccount(Account1);

            Calculator.CalculateInterestAccount(Account2);

            Calculator.CalculateInterestAccount(Account3);
        }
    }
}