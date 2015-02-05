using System;

namespace BankOfKurtovoKonare
{
    public class MortgageAccount : Account
    {
        protected MortgageAccount(Customer customer, decimal interestRate, decimal balance) 
            : base(customer, interestRate, balance)
        {
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            var halfInterestMonths = 0;
            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    halfInterestMonths = 6;
                    break;
                case "CompanyCustomer":
                    halfInterestMonths = 12;
                    break;
                default:
                    throw new NotImplementedException("There is not this case.");
            }

            var fullInterestMonths = periodOfMonths - halfInterestMonths;

            if (fullInterestMonths <= 0)
            {
                return base.CalculateInterest(halfInterestMonths) / 2;
            }

            return base.CalculateInterest(halfInterestMonths) / 2 + base.CalculateInterest(fullInterestMonths);
        }
    }
}