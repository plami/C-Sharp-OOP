using System;

namespace BankOfKurtovoKonare
{
    public abstract class Customer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }
    }
}