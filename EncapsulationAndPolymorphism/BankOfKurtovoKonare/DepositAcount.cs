using System;

namespace BankOfKurtovoKonare
{
    public class DepositAcount : Account,IWithdraw
    {
        public DepositAcount(Customer customer, decimal interestRate, decimal balance)
            : base(customer, interestRate, balance)
        {
        }

        public void WithdrawMoney(decimal sum)
        {
            if (this.Balance < sum)
            {
                throw new ArithmeticException("Insufficient amount.");
            }

            this.Balance = -sum;
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(periodOfMonths);
        }
    }
}