using System;

namespace InheritanceAndAbstraction
{
    public abstract class People
    {
        private string name;

        protected People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty or null!");
                }
                this.name = value;
            }
        }

        public string Details { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}