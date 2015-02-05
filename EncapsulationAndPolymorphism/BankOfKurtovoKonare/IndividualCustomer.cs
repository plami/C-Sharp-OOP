using System;

namespace BankOfKurtovoKonare
{
    public class IndividualCustomer : Customer
    {
        private string egn;

        public IndividualCustomer(string name, string egn)
            : base(name)
        {
            this.Egn = egn;
        }

        public string Egn
        {
            get { return this.egn; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid EGN!");
                }
                this.egn = value;
            }
        }
    }
}