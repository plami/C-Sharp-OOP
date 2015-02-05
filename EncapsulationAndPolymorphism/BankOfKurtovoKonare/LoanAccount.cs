using System;

namespace BankOfKurtovoKonare
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal interestRate, decimal balance)
            : base(customer, interestRate, balance)
        {
        }

        public override decimal CalculateInterest(int periodOfMonths)
        {
            var monthsInterestFree = 0;

            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    monthsInterestFree = 3;
                    break;
                case "CompanyCustomer":
                    monthsInterestFree = 2;
                    break;
                default:
                    throw new NotImplementedException("There is not this case.");
            }
            if (periodOfMonths <= monthsInterestFree)
            {
                return 0m;
            }

            return base.CalculateInterest(periodOfMonths - monthsInterestFree);
        }
    }
}