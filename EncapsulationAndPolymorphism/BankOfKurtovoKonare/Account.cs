using System;

namespace BankOfKurtovoKonare
{
    public class Account : IDeposit, ICalculateInterest
    {
        private Customer customer;
        private decimal interestRate;
        private decimal balance;

        protected Account(Customer customer, decimal interestRate, decimal balance)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid customer!");
                }
                this.customer = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The interest rate cannot be negative or zero!");
                }
                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid balance!");
                }
                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int periodOfMonths)
        {
            var interestForPeriod = this.balance * this.interestRate * periodOfMonths;
            return interestForPeriod;
        }

        public void DepositMoney(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentNullException("The sum cannot be negative!");
            }
            this.Balance += sum;
        }
    }
}