using System;

namespace BankOfKurtovoKonare
{
    public class CompanyCustomer : Customer
    {
        private string bulstat;

        public CompanyCustomer(string name, string bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }

        public string Bulstat
        {
            get { return this.bulstat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Bulstat!");
                }
            }
        }
    }
}